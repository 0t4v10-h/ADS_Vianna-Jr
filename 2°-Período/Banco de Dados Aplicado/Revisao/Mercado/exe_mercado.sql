USE `mercado`;
/*QUESTÃO 01: Traga todas as informações dos produtos que não foram vendidos. */
select p.*
from produto as p
left join produto_vendido as pv
on p.ID_PRODUTO = pv.ID_PRODUTO
where pv.NR_VENDA is null;

/*QUESTÃO 02:Traga todas as informações dos clientes que não efetuaram nenhuma compra. */
select c.*
from cliente as c
left join venda as v
on c.ID_CLIENTE = v.ID_CLIENTE
where v.NR_VENDA is null;

/*QUESTÃO 03: Traga as informações do produto que possui 
maior quantidade em estoque.*/
select *
from produto
where estoque = (select max(estoque) from produto);

/*QUESTÃO 04:Traga as informações do produto que 
possui o menor valor.*/
select *
from produto
where PRECO_UNITARIO = (select min(PRECO_UNITARIO) from produto);

/*QUESTÃO 05: Recupere o id do produto e a quantidade de produtos
 que foram vendidos. Traga apenas as vendas que tiveram 
 mais de 5 produtos vendidos. Ordene da maior para menor quantidade de produtos vendidos.
Por exemplo: o produto 100 vendeu 13 unidades */
select id_produto, sum(quantidade) as qtd_produtos
from produto_vendido
group by ID_PRODUTO
having qtd_produtos > 5
order by qtd_produtos desc;

/*QUESTÃO 06: Traga o número da venda juntamente com a 
quantidade vendida.
Por exemplo: a venda 1000 vendeu 16 unidades */
select nr_venda, count(quantidade) as qtd_vendido
from produto_vendido
group by NR_VENDA;

/* QUESTAO 07: Recupere as informações dos clientes e a quantidade de 
compras que eles efetuaram. Caso o cliente não tenha 
efetuado nenhuma compra, o valor 0 deverá ser mostrado na 
frente das informações do cliente.
OBS: Quando efetuamos a contagem de uma coluna, 
a coluna que tiver o valor nulo é contada com o valor 0. */
create view cliente_compras as
select c.*, count(v.nr_venda) as qtd_compras
from cliente as c
left join venda as v
on c.ID_CLIENTE = v.ID_CLIENTE
group by c.ID_CLIENTE;
select * from cliente_compras;