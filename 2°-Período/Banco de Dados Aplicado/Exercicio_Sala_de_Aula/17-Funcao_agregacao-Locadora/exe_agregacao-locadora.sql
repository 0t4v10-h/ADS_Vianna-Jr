use locadora;

/* 1)	Liste o nome dos clientes e a quantidade de filmes que eles locaram, ordenando da maior para menor quantidade. */
select c.nome_cliente, count(l.codigo_locacao) as qtd
from cliente as c
inner join locacao as l 
on c.codigo_cliente = l.codigo_cliente
group by c.codigo_cliente
order by qtd desc;

/*  2)	Liste o titulo do filme, o nome dos clientes que locaram o mesmo filme por mais de uma vez.
OBS: Você deverá agrupar por mais de uma coluna */
select titulo, nome_cliente
from cliente as c
inner join locacao as l
on c.codigo_cliente = l.codigo_cliente
inner join filme as f
on f.codigo_filme = l.codigo_filme
group by c.codigo_cliente, f.codigo_filme
having count(*) > 1;

/* 3)	Liste os dados dos clientes que locaram mais de um filme no mesmo dia.
OBS: Você deverá agrupar por mais de uma coluna */
select nome_cliente
from cliente as c
inner join locacao as l
on c.codigo_cliente = l.codigo_cliente
inner join filme as f
on f.codigo_filme = l.codigo_filme
group by c.codigo_cliente, data_locacao
having count(*) > 1;

/* 4)	Liste os dados dos atores que fizeram 2 ou mais filmes. */
select a.*
from ator as a
inner join filme_ator as fa
on a.codigo_ator = fa.codigo_ator
group by a.codigo_ator
having count(fa.codigo_filme) >= 2;

/*  5)	Liste a quantidade de filmes de cada gênero. */
select count(fg.codigo_filme)
from filme_genero as fg
inner join genero as g
on fg.codigo_genero = g.codigo_genero
having fg.codigo_genero = (select f.codigo_filme
from filme as f
inner join filme_genero as fg
on f.codigo_filme = fg.codigo_filme);

/*  7)	Liste as datas e a quantidade de filmes locados em cada dia. */