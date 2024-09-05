-- Recupere o número e classe dos assentos disponíveis.
select numeroassento, classe from assento where status='disponível';

-- Recupere o fabricante e ano de fabricação das aeronaves com capacidade de mais de 200 passageiros.
select fabricante, anofabricacao from aeronave where capacidade>200;

-- Recupere o número do voo e o horário de saída dos voos em que a cidade de destino é 4567.
select numerovoo, horariosaida from voo where cidadedestino=4567;

-- Recupere o preço das reservas para o voo de código 1100.
select preco from reserva where codigovoo=1100;

-- Recupere o código do cliente que reservou um voo no dia 10/11/2014.
select codigocliente from reserva where datareserva='2014-11-10';

-- Recupere o código da cidade Belo Horizonte.
select codigocidade from cidade where nomecidade='Belo Horizonte';

-- Recupere o código e o prefixo das aeronaves fabricadas após 2013.
select codigoaeronave, prefixo from aeronave where anofabricacao>'2013';

-- Recupere os números dos assentos reservados que custaram mais de 1000 reais.
select numeroassento from reserva where preco>1000;

-- Recupere os números dos voos que saem após as 22:00.
select numerovoo from voo where horariosaida>'22:00';
  
-- Recupere o endereço e telefone da cliente Joice Leite.
select endereco, telefone from cliente where nomecliente='Joice Leite';