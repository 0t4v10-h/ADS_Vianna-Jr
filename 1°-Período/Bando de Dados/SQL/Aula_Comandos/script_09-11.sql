/**/
-- Criando a base de dados faculdade
create database faculdade;

-- Selecionando o banco de dados para uso
use faculdade;

-- Criando a tabela aluno
CREATE TABLE aluno (
    matricula DECIMAL(5) PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    datanasc DATE,
    codcurso CHAR(3)
);

-- Abrindo a descrição da tabela
desc aluno;

-- Criando a tabela curso
CREATE TABLE curso (
    codcurso CHAR(3),
    nome VARCHAR(40),
    ch INT
);
/*Usando o change para alterar o nome e tipo da coluna*/
alter table curso change ch carga_horaria decimal(5);

/*Usando o change para alterar apenas o nome da coluna*/
alter table curso change nome nome_curso varchar(40);

/*Usando o change para alterar apenas o tipo da coluna*/
alter table curso change codcurso codcurso char(5);

/*Alterando o tipo da coluna com modify*/
alter table aluno modify nome varchar(100);

/*Adicionando a chave primária da tabela curso*/
alter table curso add primary key(codcurso, nome_curso);

/*Eliminando a chave primária criada errado*/
alter table curso drop primary key;

/*Adicionando a chave primária correta da tabela curso*/
alter table curso add primary key (codcurso);

/*Eliminando a coluna carga_horaria da tabela curso*/
alter table curso drop carga_horaria;

/*Adicionando as colunas rua, bairro, cidade e cep na tabela aluno*/
alter table aluno add rua varchar(50),
				  add cidade varchar(30),
				  add bairro varchar(25),
				  add cep decimal(8);
                  
                  
/*Alterando o tipo da coluna codcurso na tabela aluno*/
alter table aluno modify codcurso char(5);

/*Criando a chave estrangeira da tabela aluno*/
alter table aluno add foreign key(codcurso) references
curso(codcurso);

/*Colocando o valor padrão Juiz de Fora para a coluna cidade*/
alter table aluno alter cidade set default 'Juiz de Fora';

desc aluno;

/*Colocando não nulo na coluna datanasc*/
alter table aluno modify datanasc date not null;

/*OU*/
alter table aluno change datanasc datanasc date not null;

insert into curso values('ADS','Análise e Desenvolvimento de Sistemas');

insert into aluno(matricula, nome, datanasc, codcurso) 
values (38120,'Otávio', '1999-10-26', 'ADS');

insert into aluno(matricula, nome, datanasc, codcurso)
values (12345, 'Zé Ruela', '2000-01-01', 'ADS');

/*Retirando a trava de segurança*/
set sql_safe_updates=0;

/*Excluindo o aluno da tabela*/
delete from aluno where matricula=12345;

/*Colocando o valor Centro como valor padrão de bairro*/
alter table aluno alter bairro set default 'Centro';
/*OU*/
alter table aluno modify bairro varchar(25) default 'Centro';
/*OU*/
alter table aluno change bairro bairro varchar(25) default 'Centro'; 

insert into aluno(matricula, nome, datanasc, codcurso)
values (12345, 'Zé Ruela', '2000-01-01', 'ADS');

/*Criando a coluna cpf na tabela aluno*/
alter table aluno add cpf decimal(11);

/*Colocando cpf como chave candidata da tabela aluno.
Funciona apenas quando a chave candidata é composta por uma unica coluna.*/
alter table aluno modify cpf decimal(11) unique;

/*ou
Funciona apenas quando a chave candidata é composta por uma unica coluna.*/
alter table aluno change cpf cpf decimal(11) unique;

/*ou
Funciona em todos os casos*/
alter table aluno add unique(cpf);

desc aluno;

/*Voltando com a possibilidade de valores nulos para a coluno datanasc*/
alter table aluno modify datanasc date null;

/*Colocando a faixa de valores permitida para as datas de nascimento*/
alter table aluno add check(datanasc>'2000-01-01');

desc aluno;

insert into aluno(matricula, nome, datanasc)
values(4,'João','200-01-25');

insert into aluno(matricula, nome, datanasc)
values(7,'Maria','2000-01-09');

/*Criando a coluna ativo na tabela aluno com a restrição de valores
Sim e Não*/
alter table aluno add ativo char(3) check(ativo='Sim' or ativo='Não');

/*Tentando violar a restrição de integridade referencial*/
insert into aluno(matricula, curso, codcurso) values
(5, 'Ana','DIR');

set sql_safe_updates = 0;

/*Eliminando a chave estrangeira da tabela aluno para cria-la
com com cascade para update e delete*/
alter table aluno drop foreign key aluno_ibfk_1;

/*Criando a chave estrangeira novamente com on delete cascade e on 
pdate cascade*/
alter table aluno add foreign key(codcurso) references
curso(codcurso) on delete cascade on update cascade;

/*Chave estrangeira criada com cascade para update e delete
tentando excluir um registro da tabela que possui dependência*/
delete from curso where codcurso='ADS';