create procedure SPReportes
@opcion int
as 
if @opcion=1
begin 
select accion as [Accion que se Realizo],idUsuario as [Identificacion del Usuario],fechaAccion as[fecha y hora de Accion ] from TbBitacora where tipo='1'
end 

if @opcion=2
begin 
select accion as [Accion que se Realizo],idUsuario as [Identificacion del Usuario],fechaAccion as[fecha y hora de Accion ] from TbBitacora where tipo='2'
end 

if @opcion=3

begin 
select centroCostos as [Centro de Costos ],NombreProy as[Nombre],NumLicita as [Numero de licitacion],detalleProyec as [Detalle],idCliente as [ Id Cliente ],idUsuario as [Id Usuario ],estadoProyec as [Estado],fechaProy as [Fecha ] from TbProyecto1
end

select * from TbBitacora


delete TbBitacora where idUsuario=1131706783
------------------
DBCC CHECKIDENT (TbBitacora, RESEED,0)
select claveusu=convert(varchar(max),DECRYPTBYPASSPHRASE('password',claveusu)) from tbUsuario 

select * from TbBitacora

select * from  TbPermiso
