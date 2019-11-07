alter procedure SPValidacionUsu
@opcion int,
@cedulaUsu varchar(20)=null,
@claveUsu varchar(50)=null
as
-- declaracion de variables para almacenar los datos a desencriptar
declare @ClaveEncriptada as Nvarchar (max)
declare @DesencriptarClave as Nvarchar(max)

if @opcion=1

begin 
--- aqui llamamos el valor a desencriptar y lo saginamos a las variables 
select @ClaveEncriptada=claveUsu from TbUsuario where cedulaUsu=@cedulaUsu
set @DesencriptarClave=convert(varchar(max),DECRYPTBYPASSPHRASE('password',@ClaveEncriptada))

select *from TbUsuario where cedulaUsu=@cedulaUsu and @claveUsu=@DesencriptarClave 

end

--select cedulaUsu,claveUsu=convert(varchar(max),DECRYPTBYPASSPHRASE('password',claveUsu)) from TbUsuario 

--select * from TbUsuario