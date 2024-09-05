use empresa;
-- Recuperar o nome do departamento e do gerente do departamento.
SELECT 
    dnome, pnome, unome
FROM
    departamento
        INNER JOIN
    funcionario ON cpf = cpf_gerente;

-- Recuperar o nome do funcionário juntamente com o nome do projeto em que eles trabalham.
select pnome, unome, projnome
from projeto p inner join trabalha_em te on p.projnumero = te.pnr
inner join funcionario f on f.cpf = te.fcpf;

-- Recuperar o nome dos empregado juntamente com o nome dos dependentes que eles possuem.
select pnome, unome, nome_dependente
from funcionario inner join dependente on cpf = fcpf;

-- Recuperar o nome dos funcionários e o nome dos departamentos que eles trabalham
SELECT pnome, unome, dnome
FROM funcionario INNER JOIN departamento ON dnr = dnumero;

-- Recuperar o nome do funcionario, o nome dos projeto para os funcionários que trabalham mais de 20 horas em determinado projeto.
select pnome, unome, projnome
from funcionario inner join trabalha_em on cpf = fcpf inner join projeto on pnr = projnumero
where horas>20;

-- Recupere o nome dos dependentes de cada funcionária.
select nome_dependente
from funcionario f inner join dependente d on f.cpf = d.fcpf
where f.sexo='F';

-- Recupere o nome do departamento de sua localização
select dnome, dlocal
from departamento natural join localizacao_dep;

-- Recupere todas as combinações possíveis entre o nome dos funcionarios e o nome dos departamentos que eles estão relacionados
select pnome, unome, dnome
from funcionario inner join departamento;