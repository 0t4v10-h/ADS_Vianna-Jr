USE `academia_ginastica`;
/* QUESTÃO 01: Crie e exiba uma visão que recupere os nomes e sobrenome dos instrutores e o 
código das turmas que eles ministram. Ordene pelo nome do instrutor.(1008 linhas retornadas)  */
create view nome_id_instrutor as
select i.nome, i.sobrenome, t.idturma
from instrutor as i
inner join turma as t 
on i.idinstrutor = t.instrutor_idinstrutor
order by i.nome asc;
select * from nome_id_instrutor;

/* QUESTÃO 02: Crie e exiba uma visão que recupere os dados dos instrutores 
que dão aula para mais de 2 turmas. (47 linhas retornadas) */
create view numero_turma as
select i.*, count(t.idturma) as n_turma 
from instrutor as i
left join turma as t 
on i.idinstrutor = t.instrutor_idinstrutor
group by i.idinstrutor
having n_turma > 2;
select * from numero_turma;

/* QUESTÃO 03: Crie e exiba uma visão que recupere os nomes das atividades com a quantidade 
de turmas que a praticam. Ordene pelo nome da atividade. (40 linhas retornadas) */
create view nome_atividade as
select a.nome, count(t.idturma) as n_turma
from atividade as a
left join turma as t 
on a.idatividade = t.atividade_idatividade
group by a.idatividade
order by a.nome asc;
select * from nome_atividade;

/* QUESTÃO 04: Crie e exiba uma visão que recupere os dados 
dos alunos não matriculados. (14247 linhas retornadas) */
create view alunos_naoMatriculados as
select a.*
from aluno as a
left join matricula as m 
on a.numMatricula = m.aluno_matricula
where m.aluno_matricula is null;
select * from alunos_naoMatriculados;

/* QUESTÃO 05: Crie e exiba uma visão que recupere os dados dos alunos e os códigos 
das turmas que eles participam. Ordene pelo nome do aluno. (2656 linhas retornadas) */
create view aluno_turma as
select a.*, t.idturma
from aluno as a
left join matricula as m 
on a.numMatricula = m.aluno_matricula
left join turma as t 
on m.turma_idturma = t.idturma 
where t.idturma is not null
order by a.nome asc;
select * from aluno_turma;

/* QUESTÃO 06: Crie e exiba uma visão que recupere os dados 
dos alunos que praticam Pilates. (81 linhas retornadas) */
create view alunos_pilates as
select a.*
from aluno as a
left join matricula as m 
on a.numMatricula = m.aluno_matricula
left join turma as t 
on m.turma_idturma = t.idturma
left join atividade as at
on t.atividade_idatividade = at.idatividade
where at.nome = 'Pilates';
select * from alunos_pilates;

/* QUESTÃO 07: Crie e exiba uma visão que recupere a quantidade 
de atividades que cada aluno pratica. (16730 linhas retornadas) */
select a.nome, count(at.nome)
from aluno as a
left join matricula as m
on a.numMatricula = m.aluno_matricula
left join turma as t
on m.turma_idturma = t.idturma
left join atividade as at
on t.atividade_idatividade = at.idatividade
group by a.nome;

/* QUESTÃO 08: Crie e exiba uma visão que recupere a altura 
média dos alunos que praticam vôlei. (1 linha retornada) */
create view media_volei as
select (sum(a.altura) / count(a.nome)) as media
from aluno as a
left join matricula as m 
on a.numMatricula = m.aluno_matricula
left join turma as t 
on m.turma_idturma = t.idturma
left join atividade as at
on t.atividade_idatividade = at.idatividade
where at.nome = 'Vôlei';
select media from media_volei;