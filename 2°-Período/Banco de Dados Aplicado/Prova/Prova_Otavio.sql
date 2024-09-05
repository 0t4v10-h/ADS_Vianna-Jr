USE `hospital`;

-- Recupere os nomes dos pacientes que foram hospitalizados no HOSPITAL MONTE SINAI.
select p.nome
from paciente as p
inner join diagnostico as d
on p.cpf = d.cpf
inner join medico as m
on d.crm = m.crm
inner join medico_hospital as mh
on m.crm = mh.crm
inner join hospital as h
on mh.cnpj = h.cnpj
where h.nome = 'HOSPITAL MONTE SINAI';

-- Recupere o nome de todos os medicos, caso eles tenham alguma especialidade traga a sua especialidade. Ordene pelo nome do medico de maneira ascendente
select m.nome, e.especialidade
from medico as m
left join medico_especialidade as me
on m.crm = me.crm
left join especialidade as e
on me.rqe = e.rqe order by m.nome asc;

-- Recupere o nome dos pacientes que ja foram diagnosticado
select p.nome
from paciente as p
where cpf in (select cpf from diagnostico);