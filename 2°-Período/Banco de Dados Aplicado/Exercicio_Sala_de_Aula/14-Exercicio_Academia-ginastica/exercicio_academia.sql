USE `academia_ginastica`;

-- 1- Recupere o nome dos alunos que treinam com o instrutor Kai
select a.nome 
from aluno as a
inner join matricula as m 
on a.numMatricula = m.aluno_matricula
inner join turma as t
on m.turma_idturma = t.idturma
inner join  instrutor as i
on t.instrutor_idinstrutor = i.idinstrutor
where i.nome = 'Kai';

-- Recupere o nome, sobrenome dos alunos que praticam Yoga.
select a.nome, a.sobrenome
from aluno as a
inner join matricula as m
on a.numMatricula = m.aluno_matricula
inner join turma as t
on m.turma_idturma = t.idturma
inner join atividade as ati
on t.atividade_idatividade = ati.idatividade
where ati.nome like "%yoga";

-- Recupere o nome dos alunos, o nome das atividades que eles praticam e o nome do seu instrutor.
select a.nome, ati.nome, i.nome
from aluno as a
inner join matricula as m
on a.numMatricula = m.aluno_matricula
inner join turma as t
on m.turma_idturma = t.idturma
inner join atividade as ati
on t.atividade_idatividade = ati.idatividade
inner join instrutor as i
on t.instrutor_idinstrutor = i.idinstrutor;

-- Recupere o nome do aluno, sua data de matrícula e o nome do seu instrutor.
select a.nome, m.datamatricula, i.nome
from aluno as a
inner join matricula as m
on a.numMatricula = m.aluno_matricula
inner join turma as t
on m.turma_idturma = t.idturma
inner join instrutor as i
on t.instrutor_idinstrutor = i.idinstrutor;

-- 2- Recupere o nome de todos os instrutores, caso eles deem aula para alguma turma, 
-- mostre também o id da turma e o horário. Ordene pelo horário de maneira ascendente.
select i.nome, t.idturma, t.horario
from instrutor as i
left join turma as t 
on i.idinstrutor = t.instrutor_idinstrutor
order by t.horario asc;

-- Recupere o nome de todas as atividades, caso elas estejam associadas a alguma turma, traga também o código da turma.
select a.nome, t.idturma
from atividade as a
left join turma as t
on a.idatividade = t.atividade_idatividade;

-- Recupere o nome de todos os alunos, caso eles estejam matriculados, traga também a data da matrícula.
select a.nome, m.datamatricula
from aluno as a
left join matricula as m
on a.numMatricula = m.aluno_matricula;

-- 3- Recupere o nome dos alunos que não praticam nenhuma atividade.
select nome
from aluno
where numMatricula not in(select aluno_matricula from matricula
where turma_idturma not in(select idturma from turma
where atividade_idatividade not in (select idatividade from atividade)));
/* ou */
select nome
from aluno
where numMatricula not in
(select aluno_matricula from matricula
inner join turma on turma_idturma = idturma
inner join atividade on idatividade = atividade_idatividade);

-- Recupere o nome dos instrutores que não estão vinculados a nenhuma turma.
select i.nome 
from instrutor as i
where idinstrutor not in (select instrutor_idinstrutor from  turma);

-- Recupere o nome das atividades que não possuem alunos.
select nome
from atividade
where idatividade not in(select atividade_idatividade from turma where idturma not in
(select turma_idturma from matricula where aluno_matricula not in(select nummatricula from aluno)));
