---Procedimiento Almacenado Usuarios

create procedure SPUsuario
@opcion int,
@cedulaUsu varchar(20) = null,
@nombreUsu varchar(40) = null,
@apellidosUsu varchar(50)= null,
@nicknameUsu varchar(30)=null,
@correoElectUsu varchar(50) = null,
@claveUsu varchar(50) = null,
@idRol int = null,
@estadoUsu nchar =null,
@contactoUsu int= null

as
if @opcion = 1
Begin
 insert into TbUsuario values(@cedulaUsu,@nombreUsu,@apellidosUsu,@nicknameUsu,@correoElectUsu,CONVERT(varbinary(8000),ENCRYPTBYPASSPHRASE('password',@claveUsu)),@idRol,@estadoUsu,@contactoUsu)	
end

if @opcion = 2

begin
select * from TbUsuario
end

if @opcion = 3

begin
	update TbUsuario set nombreUsu = @nombreUsu,apellidosUsu = @apellidosUsu,nicknameUsu=@nicknameUsu,correoElectUsu=@correoElectUsu,idRol=@idRol,estadoUsu=@estadoUsu,contactoUsu=@contactoUsu,claveUsu=CONVERT(varbinary(8000),ENCRYPTBYPASSPHRASE('password',@claveUsu)) where cedulaUsu= @cedulaUsu
end