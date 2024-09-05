/**/
-- Criando a base de dados faculdade
create database faculdade;
-- selecionando o banco de dados para uso
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
    noma VARCHAR(40),
    ch INT
);

-- Eliminando a tabela curso
drop table curso;

-- Eliminando a base de dados com todas as tabelas que ela possui
drop database faculdade;