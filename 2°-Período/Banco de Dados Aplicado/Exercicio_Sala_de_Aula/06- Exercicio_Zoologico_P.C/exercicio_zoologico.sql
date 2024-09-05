-- QUESTÃO 01: Liste o nome do animal e de seus cuidadores (60 linhas retornadas).
select a.nome as nome_animal, e.nome as nome_cuidador
from animais a, empregados e
where idcuidador = idempregado;

-- QUESTÃO 02: Liste os nomes de todos os clientes que também são provedores(4 linhas retornadas).
select c.nome
from clientes c, provedores p
where p.idcliente = c.idcliente;

-- QUESTÃO 03: Liste o nome e data de saída dos animais que saíram do zoológico por falecimento(2 linhas retornadas).
select nome, datasaida
from animais a, eventoanimais ea
where descricao='falecimento' and a.idanimal = ea.idanimal;

-- QUESTÃO 04: Liste os nomes dos animais, a data de nascimento, o nome do seu cuidador e a descrição da medicação que tomou. (60 linhas retornadas).
SELECT 
    a.nome AS nome_animais,
    datanascimento,
    e.nome AS nome_empregado,
    descricao
FROM
    animais a,
    empregados e,
    medicacao m
WHERE
    a.idcuidador = e.idempregado
        AND a.idmedicacao = m.idmedicacao;

-- QUESTÃO 05: Recupere os dados de todos os animais carnívoros que ainda estão no zoológico (17 linhas retornadas).
SELECT 
    a.*
FROM
    animais a,
    especies e,
    alimentacao al
WHERE
    al.nome = 'Carnívoros'
        AND datasaida IS NULL
        AND a.idespecie = e.idespecie
        AND e.idalimentacao = al.idalimentacao;

-- QUESTÃO 06: Liste o nome e a espécie dos animais que fizeram translado (2 linhas retornadas).
SELECT 
    a.nome, nomecomum
FROM
    animais a,
    especies e,
    eventoanimais ea,
    tipoeventos te
WHERE
    te.descricao = 'translado'
        AND a.idespecie = e.idespecie
        AND a.idanimal = ea.idanimal
        AND idtipo = tipoevento;

-- QUESTÃO 07: Recupere o nome e estoque do produto fornecido pelas ongs, assim como o nome dos clientes que fazem parte dessas ongs (2 linhas retornadas).
SELECT 
    p.nome, estoque, c.nome
FROM
    produtos p,
    provedores pr,
    clientes c,
    sociedades s
WHERE
    s.descricao = 'ong'
        AND p.idprovedor = pr.idprovedor
        AND pr.idCliente = c.idCliente
        AND s.idTipoSociedade = c.tipoSociedade;
