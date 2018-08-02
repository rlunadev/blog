use blog

if not exists(select * from sys.tables where name='Categorias')
begin 
	CREATE TABLE Categorias(
	Id Int primary key,
	Titulo varchar(MAX),
	Texto varchar(MAX),
	Fecha Date,
	Estado Int);
end
go

