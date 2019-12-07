USE [DB_A4DE45_SIGEDOC]
GO
/****** Object:  StoredProcedure [dbo].[SPUsuario]    Script Date: 07/12/2019 9:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Procedimiento Almacenado Usuarios

ALTER procedure [dbo].[SPUsuario]
@opcion int,
@cedulaUsu varchar(20) = null,
@nombreUsu varchar(40) = null,
@apellidosUsu varchar(50)= null,
@nicknameUsu varchar(30)=null,
@correoElectUsu varchar(50) = null,
@claveUsu varchar(50) = null,
@idRol int = null,
@estadoUsu nchar =null,
@contactoUsu int= null,
@idUsuario varchar(50)= null

as
if @opcion = 1
Begin
 insert into TbUsuario values(@cedulaUsu,@nombreUsu,@apellidosUsu,@nicknameUsu,@correoElectUsu,CONVERT(varbinary(8000),ENCRYPTBYPASSPHRASE('password',@claveUsu)),@idRol,@estadoUsu,@contactoUsu,@idUsuario)	
end

if @opcion = 2

begin
select * from TbUsuario
end
--- este update le corresponde al adminstaror de base de datos donde puede actualizar solo los datos que se le permiten del usuario 
if @opcion = 3

begin
	update TbUsuario set nombreUsu = @nombreUsu,apellidosUsu = @apellidosUsu,nicknameUsu=@nicknameUsu,correoElectUsu=@correoElectUsu,idRol=@idRol,estadoUsu=@estadoUsu,contactoUsu=@contactoUsu,idUsuario=@idUsuario where cedulaUsu= @cedulaUsu
end
-- este update es para actualizar el perfil del usuario..
if @opcion = 4
begin
	update TbUsuario set nombreUsu = @nombreUsu,apellidosUsu = @apellidosUsu,nicknameUsu=@nicknameUsu,correoElectUsu=@correoElectUsu,idRol=@idRol,estadoUsu=@estadoUsu,contactoUsu=@contactoUsu,idUsuario=@idUsuario where cedulaUsu= @cedulaUsu
end


