-- QUESTÃO 01: Recupere os tipos de serviços e valor, para os serviços que custam mais de R$50,00.(6 linhas retornadas)
select tipo, valor
from tipo_servico
where valor>50;

-- QUESTÃO 02: Recupere o nome do animal juntamente com sua raça.(1008 linhas retornadas)
SELECT 
    a.nome nome_animal, r.nome nome_raca
FROM
    animal a,
    raca r
WHERE
    a.raca = r.id;

-- QUESTÃO 03: Recupere todas as informações dos animais que possuem alto nível de cuidados.(375 linhas retornadas)
select a.*
from animal a, raca r
where nivel_cuidados='Alto' and a.raca = r.id;

-- QUESTÃO 04: Recupere o nome do cliente e o tipo de serviço que ele solicitou. Traga apenas os serviços que ainda não foram pagos.(469 linhas retornadas)
SELECT 
    c.nome, tipo
FROM
    cliente c,
    animal a,
    tipo_servico ts,
    servico s
WHERE
    pago = 0 AND c.id = a.cliente
        AND a.id = s.animal
        AND ts.id = s.tipo_servico;

-- QUESTÃO 05: Recupere as informações das clientes, o nome e a raça dos animais e o tipo de serviço que foi realizado. Elimine os valores repetidos. (948 linhas retornadas)
SELECT DISTINCT
    c.*, a.nome, r.nome, tipo
FROM
    cliente c,
    animal a,
    raca r,
    servico s,
    tipo_servico ts
WHERE
    c.id = a.cliente AND a.raca = r.id
        AND a.id = s.animal
        AND ts.id = s.tipo_servico;
