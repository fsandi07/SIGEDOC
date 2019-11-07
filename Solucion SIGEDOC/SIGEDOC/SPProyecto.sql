create procedure SPProyecto
@opcion int,
@centroCostos int =null,
@NombreProy varchar(50)=null,
@NumLicita varchar(30)=null,
@detalleProyec varchar(max)=null,
@idCliente int =null,
@idUsuario varchar(20)=null,
@estadoProyec nchar(10)=null,
@fechaProy datetime=null,
@statusProyec nchar(1)=null
as

if @opcion = 1
begin
    insert into TbProyecto values(@centroCostos,@NombreProy,@NumLicita,@detalleProyec,@idCliente,@idUsuario,@estadoProyec,@fechaProy,@statusProyec)		
end

if @opcion=2

begin
select * from TbProyecto
end


if @opcion=3

begin
update TbProyecto set NombreProy=@NombreProy,NumLicita=@NumLicita,detalleProyec=@detalleProyec,idCliente=@idCliente,idUsuario=@idUsuario,estadoProyec=@estadoProyec,fechaProy=@fechaProy,statusProyec=@statusProyec where centroCostos=@centroCostos
end

