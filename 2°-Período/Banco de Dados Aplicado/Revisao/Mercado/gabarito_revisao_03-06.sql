/*QUESTÃO 01: Traga todas as informações dos produtos que não foram vendidos. 
Utilize junção externa.*/
select p.*
from produto p left join produto_vendido pv on p.id_produto = pv.id_produto
where nr_venda is null;

/*QUESTÃO 01_1: Traga todas as informações dos produtos que não foram vendidos. 
Utilize subconsultas.*/
select *
from produto
where id_produto not in(select id_produto from produto_vendido);

/*QUESTÃO 02:Traga todas as informações dos clientes que não efetuaram 
nenhuma compra. Utilize junção externa.*/
select c.*
from cliente c left join venda v on c.id_cliente = v.id_cliente
where nr_venda is null;

/*QUESTÃO 02:Traga todas as informações dos clientes que não efetuaram 
nenhuma compra. Utilize subconsultas.*/
select *
from cliente
where id_cliente not in(select id_cliente from venda);

/*QUESTÃO 03: Traga as informações do produto que possui 
maior quantidade em estoque.*/
select *
from produto
where estoque=(select max(estoque) from produto);

/*QUESTÃO 04:Traga as informações do produto que 
possui o menor valor.*/
select *
from produto
where preco_unitario=(select min(preco_unitario) from produto);

/*QUESTÃO 05:Recupere o do produto e a quantidade de produtos
 que foram vendidos. Traga apenas as vendas que tiveram 
 mais de 5 produtos vendidos. Ordene da maior para menor quantidade de produtos vendidos.
Por exemplo: o produto 100 vendeu 13 unidades
*/
select id_produto, sum(quantidade) as qdade_produtos
from produto_vendido
group by id_produto
having qdade_produtos>5
order by qdade_produtos desc;

/*QUESTÃO 06: Traga o número da venda juntamente com a 
quantidade vendida.
Por exemplo: a venda 1000 vendeu 16 unidades
*/
select nr_venda, sum(quantidade) as qdade_produtos
from produto_vendido
group by nr_venda;

/*Recupere as informações dos clientes e a quantidade de 
compras que eles efetuaram. Caso o cliente não tenha 
efetuado nenhuma compra, o valor 0 deverá ser mostrado na 
frente das informações do cliente.
OBS: Quando efetuamos a contagem de uma coluna, 
a coluna que tiver o valor nulo é contada com o valor 0.
*/
select c.*, count(nr_venda) as qdade_comprada
from cliente c left join venda v on c.id_cliente = v.id_cliente
group by c.id_cliente;