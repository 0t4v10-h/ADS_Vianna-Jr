USE `empresa`;

/* Achar a soma dos salarios, o salario maximo, o salario minimo e a media salarial de todos os funcionarios */
select sum(salario) as soma_salarial, max(salario) as valor_maximo, 
min(salario) as valor_minimo, round(avg(salario),2) as media_salarial  /* round: Arredonda o numero de acordo com o numero de casas que voce desejar */
from funcionario;

/* Achar a media dos salarios de acordo com o departamento do funcionario. Sendo a media de pelo menos 31000 */
select dnr, avg(salario) as media_salarial
from funcionario
group by dnr
having avg(salario) >= 31000;       /* Having mesma coisa que a clausula where. Usada sempre que tiver sum, max, min ou avg */

/* Recupere as informaçoes do funcionario que possui o menor salario */
select *
from funcionario
where salario = (select min(salario) from funcionario);

/* Recupere as informaçoes do funcionario que possui o maior salario */
select *
from funcionario
where salario = (select max(salario) from funcionario);

/* Recupere as informaçoes do funcionario mais velho */
select *
from funcionario
where datanasc = (select min(datanasc) from funcionario);

/* Recupere as informaçoes do funcionario mais novo */
select *
from funcionario
where datanasc = (select max(datanasc) from funcionario);

/* Recupere a quantidade de funcionarios que existem na empresa */
select count(*) as qtd_funcionarios
from funcionario;

/* Recupere a quantidade de salarios. Elimine valores repetidos */
select count(distinct salario) as qtd_salarios
from funcionario;

/* Traga os nomes e sobrenome dos funcionarios, juntamente com suas idades */
select pnome, unome, timestampdiff(year, datanasc, curdate()) as idade
from funcionario;
/* Traga a media de idade dos funcionarios */
select round(avg(idade),2) as media_idade
from(select pnome, unome,  
timestampdiff(year, datanasc, curdate()) as idade
from funcionario) as tabela_virtual;

/* Traga o nome do departamento e a quantidade de funcionarios que ele possui, caso o 
departamento nao tenha nenhum funcionario associado, exiba 0 na contagem */
select dnome, count(cpf)
from departamento left join funcionario on dnr = dnumero
group by dnumero;

/* Recupere o nome e sobrenome dos funcionarios e a quantidade de dependentes que 
eles possui, caso o funcionario nao tenha nenhum dependente, exiba 0 na contagem */
select pnome, unome, count(fcpf)
from funcionario
left join dependente on cpf = fcpf
group by cpf;
