create procedure SPCliente
@opcion int, 
@idCliente int =null,
@nombreCliente varchar(50) =null,
@nombreContacto varchar(30)= null,
@telefonoContacto int =null,
@correoElect varchar(50)=null,
@detalleCliente varchar(max),
@estadoCliente nchar=null
as

if @opcion=1

begin
insert into TbCliente values (@idCliente,@nombreCliente,@nombreContacto,@telefonoContacto,@correoElect,@detalleCliente,@estadoCliente)
end

if @opcion=2

begin 
select * from TbCliente
end 

if @opcion=3

begin
update TbCliente set nombreCliente=@nombreCliente,nombreContacto=@nombreContacto,telefonoContacto=@telefonoContacto,correoElect=@correoElect,detalleCliente=@detalleCliente,estadoCliente=@estadoCliente where idCliente=@idCliente
end

