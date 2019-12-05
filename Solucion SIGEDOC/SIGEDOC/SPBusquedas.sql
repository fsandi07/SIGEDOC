create procedure SPBusquedas

@opcion int,
@centroCostos int = null
as 

if @opcion=1
begin 
select a.centroCostos,a.NombreProy,a.NumLicita,a.detalleProyec,a.idCliente,c.nombrecliente,a.estadoProyec,a.fechaProy,b.nombreUsu
from TbProyecto a, TbUsuario b,TbCliente c where a.idUsuario = b.cedulaUsu and a.idCliente=c.idCliente and centroCostos= @centroCostos
end

