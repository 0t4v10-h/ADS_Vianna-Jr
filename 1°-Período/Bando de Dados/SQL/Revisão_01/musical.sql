create database musical;
use musical;

CREATE TABLE musica (
    id INT PRIMARY KEY,
    id_album INT,
    nome VARCHAR(50),
    duracao DECIMAL(4 , 2 )
);

alter table musica change column nome nome_musica varchar(50);

alter table musica add column cantor varchar(30);

alter table musica add constraint ck unique(duracao);

alter table musica modify nome_musica varchar(50) not null;

alter table musica add column pago varchar(20) check(pago='sim' or pago='nao');
alter table musica change column pago pago char(3);

insert into musica (id, id_album, nome_musica) values
(1,1,'Oi'),
(2,2,'Tchau');

CREATE TABLE album (
    id INT,
    id_musica INT,
    nome VARCHAR(30)
);

alter table album modify id int primary key;

alter table musica add foreign key(id) references album(id) on update cascade on delete cascade;
