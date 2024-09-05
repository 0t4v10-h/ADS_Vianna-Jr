use imobiliaria;

-- Selecione o nome e cidade dos clientes que não possuem telefone cadastrado.
select distinct nome_cliente, cidade from cliente where telefone is null;

-- Selecione nome, cpf e rg dos clientes que moram no centro.
select distinct nome_cliente, cpf, rg from cliente where bairro = "centro";

-- Selecione o nome e a rua dos clientes que moram em São Paulo ou que tenham nascido após 01/01/1990(1990-01-01).
select distinct nome_cliente, rua from cliente where cidade = "São Paulo" or datanasc > '1990-01-01';

-- Selecione o código dos clientes que possuem telefone cadastrado e que não tem data de nascimento cadastrada.
select distinct codigo_cliente from cliente where telefone is not null and datanasc is null;

-- Selecione os códigos dos imóveis que possuem tipo cadastrado.
select distinct codigo_imovel from imovel where codigo_tipo is not null;

-- Selecione o código e a descrição dos imóveis localizados no centro de Juiz de Fora.
select distinct codigo_imovel, descricao from imovel where cidade = 'Juiz de Fora' and bairro = 'centro';

-- Selecione o código e a descrição dos imóveis situados no Rio de Janeiro ou Petrópolis.
select distinct codigo_imovel, descricao from imovel where cidade = 'Rio de Janeiro' or 'Petropolis';

-- Selecione o nome e cpf do(s) proprietário(s) de nome João e sobrenome da Silva.
select distinct nome_proprietario, cpf from proprietario where nome_proprietario = 'Joao' and sobrenome = 'Silva';

-- Selecione as informações cujo tipo de imóvel é apartamento.
select distinct rua, bairro, cidade, cep, descricao from imovel where codigo_tipo = 1;

-- Selecione todas as informações da tabela venda cujos valores dos imóveis sejam de R$150.000,00.
select distinct * from venda where valor = 150000.00; 

-- Selecione todas as informações da tabela venda, cujos imóveis estejam com o valor entre R$100.000,00 e R$200.000,00.
select distinct * from venda where valor > 100000.00 and valor < 200000.00;

-- Selecione  todas as informações da tabela locação para os imóveis que estão sendo alugados por mais de R$2000,00.
select distinct * from locacao where valor > 2000.00; 

-- Selecione  todas as informações da tabela locação para os imóveis que estão sendo alugados por R$900,00.
select distinct * from locacao where valor = 900.00;
