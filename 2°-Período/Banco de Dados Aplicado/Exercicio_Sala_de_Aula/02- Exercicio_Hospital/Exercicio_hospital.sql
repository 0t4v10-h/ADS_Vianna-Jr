use hospital;

-- Tabela paciente
-- Recupere as informações de todos os pacientes que não moram no centro.
select * from paciente where bairro != "centro";

-- Tabela doenca
-- Recupere as informações das doenças que não possuem descrição.

select * from doenca where descricao is null;

-- Tabela hospital
-- Recupere as informações dos hospitais situados no bairro São Mateus da cidade de Juiz de Fora.
select * from hospital where cidade = "Juiz de Fora" and bairro = "São Mateus";

-- Tabela medico
-- Recupere as informações dos médicos que moram na Av. Barão do Rio Branco.
select * from medico where rua = "Av. Barão do Rio Branco";

-- Tabela paciente
-- Recupere as informações dos pacientes que nasceram após 01/01/1990.
select * from paciente where datanasc > "1990-01-01";

-- Tabela especialidade
-- Recupere as informações da especialidade de nome Dermatologia.
select * from especialidade where especialidade = "Dermatologia";

-- Tabela diagnostico
-- Recupere as informações do diagnóstico do paciente 12345678901.
select * from diagnostico where cpf = 12345678901;

-- Tabela medico_hospital
-- Recupere as informações da tabela médico_hospital, cuja data de início do médico está entre 01/01/2000 até 08/02/2003.
select * from medico_hospital where dataInicio >= "2000-01-01" and dataInicio <= "2003-02-08";
