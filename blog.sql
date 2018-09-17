-- CREATE DATABASE IF NOT EXISTS
if not exists (select * from sys.databases where name = N'blog')
    begin
        create database [blog]
    end;

USE blog

-- TABLE CATEGORIES
if not exists(select * from sys.tables where name='Categorias')
begin 
	CREATE TABLE Categorias(
	Id Uniqueidentifier primary key,
	Titulo varchar(MAX),
	Texto varchar(MAX),
	Fecha Date,
	Estado Int);
end

-- TABLE POSTS
if not exists(select * from sys.tables where name='Posts')
begin 
	CREATE TABLE Posts(
	Id Uniqueidentifier primary key,
	Titulo varchar(250),
	Contenido varbinary(max),
	CategoriaId Uniqueidentifier,
	Fecha Date,
	UsuarioId UniqueIdentifier,
		constraint FK_PostUsuarios_Id FOREIGN KEY (UsuarioId)
		references dbo.Usuarios(Id),
		constraint FK_Categorias_Id Foreign Key (CategoriaId)
		references dbo.Categorias(Id)
	);
end
go

-- TABLE TAGS
if not exists(select * from sys.tables where name='Tags')
begin 
	CREATE TABLE Tags(
	Id Uniqueidentifier primary key,
	Nombre varchar(50));
end
go

-- TABLE USERS
if not exists(select * from sys.tables where name='Usuarios')
begin 
	CREATE TABLE Usuarios(
	Id Uniqueidentifier primary key,
	Nombre varchar(20),
	Apellidos varchar(50),
	Estado int,
	NombreUsuario varchar(50),
	Password varchar(250));
end
go

-- TABLE USER PERFIL
if not exists(select * from sys.tables where name='UsuarioPerfil')
begin 
	CREATE TABLE UsuarioPerfil(
	Id Uniqueidentifier primary key,
	UsuarioId Uniqueidentifier,
	Foto VarBinary(max),
	Descripcion nvarchar(max),
	constraint FK_Usuario_Id Foreign Key (UsuarioId)
	references dbo.Usuarios(Id)
	);
end
go

-- TABLE POST TAGS
if not exists(select * from sys.tables where name='PostTags')
begin 
	CREATE TABLE PostTags(
	Id Uniqueidentifier primary key,
	PostId Uniqueidentifier,
	TagId UniqueIdentifier,
	constraint FK_Post_tag_Id Foreign Key (PostId)
	references dbo.Posts(Id),
	constraint FK_Tag_Id Foreign Key (TagId)
	references dbo.Tags(Id)
	);
end
go