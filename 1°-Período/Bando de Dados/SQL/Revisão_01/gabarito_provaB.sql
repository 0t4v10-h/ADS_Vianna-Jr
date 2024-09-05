/*RESPOSTAS PROVA B  FBD*/

/*QUESTÃO 1*/
create table musica(
id int,
id_album int,
nome varchar(50),
duracao decimal(4,2),
constraint pk_musica primary key(id));


/*QUESTÃO 2*/
/*Gravadora*/
alter table gravadora change column nome nome_gravadora varchar(50),
add column endereco varchar(70);

/*Artista*/
alter table artista add column cpf int;
alter table artista add constraint ck unique(cpf),
modify nome varchar(50) NOT NULL;

/*Album*/
alter table album add column pago char(3) check(pago='sim' or pago='não'),
modify column ano year default '2023';

/*QUESTÃO 3*/
insert into musica values
(1,1,'One',7.25),
(2,1,'Blackend',6.42),
(3,2,'Enter Sadman',5.3),
(4,2,'Sad Blut True',5.29),
(5,3,'Master of Puppets',8.35),
(6,3,'Battery',5.13),
(7,4,'Dialectic Chaos',2.26),
(8,4,'Endgame',5.57),
(9,5,'Peace Sells',4.09),
(10,5,'The Conjuring',5.09),
(11,6,'Madhouse',4.26),
(12,6,'I am the Law',6.03),
(13,7,'Reptile',3.36),
(14,7,'Modern Girl',4.49),
(15,8,'Ridding with the King',4.23),
(16,8,'Key to the Highway',3.39);

/*QUESTÃO 4*/
alter table musica add constraint fk_musica_album foreign key(id_album) references album(id) on update cascade on delete cascade;