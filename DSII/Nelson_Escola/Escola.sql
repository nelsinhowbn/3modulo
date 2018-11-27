create database Escola
drop database Escola
use master 



create table aluno (
id_aluno int primary key identity (1,1),
nome varchar(100),
email varchar(200),
rg varchar(200),
cpf varchar(200),
estado varchar(200),
)


create table professor (
id_professor int primary key identity (1,1),
nome varchar(100),
email varchar(200),
rg varchar(200),
cpf varchar(200),
estado varchar(200),
)



select * from aluno
select * from professor

delete from   aluno

insert into aluno(estado) values ('Minas Gerais')