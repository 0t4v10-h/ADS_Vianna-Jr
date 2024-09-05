USE `empresa`;

/* Crie e exiba uma visão que recupere o nome e sobrenome dos funcionarios
e a quantidade total de horas que eles trabalham. Tragam apenas os 
funcionarios que trabalham mais de 35 horas. */
create view total_horas as
select pnome, unome, sum(horas) as total_horas
from funcionario inner join trabalha_em on cpf = fcpf
group by cpf
having sum(horas) > 35;
select * from total_horas;

/* Crie e exiba uma visão que recupere o nome dos funcionarios
e o nome dos projetos que eles trabalham.  */
create view funcionario_projeto as
select pnome, projnome
from funcionario
inner join trabalha_em on cpf = fcpf
inner join projeto on pnr = projnumero;
select * from funcionario_projeto;

/* Crie e exiba uma visão que recupere o nome de todos os funcionarios
juntamente com a quantidade de dependentes que eles possuem.
Caso ele não tenha nenhum dependente, exiba 0 na contagem. */
create view dependente_funcionario as
select pnome, count(fcpf) as num_dependentes
from funcionario
left join dependente on cpf = fcpf
group by cpf
order by pnome;
select * from dependente_funcionario;

/* Traga o maior numero de dependentes que os funcionarios possuem. */
select max(num_dependentes)
from dependente_funcionario;

/* Traga o nome dos funcionarios com o maior numero de dependentes. */
select *
from dependente_funcionario
having num_dependentes = (select max(num_dependentes)
from dependente_funcionario);