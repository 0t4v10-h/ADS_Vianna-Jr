USE `loja_virtual`;
/*Banco de Dados loja_virtual*/
/* 01: Recupere todas as informações dos clientes que não efeituaram nenhuma compra. 
Utiliza junção externa ou not in. (8 linhas retornadas) */
select cl.* 
from cliente as cl
left join compra as c
on cl.ClienteId = c.ClienteId
where c.CompraId is null;
 
/* 02: Traga todas as informações dos produtos em que o preço de venda é pelo menos 60% a mais 
que o preço de custo. Ordene do maior para o menor preço de venda. (4 linhas retornadas) */
SELECT *
FROM produto
WHERE PrecoVenda >= 1.6 * PrecoCusto
ORDER BY PrecoVenda DESC;

/* 03: Recupere o id da compra, o nome do cliente e o valor total (incluindo o frete). O valor total
da compra devera ser calculado multiplicando o valor de venda do produto pela quantidade comprada.
Em sequida, deve-se somar todos os produtos adiconados no carrinho e em seguida o valor do frete.
(8 linhas retornadas) */
select c.compraId, cl.PrimNome, sum(p.precoVenda * ca.quantidade + c.frete) as valor_total
from cliente as cl
left join compra as c
on cl.ClienteId = c.ClienteId
left join carrinho as ca
on c.CompraId = ca.CompraId
left join produto as p 
on ca.ProdutoId = p.ProdutoId
group by c.CompraId, cl.PrimNome
having valor_total is not null;

USE `loja`;
/*Banco de Dados Loja*/
/*QUESTÃO 01: Recupere todas as informações dos vendedores que não efetuaram nenhuma venda. 
Utilize junção externa ou not in.(8 linhas retornadas)*/
select v.*
from vendedor as v
left join pedido as p 
on v.cod_vendedor = p.cod_vendedor
where num_pedido is null;

/* 02: Traga todas as informações dos clientes, 
juntamente com a quantidade de pedidos que eles efetuaram. 
(14 linhas retornadas)*/
select c.*, count(*) as qtd_pedidos
from cliente as c
inner join pedido as p
on c.cod_cliente = p.cod_cliente
group by c.cod_cliente;

/* 03: Recupere o numero do pedido, o nome do cliente e o valor total. O valor total
da compra devera ser calculado multiplicando o valor de item pela quantidade comprada. Em seguida,
deve-se somar todos os produtos que estao no pedido. (11 linhas retornadas). */
select p.num_pedido, c.nome_cliente, sum(ip.quantidade * ip.valor_item) as valor_total
from pedido as p
left join cliente as c
on p.cod_cliente = c.cod_cliente
left join item_pedido as ip
on p.num_pedido = ip.num_pedido
group by p.num_pedido, c.nome_cliente
having valor_total is not null
order by p.num_pedido;

/* 04: Recupere o nome do produto e a a quantidade total de vendas realizadas de cada produto.
Para os produtos que venderam mais de 100 unidades. (7 linhas retornadas) */
select p.descricao, sum(ip.quantidade) as qtd_vendas
from produto as p
left join item_pedido as ip
on p.cod_produto = ip.cod_produto
group by p.descricao
having qtd_vendas > 100;

/* 05: Recupere todas as informaçoes do(s) produto(s) com maior valor unitario.
(1 linha retornada) */
select *
from produto 
where valor_unitario = (select max(valor_unitario) from produto);