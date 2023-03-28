--Creamos la base de datos
create database BD_Login
go

--todo lo trabajaremos en la bd_login
use BD_Login
go

--Creamos la tabla usuario
CREATE TABLE tb_Usuario(
idUsuario  int IDENTITY(1,1) primary key,
Usuario varchar(50),
Pass varbinary(8000) 
)
go

--funcion para incriptar la contra
create function fencriptar(@clave varchar(50))
returns varbinary(8000)
as
begin
	declare @valor varbinary(8000)
	set @valor = ENCRYPTBYPASSPHRASE('David',@clave);
	return @valor
end

select dbo.fencriptar('osito23');

--procedimiento para ingresar el usuario y  incriptar la pass
create procedure pinsertar
@usuario varchar(50), @pass varchar(50)
as 
begin
	begin tran
		insert into tb_Usuario 
		values(@usuario,dbo.fencriptar(@pass))
	commit 
end

exec pinsertar'WilfredoAc22','4418';

select * from tb_Usuario;

---funcion para desincriptar
Create function fdesincriptar(@clave varbinary(8000))
returns varchar(50)
as
begin
	declare @valor varchar(50) 
	set @valor = DECRYPTBYPASSPHRASE('David',@clave)
	return @valor
end

select idUsuario, Usuario, dbo.fdesincriptar(Pass) as pass 
from tb_Usuario


--funcion para verificar si el usuario ya esta en uso
Create function fuser(@nombreUsuario as varchar(50))
returns int
as
begin 
	DECLARE @result int
		SET @result=(select idUsuario from tb_usuario 
		where Usuario like @nombreUsuario)
	return @result 
end

select dbo.fuser('WilfredoAc22') from tb_Usuario;

Delete from tb_Usuario Where idUsuario = 2;