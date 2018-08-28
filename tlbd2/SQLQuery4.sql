use master
drop database Nelson
create database Nelson
use Nelson


create table Tarefa(
id int primary Key identity(1,1),
titulo  varchar(100) not null,
prazoestimado date,
descricao nvarchar(100),
datainicio varchar(100) not null,
datatermino varchar(100) not null,

)

create table tb_hardware(
id_hardware int Primary Key identity(1,1),
descricao varchar(100),
preco float,
qtde int,
qtde_mini int
)

create table tb_vendas(
id_venda int Primary Key identity(1,1),
id_cliente int,
data date,
valor_total float,
desconto float,
valor_pago float,
)

create table tb_vendas_itens(
id_item int Primary Key identity(1,1),
id_venda int,
id_hardware int,
qtde_item int,
total_itens int
)
--alter table tb_vendas
--add constraint fk_id_cliente
--foreign key(id_cliente)
--references tb_clientes(id_cliente)

insert into tb_clientes(nome, endereco, fone, email)
values('Richard de Oliveira Lopes', 'R Aguia de Haia 255', '40028922', 'richard.oliveira@hotmail.com')

insert into tb_clientes(nome, endereco, fone, email)
values('Vinicius Alves Rodrigues', 'R Aguia de Haia 362', '36063623', 'vinicius.alves@hotmail.com')

insert into tb_clientes(nome, endereco, fone, email)
values('Vitãozinho Hugo', 'R Aguia de Haia 457', '25186066', 'vitaozinho.hugo@hotmail.com')

insert into tb_clientes(nome, endereco, fone, email)
values('Raul Benjamin Victor Lopes', 'Rua Frei Luiz Carolino 487', '25649403', 'rraulbenjaminvictorlopes@construtoraplaneta.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Isaac Fernando Rodrigo Castro', 'Rua JP 44', '39895786', 'isaacfernandorodrigocastro-83@accent.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Yago Carlos Eduardo Gustavo Almeida', 'Rua Aretuza Machado de Andrade 869', '26614946', 'yyagocarloseduardogustavoalmeida@vegacon.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Igor Caio Fernando Fernandes', 'Rua Coletor Antônio Gadelha 32', '28580715', 'iigorcaiofernandofernandes@jcoronel.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Bernardo Ian Yago da Conceição', 'Rua Curitiba 399', '37447668', 'bernardoianyagodaconceicao_@zyb.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Lucas Augusto Fernando da Rocha', 'Avenida Candeias 488', '29310978', 'lucasaugustofernandodarocha@caej.com.br')

insert into tb_clientes(nome, endereco, fone, email)
values('Gabriel Otávio Moreira', 'Rua Vinícius de Morais 460', '29337669', 'gabrielotaviomoreira@icloud.com')





--update tb_hardware set descricao = 'HD' , qtde = '4'
--delete from tb_hardware
--where id_hardware = 1

--select*from  tb_hardware;