use empresa;

-- Recupere o nome, o sobrenome e o salário de cada funcionário.
select pnome, unome, salario from funcionario;

-- Recupere o sexo e o salario de cada funcionario.
select distinct sexo, salario from funcionario;

-- Recupere o nome, o sobrenome e o salario dos funcionarios que trabalham no departamento 5.
select distinct pnome, unome, salario from funcionario where dnr = 5;

-- Recupere o número de horas trabalhadas pelo funcionário 98765432168 no projeto de número 30.
select distinct horas from trabalha_em where fcpf = '98765432168' and pnr = 30;

-- Recupere o número de horas trabalhadas de cada funcionário.
select distinct horas from trabalha_em;

-- Recupere o nome e sobrenome das funcionárias que trabalham na empresa.
select distinct pnome, unome from funcionario where sexo = 'F';