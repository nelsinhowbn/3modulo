use master
go

drop database NelsonAtividade
go

create database NelsonAtividade
go

use NelsonAtividade
go

create table tarefa (
id int primary key identity (1,1),
titulo varchar(100) not null,
prazo_estimado date,
descricao varchar(250),
data_inicio date not null,
data_termino date
)

create table pessoas (
id int primary key identity (1,1),
nome varchar(100),
email varchar(100),
sexo varchar(20)
)

create table rel_tarefa_pessoa (
id int primary key identity (1,1),
id_tarefa int,
id_pessoas int,

foreign key (id_pessoas) references pessoas (id),
foreign key (id_tarefa) references tarefa (id)
)

create table metodologia (
id int primary key identity (1,1),
titulo varchar(100),

foreign key (id) references tarefa (id)
)
go

insert into pessoas (nome, email, sexo)
values 
('Nelson','nelsonhadi95@gmail.com','masculino'),
('João','joaozinho@gmail.com','masculino'),
('Antonia','antonia@gmail.com','feminino'),

-- As Tarefas atrasadas que estão atrasadas.
('Italo','italoeustacio@gmail.com','masculino'), 

-- Os que não fazem parte de nenhuma tarefa.
('Vinicius','vinicius@gmail.com','masculino'),
('Caio','caio@gmail.com','masculino')


insert into tarefa
values 
('Lição 1','2018-02-08','Materia de tarefa 1','2018-11-08','2018-07-08'),
('Lição 2','2018-05-08','Materia de tarefa 2','2018-11-08','2018-07-08'),

-- Tarefas atrasadas.
('Lição 3','2018-07-08','Materia de  tarefa 3','2018-10-08','2018-05-07'),
('Lição 4','2018-07-08','Materia de  tarefa 4','2018-09-04','2018-06-07')

insert into rel_tarefa_pessoa
values 
-- Lição 1 > Nelson
(1,1),

-- Lição 1 > João
(1,2),

-- Lição 1 > Antonia
(2,3),

-- Lição 1 > vinicius
(3,4),

-- Liçãoa 1 > Caio
(4,4)

insert into metodologia (titulo)
values 
('Metodologia'),
('Metodologia'),
('Nelson'),
('Richard')
go
 
 -- 1
 select p.nome, r.id_tarefa
 from pessoas as p
 left join rel_tarefa_pessoa as r
 on p.id = r.id_pessoas where r.id_tarefa is null
 
 -- 2
 select COUNT(titulo) as 'Quantidade mais Utilizada',titulo as 'Metodologias'
 from metodologia group by titulo order by COUNT(titulo) desc 
 
 -- 3 
 select COUNT(sexo) as 'Masculino' 
 from pessoas left join rel_tarefa_pessoa 
 on pessoas.id = rel_tarefa_pessoa.id_pessoas where pessoas.sexo = 'masculino'  
  select COUNT(sexo) as 'Feminino'
 from pessoas left join rel_tarefa_pessoa 
 on pessoas.id = rel_tarefa_pessoa.id_pessoas where pessoas.sexo = 'feminino'
 
 --4
 select p.nome as 'Nome', t.prazo_estimado as 'O Prazo estimado para as Tarefas', t.data_termino as 'O Termino das Tarefas'
from pessoas as p
join rel_tarefa_pessoa as r
on p.id = r.id_pessoas
join tarefa as t
on r.id_tarefa = t.id where t.data_termino > t.prazo_estimado

