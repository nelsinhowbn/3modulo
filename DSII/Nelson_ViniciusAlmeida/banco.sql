use Agenda;
create table pessoa (
id_pessoa int primary key identity ,
nome_cliente nvarchar(500),
endereco nvarchar(500),
estado_civil nvarchar(500),
data_nascimento varchar(500),
)


create table pessoa_documento(
id_pessoa int primary key identity ,
rg varchar (5000) ,
cpf varchar (5000) ,
reservista varchar (5000),
carteira_trabalho varchar (5000),
cnh varchar(500)
)


create table funcionario(
id_funcionario int primary key identity ,
id_pessoa int ,
cargo varchar(500),
salario varchar (500) ,
ramal_empresa int
)


create table clientes(
id_cliente int primary key identity ,
id_pessoa int,
data_inclusao varchar(500)
)
go




CREATE PROCEDURE sp_pessoa
@nome_cliente varchar(50)
as 
SELECT * FROM pessoa
WHERE nome_cliente = @nome_cliente


CREATE PROCEDURE sp_cliente
@id_pessoa varchar(50)
as clientes
SELECT * FROM clientes
WHERE id_pessoa = @id_pessoa


CREATE PROCEDURE sp_funcionario
@id_pessoa varchar(50)
as 
SELECT * FROM funcionario
WHERE id_pessoa = @id_pessoa


CREATE PROCEDURE sp_pessoadoc
@rg varchar(50)
as 
SELECT * FROM pessoa_documento
WHERE rg = @rg


select * from  pessoa

select * from funcionario

select * from clientes

select * from pessoa_documento

insert into Funcionario values ( '1','uhgu','516','123')

insert into pessoa_documento values ('2', '03/03/1999')
select * from clientes