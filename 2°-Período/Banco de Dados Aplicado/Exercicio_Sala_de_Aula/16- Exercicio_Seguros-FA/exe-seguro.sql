USE `seguros`;

/* 1- Recupere as dados dos carros que nao participaram de nenhum acidente */
select c.*
from carro as c
left join participou as p on c.placa = p.placa
where p.numero_ocorrencia is null;

/* 2- Recupere os dados do(s) carro(s) que tevem(tiveram) o maior valor de dano, juntamente com o valor do dano */
select c.*, p.valor_dano
from carro as c
inner join participou as p 
on c.placa = p.placa
where p.valor_dano = (select max(valor_dano) from participou);

/* 3- Recupere os dados do(s) carro(s) que tevem(tiveram) o menor valor de dano, juntamente com o valor do dano */
select c.*, p.valor_dano
from carro as c
inner join participou as p 
on c.placa = p.placa
where p.valor_dano = (select min(valor_dano) from participou);

/* 4- Recupere as informaçoes do(s) carro(s) que participou(aram) do maior numero de ocorrencias */
select c.*, count(*) as total_ocorrencia
from carro as c
inner join participou as p on c.placa = p.placa
group by c.placa 
having count(*) = (select max(total_ocorrencias)
from (select count(*) as total_ocorrencias
from carro as c 
inner join participou as p on c.placa = p.placa
group by c.placa) as tmp);

/* 5- Recupere a soma, a media, o valor minimo e o valor maximo do valor do dano ocasionado por cada veiculo */
select p.placa, sum(p.valor_dano) as valor_dano, round(avg(p.valor_dano),2) as media_dano,
min(p.valor_dano) as minimo_dano, max(p.valor_dano) as maximo_dano
from participou as p
group by p.placa;

/* 6- Recupere todas as informaçoes do acidente mais antigo */
select a.*
from acidente as a
where a.data = (select min(data) from acidente);

/* 7- Recupere os dados do carro mais antigo que se envolveu em algum acidente */
select distinct c.*
from carro as c
inner join participou as p
on c.placa = p.placa
where c.ano = (select min(ano) from carro as c
inner join participou as p on c.placa = p.placa);