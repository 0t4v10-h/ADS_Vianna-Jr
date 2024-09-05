/* Recupere os funcionários que trabalham no departamento 4.*/
select *
from funcionario
where dnr=4;

/* Recupere os funcionários que ganham salário maior de 30000. */
select *
from funcionario
where salario > 3000;

/* Recupere os funcionários do sexo masculino que possuem sobrenome Brito. */
select * 
from funcionario
where sexo = 'M' and unome = 'Brito';

/* Recupere os funcionários que não possuem supervisor. */
select*
from funcionario
where cpf_supervisor is null;

/* Recupere os funcionários que possuem supervisor. */
select*
from funcionario
where cpf_supervisor is not null;