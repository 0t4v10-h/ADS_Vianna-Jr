use empresa;

-- Relação Funcionario
-- a) Selecione os funcionários em que o cpf do supervisor possui o valor nulo;
select * from funcionario where cpf_supervisor is null;

-- b) Selecione os funcionários que não são do sexo feminino;
select * from funcionario where sexo = "M";

-- c) Selecione os funcionários em que o cpf do supervisor não é nulo ou ganham mais que 35000;
select * from funcionario where cpf_supervisor is not null or salario > 35000;

-- d) Selecione os funcionários homens em que a data de nascimento é maior que 01/01/1962.
select * from funcionario where sexo = 'M' and datanasc > '1962-01-01';

-- e) Selecione os funcionários que têm o sobrenome ‘Silva’ ou que o nome seja ‘Jorge’.
select * from funcionario where unome = 'Silva' or pnome = 'Jorge';

-- f) Selecione os funcionários que não pertencem a nenhum departamento.
select * from funcionario where dnr is null;

-- Relação Departamento 
-- a) Selecione os departamentos que possuem gerente.
select * from departamento where cpf_gerente is not null;

-- b) Selecione o departamento de nome Matriz;
select * from departamento where dnome = 'Matriz';

-- c) Selecione o departamento que não possui data inicio gerente cadastrada.
select * from departamento where data_inicio_gerente is not null;

-- Relação Dependente
-- a) Selecione as dependentes que são esposas;
select * from dependente where parentesco = 'Esposa';

-- b) Selecione as dependentes que são esposas e filhas;
select * from dependente where parentesco = 'Esposa' or parentesco = 'Filha';

-- c) Selecione os dependentes em que o cpf do funcionário é 12345678966;
select * from dependente where fcpf = 12345678966;

-- d) Selecione os dependentes que são homens ou filhos.
select 8 from dependente where sexo ='M' or parentesco = 'Filho';

-- Relação Projeto
-- a) Selecione os projetos localizados em São Paulo;
select * from projeto where projlocal = 'São Paulo';

-- b) Selecione os projetos localizados em São Paulo e que o departamento seja 
-- 5 ou os projetos localizados em São Paulo e que o departamento seja 1.
select * from projeto where projlocal = 'São Paulo' and dnum = 5 or projlocal = 'São Paulo' and dnum = 1;

-- Relação Localizacao_dep
-- a) Selecione os departamentos localizados em São Paulo;
select * from localizacao_dep where dlocal = 'São paulo';

-- b) Selecione os departamentos localizados em São Paulo e que possuem número 5 ou número 1.
select * from localizacao_dep where dlocal = 'São paulo' and dnumero = 5 or dnumero = 1;

-- Relação Trabalha_em
-- a) Selecione os empregados que trabalham mais de 20 horas;
select * from trabalha_em where horas > 20;

-- b) Selecione os empregados que trabalham mais de 10 horas ou trabalham no projeto 3.
select * from trabalha_em where horas > 10 or pnr = 3;

-- c) Selecione os empregados em que o cpf é igual a 98765432168 e que trabalham no projeto 30.
select * from trabalha_em where fcpf = 98765432168  and pnr = 30;







