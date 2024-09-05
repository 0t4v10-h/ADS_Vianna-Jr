use empresa;

/* Traga todas as informações dos funcionários que residem em São Paulo, SP */
select *
from funcionario
where endereco like '%São Paulo, SP%';

/* Traga todas as informações dos funcionários cujo primeiro nome tenha apenas 4 letras */
select *
from funcionario
where pnome like '____';

/* Recupere o nome e o número do departamento dos funcionários que trabalham nos departamentos 5, 4 ou 1 */
/* 1ª forma */
select pnome, unome, dnr
from funcionario
where dnr = 5 or dnr=4 or dnr=1;
/* 2ª forma */
select pnome, unome, dnr
from funcionario
where dnr in (5,4,1);

/* Recupere as informações dos funcionários que não possuem dependente. */
select *
from funcionario
where cpf not in(select fcpf from dependente);

/* Recupere o nome e sobrenome dos funcionários que trabalham nos departamentos pesquisa, matriz ou administração */
/* 1ª forma */
select pnome, unome
from funcionario inner join departamento on dnr = dnumero
where dnome='Pesquisa' or dnome='matriz' or dnome='Administração';
/* 2ª forma */
select pnome, unome
from funcionario inner join departamento on dnr = dnumero
where dnome in ('Pesquisa','matriz','Administração');
/* 3ª forma */
select pnome, unome
from funcionario
where dnr in (select dnumero from departamento where dnome in ('Pesquisa','matriz','Administração'));

/* Recupere o nome e sobrenome dos funcionários que não estão associados a projetos. Ordene alfabeticamente pelo nome do funcionário */
select pnome, unome
from funcionario
where cpf not in(select fcpf from trabalha_em)
order by pnome asc;

/* Recupere o nome, sobrenome e salario dos funcionários. Ordene do maior para o menor salário */
select pnome, unome, salario
from funcionario
order by salario desc;
