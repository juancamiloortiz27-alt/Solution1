CREATE DATABASE db_colegios
GO
USE db_colegios
GO

create table [Salones] 
(
	[id] int primary key identity(1,1),
	[Codigo] nvarchar(20) not null,
	[Capacidad] int
);

insert into [Salones] ([Codigo], [Capacidad]) values ('K 301', 40);