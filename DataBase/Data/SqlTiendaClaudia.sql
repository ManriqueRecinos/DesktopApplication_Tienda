CREATE DATABASE TiendaClaudia;
go

USE TiendaClaudia;
go

CREATE TABLE Usuarios(
	id_Usuario INT not null IDENTITY(1,1) CONSTRAINT pk_id_Usuario PRIMARY KEY,
	Nombre VARCHAR (50) not null,
	Usuario VARCHAR (50) not null,
	Contrasenia VARCHAR (50)not null,
	Tipo_usuario VARCHAR (50)
);

INSERT INTO Usuarios(Nombre,Usuario,Contrasenia,Tipo_usuario) VALUES
('Manrique Recinos','Manrex','123', 'Administrador'),
('Gerardo Gonzalez','Alexis','321', 'Usuario');

SELECT * FROM Usuarios;