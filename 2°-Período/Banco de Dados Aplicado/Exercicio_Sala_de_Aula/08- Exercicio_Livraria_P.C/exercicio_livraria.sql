-- Questão 1: Recupere o nome e o ano de nascimento dos autores que ainda estão vivos.(10 linhas retornadas)
select nomeautor, anonascimento
from autor
where anofalecimento is null;

-- Questão 2: Recupere todos os dados das editoras situadas no Rio de Janeiro e que foram fundadas a mais de 30 anos.(1 linha retornada)
select *
from editora
where cidade='Rio de Janeiro' and anofundacao<year(curdate())-30;
-- Função curdate() extrai a data atual de acordo com o OS
-- Função now() extrai a data e hora atuais de acordo com o OS
-- Função year() extrai o ano de uma data
-- Função month() extrai o mês de uma data
-- Função day() extrai o dia de uma data

-- Questão 3: Recupere todos os dados das editoras que publicaram livros que possuem o nome Sistema de Banco de Dados.(2 linhas retornadas)
select e.*
from editora e, livro l
where nomelivro='Sistema de Banco de Dados' and 
e.nomeeditora = l.nomeeditora;

-- Questão 4: Recupere o nome dos autores e o nome do livro que eles publicaram.(10 linhas retornadas)
select nomeautor, nomelivro
from autor a, autoria aut, livro l
where a.numautor = aut.numautor and aut.numlivro = l.numlivro;

-- Questão 5: O nome do cliente e o nome do livro que ele comprou.(19 linhas retornadas)
select nomecli, nomelivro
from livro l, cliente c, vendas v
where c.numcli = v.numcli and v.numlivro = l.numlivro;

