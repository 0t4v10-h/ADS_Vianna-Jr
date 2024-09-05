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





