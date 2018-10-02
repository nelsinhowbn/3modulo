use master

drop database bdAluno

create database bdAluno

use bdAluno

create table tb_aluno (
idAluno int primary key identity not null,
nmAluno varchar(100) not null,
endAluno varchar(100) not null,
cepAluno varchar(10) not null,
emailAluno varchar(100),
nmrAluno varchar(10),
nmrFixoAluno varchar(10),
dtaNascimento date not null
)
