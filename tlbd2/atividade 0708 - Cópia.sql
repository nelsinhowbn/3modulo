use master
go

drop database atividade07082018
go

create database atividade07082018
go

use atividade07082018
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
('Juliana','pessoa1@gmail.com','feminino'),
('Vanessa','pessoa2@gmail.com','feminino'),
('Mariana','pessoa3@gmail.com','feminino'),

-- Tarefas atrasadas.
('Hebert','pessoa4@gmail.com','masculino'), 

-- Não fazem parte de nenhuma tarefa.
('Richard','pessoa5@gmail.com','masculino'),
('Caio','pessoa6@gmail.com','masculino')


insert into tarefa
values 
('Tarefa 1','2018-07-08','Descricao tarefa 1','2018-07-08','2018-07-08'),
('Tarefa 2','2018-07-08','Descricao tarefa 2','2018-07-08','2018-07-08'),

-- Tarefas atrasadas.
('Tarefa 3','2018-07-08','Descricao tarefa 3','2018-07-08','2018-07-09'),
('Tarefa 4','2018-07-08','Descricao tarefa 4','2018-07-05','2018-07-09')

insert into rel_tarefa_pessoa
values 
-- Tarefa 1 > Juliana
(1,1),

-- Tarefa 1 > Vanessa
(1,2),

-- Tarefa 1 > Mariana
(2,3),

-- Tarefa 1 > Richard
(3,4),

-- Tarefa 1 > Richard
(4,4)

insert into metodologia (titulo)
values 
('OIOIOIO'),
('OIOIOIO'),
('OIOIOIO'),
('Fim')
go
