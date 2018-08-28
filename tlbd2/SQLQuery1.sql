use master
drop database Nelson2108	
create database Nelson2108

use Nelson2108

go





create procedure nel(
@desc_min as decimal(10,2),
@desc_max as decimal (10,2)
)
as 
begin 
select @desc_min as "Desconto minino", @desc_max as "Desconto maximo"
end
go
--exec nel 10.5, 20.5;
declare @variavel1 float (10),
         @variavel2 float(10);
         
 set @variavel1 = 10.5;
 set @variavel2 = 20.5;
 exec nel variavel1, varialvel2;