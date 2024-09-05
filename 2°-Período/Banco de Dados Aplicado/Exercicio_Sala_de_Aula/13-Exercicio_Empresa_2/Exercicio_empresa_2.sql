USE empresa_02;

-- 1- Recupere o parentesco dos dependentes. Elimine as linhas duplicadas. 
select distinct parentesco
from dependente;

-- 2- Recupere o nível de graduação dos cargos. Elimine as linhas duplicadas.
select distinct nivel_graduacao
from cargo;

-- 3- Recupere os nomes e o sexo de todos os empregados lotados no departamento 306 cujos nomes contêm a letra “a” ordenados alfabeticamente.
select nome, sexo 
from empregado
where codigo_dep = 306 and nome like '%a%' order by nome;

-- 4- Recupere a data de nascimento e o nome de todos os empregados do sexo feminino ordenados por data de nascimento descendentemente.
select data_nasc, nome 
from empregado 
where sexo = 'F' order by data_nasc desc;

-- 5- Recupere o nome dos empregados não que tem dependente. Use NOT IN.
select nome 
from empregado 
where codigo_empregado 
not in (select codigo_empregado from dependente);

-- Fazendo com junção externa
select nome
from empregado as e 
left join dependente as d
on e.codigo_empregado = d.codigo_empregado
where d.codigo_empregado is null;

-- 6- Recupere todas as informações do(s) empregado(s) que não trabalham no Rio de Janeiro. Use NOT IN.
select e.* from empregado as e
inner join departamento as d
on e.codigo_dep = d.codigo_dep
where uf not in ('RJ');

-- 7- Recupere o nome dos cargos que estão ocupados por algum empregado. Use IN.
select nome_cargo
from cargo 
where codigo_cargo 
in (select codigo_cargo from empregado where codigo_cargo is not null);