/*RESPOSTAS PROVA A  FBD*/

/*QUESTÃO 1*/
create table produto_vendido
(
	nr_venda int,
    id_produto int,
    quantidade decimal(5,2),
    constraint pk primary key(nr_venda, id_produto)
);

/*QUESTÃO 2*/
/*Tabela Cliente*/
alter table cliente change nome nome_cliente varchar(45),
add column cpf int unique,
modify sexo char(1) default 'M' not null;

/*Tabela produto*/
alter table produto add column descricao varchar(100),
modify nome varchar(50) not null;

/*Tabela venda*/
alter table venda add column pago char(3) check(pago = 'sim' or pago = 'nao');

/*QUESTÃO 3*/
insert into produto_vendido values
(1000, 100, 10.00),
(1000, 110, 2.00),
(1000, 120, 1.00),
(1000, 140, 1.00),
(1000, 150, 1.00),
(1000, 170, 1.00),
(1001, 100, 2.00),
(1002, 100, 1.00),
(1002, 140, 5.00),
(1002, 160, 1.00),
(1002, 170, 1.00),
(1003, 140, 1.00),
(1003, 150, 1.00),
(1004, 110, 1.00),
(1004, 150, 1.00),
(1004, 160, 1.00);

/*QUESTÃO 4*/
alter table produto_vendido add constraint fk_pv_venda foreign key(nr_venda) references venda(nr_venda) on update cascade on delete cascade;
alter table produto_vendido add constraint fk_pv_produto foreign key(id_produto) references produto(id_produto) on update cascade on delete cascade;








