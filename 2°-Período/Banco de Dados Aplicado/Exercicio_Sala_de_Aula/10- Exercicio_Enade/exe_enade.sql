use enade;

-- QUESTÃO 01: Recupere o nome de todas as áreas.
select nomeArea from area;

-- QUESTÃO 02: Recupere o nome dos municípios do estado de MG.
select nomeMunicipio from municipio where siglaUF = "MG";

-- QUESTÃO 03: Liste os nomes das instituições privadas com fins lucrativos.(675 linhas retornadas).
select i.nomeIES 
from ies as i 
inner join categoria as c on i.codCategoria = c.codCategoria 
where c.nomeCategoria = "Privada com fins lucrativos";