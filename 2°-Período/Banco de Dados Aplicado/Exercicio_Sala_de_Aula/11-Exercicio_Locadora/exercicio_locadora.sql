use locadora;

/* QUESTÃO 01: Traga o nome de todos os filmes, os que foram locados por algum cliente, traga também o nome do cliente.
Traga também o nome de todos os clientes, os que locaram  ou não filmes, caso tenha locado o nome do filme deverá aparecer. */
select titulo, nome_cliente
from filme as f
left join locacao as l on f.codigo_filme = l.codigo_filme
left join cliente as c on l.codigo_cliente = c.codigo_cliente
union 
select titulo, nome_cliente
from filme as f
right join locacao as l on f.codigo_filme = l.codigo_filme
right join cliente as c on l.codigo_cliente = c.codigo_cliente;

/* QUESTÃO 02: Traga o nome dos gêneros que não estão em nenhum filme. */
select nome_genero 
from genero as g
left join filme_genero as fg on g.codigo_genero = fg.codigo_genero
left join filme as f on fg.codigo_filme = f.codigo_filme
where fg.codigo_genero is null;

/* QUESTÃO 03: Traga o nome de todos os diretores. Caso ele tenha dirigido algum filme, traga o nome do filme. */
select nome_diretor, titulo
from diretor as d 
left join filme_diretor as fd on d.codigo_diretor = fd.codigo_diretor
left join filme as f on fd.codigo_filme = f.codigo_filme;

/* QUESTÃO 04: Traga o nome e cpf de todos os clientes, caso ele tenha locado algum filme, traga o titulo do filme e a data de locação. */
select nome_cliente, cpf, titulo, data_locacao
from cliente as c
left join locacao as l on c.codigo_cliente = l.codigo_cliente
left join filme as f on f.codigo_filme = l.codigo_filme;

/* QUESTÃO 05: Traga o título dos filmes, juntamente com o nome dos atores que atuaram nele. */
select titulo, nome_ator
from filme as f
left join filme_ator as fa on f.codigo_filme = fa.codigo_filme
left join  ator as a on fa.codigo_ator = a.codigo_ator;

/* QUESTÃO 06: Traga o nome dos clientes que alugaram filmes do gênero comédia. */
select nome_cliente
from cliente as c
left join locacao as l on c.codigo_cliente = l.codigo_cliente
left join filme_genero as fg on l.codigo_filme = fg.codigo_filme
left join genero as g on fg.codigo_genero = g.codigo_genero
where g.nome_genero = 'comedia';

/* Traga o nome dos filmes que não foram locados por ninguem. */
select titulo
from filme as f
left join locacao as l on f.codigo_filme = l.codigo_filme
where data_locacao is null;