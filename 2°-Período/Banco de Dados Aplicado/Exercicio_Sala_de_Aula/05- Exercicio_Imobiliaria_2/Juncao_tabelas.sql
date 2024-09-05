use imobiliaria;

-- Recupere a descrição do imóvel do tipo apartamento.
SELECT 
    descricao
FROM
    imovel i,
    tipo_imovel ti
WHERE
    ti.codigo_tipo = i.codigo_tipo
        AND tipo = 'apartamento';

-- Recupere o nome do cliente juntamente com o valor do imóvel que ele comprou.
SELECT 
    nome_cliente, valor
FROM
    cliente,
    venda
WHERE
    cliente.codigo_cliente = venda.codigo_cliente;

-- Recupere o nome do proprietário juntamente com a descrição do(s) seu(s) imóvel(eis).
SELECT 
    nome_proprietario, descricao
FROM
    proprietario p,
    imovel i,
    imovel_proprietario ip
WHERE
    p.codigo_proprietario = ip.codigo_proprietario
        AND i.codigo_imovel = ip.codigo_imovel;

-- Recupere o valor de venda do(s) imóvel(eis) juntamente com o nome do(s) proprietário(s) que tenham vendido imóveis situados no centro.
SELECT 
    nome_proprietario, valor
FROM
    proprietario AS p,
    imovel_proprietario AS ip,
    imovel AS i,
    venda AS v
WHERE
    bairro = 'Centro'
        AND p.codigo_proprietario = ip.codigo_proprietario
        AND ip.codigo_imovel = i.codigo_imovel
        AND v.codigo_imovel = i.codigo_imovel;
