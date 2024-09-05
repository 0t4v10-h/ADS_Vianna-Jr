/*Banco de Dados loja_virtual*/
/*QUESTÃO 01: Recupere todas as informações dos clientes que 
não efetuaram nenhuma compra.
Utilize junção externa ou not in.(8 linhas retornadas)*/
/*NOT IN*/
select *
from cliente
where clienteid not in(select clienteid from compra);

/*Junção externa*/
select c.*
from cliente c left join compra co on c.clienteid = co.clienteid
where co.clienteid is null;

/*QUESTÃO 02: Traga todas as informações dos produtos 
em que o preço de venda é pelo menos 60% a mais que o 
preço de custo. Ordene do maior para o menor preço de venda. 
(4 linhas retornadas)*/
select *
from produto
where precovenda > precocusto+0.6*(precocusto);



/*Banco de Dados Loja*/
/*QUESTÃO 01: Recupere todas as informações dos vendedores 
que não efetuaram nenhuma venda. 
Utilize junção externa ou not in.(8 linhas retornadas)*/
/*NOT IN*/
select *
from vendedor
where cod_vendedor not in(select cod_vendedor from pedido);

/*Junção externa*/
select v.*
from pedido p right join vendedor v on v.cod_vendedor = p.cod_vendedor
where p.cod_vendedor is null;

/*QUESTÃO 02: Traga todas as informações dos clientes, 
juntamente com a quantidade de pedidos que eles efetuaram. 
(14 linhas retornadas)*/
select c.*, count(*)
from cliente c inner join pedido p on c.cod_cliente = p.cod_cliente
group by c.cod_cliente;