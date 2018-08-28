
if not exists (select * from sys.databases where name = N'blog')
    begin
        create database [blog]
    end;
use blog

if not exists(select * from sys.tables where name='Categorias')
begin 
	CREATE TABLE Categorias(
	Id Uniqueidentifier primary key,
	Titulo varchar(MAX),
	Texto varchar(MAX),
	Fecha Date,
	Estado Int);
end
go
--drop table Categorias
select * from Categorias
-- INSERT
insert into Categorias(Id,Titulo,Texto,Fecha,Estado)values(NEWID(),'Tecnologia','Tecnologia','',1)
insert into Categorias(Id,Titulo,Texto,Fecha,Estado)values(NEWID(),'Ciencia','Ciencia','',0)
