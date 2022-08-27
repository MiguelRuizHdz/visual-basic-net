create database ejemplo

use ejemplo

create table alumno(
	matricula int,
	nombre varchar(100),
	direccion varchar(100),
	telefono varchar(20)
)

USE [ejemplo]
GO

INSERT INTO [dbo].[alumno]
           ([matricula]
           ,[nombre]
           ,[direccion]
           ,[telefono])
     VALUES
           (1001
           ,'Juan Lopez'
           ,'Calle 1 No 1000'
           ,'1010202010')
GO


--- Consulta General
SELECT [matricula]
      ,[nombre]
      ,[direccion]
      ,[telefono]
  FROM [ejemplo].[dbo].[alumno]

--- Consulta X Matricula
SELECT [matricula]
      ,[nombre]
      ,[direccion]
      ,[telefono]
  FROM [ejemplo].[dbo].[alumno]
  WHERE matricula = 1000


  -- Actualizacion
  UPDATE [dbo].[alumno]
   SET [nombre] = 'Miguel Ruiz'
      ,[direccion] = 'Calle 1 No 1000'
      ,[telefono] = '1010202020'
 WHERE matricula = 1000

 -- Eliminar Alumno
 DELETE FROM [dbo].[alumno]
      WHERE matricula = 1001

-- Procedimientos Almacenados
create procedure spAlumnoConsulta
as
begin
SELECT [matricula]
      ,[nombre]
      ,[direccion]
      ,[telefono]
  FROM [dbo].[alumno]
end

EXEC spAlumnoConsulta


-- Consulta por matricula
create procedure spAlumnoConsultaXMatricula
@matricula int
as
begin
SELECT [matricula]
      ,[nombre]
      ,[direccion]
      ,[telefono]
  FROM [ejemplo].[dbo].[alumno]
  WHERE matricula = @matricula
end

-- Consulta por matricula
exec spAlumnoConsultaXMatricula 1001



-- Insertar alumno
create procedure spAlumnoInsert
@matricula int,
@nombre varchar(100),
@direccion varchar(100),
@telefono varchar(20)
as
begin
INSERT INTO [dbo].[alumno]
           ([matricula]
           ,[nombre]
           ,[direccion]
           ,[telefono])
     VALUES
           (@matricula
           ,@nombre
           ,@direccion
           ,@telefono)
end

exec spAlumnoInsert 1001, 'Pablo Garza', 'Calle 2 No 1001', '8181818899'

-- Actualizacion del Alumno por matricula
create procedure spAlumnoActualizarXMatricula
@matricula int,
@nombre varchar(100),
@direccion varchar(100),
@telefono varchar(20)
as
begin
  UPDATE [dbo].[alumno]
   SET [nombre] = @nombre
      ,[direccion] = @direccion
      ,[telefono] = @telefono
 WHERE matricula = @matricula
end

exec spAlumnoActualizarXMatricula 1000, 'Miguel Ruiz', 'Calle 1 No 1000', '1010202020'

 -- Eliminar Alumno por matricula
create procedure spAlumnoEliminarXMatricula
@matricula int
as
begin
	DELETE FROM [dbo].[alumno]
	WHERE matricula = @matricula
end

exec spAlumnoEliminarXMatricula 1001