alter procedure SPDocsubido
@opcion int,
@numTotalSub int = null,
@nombredSub varchar(50) = null,
@detalledSub varchar(max)=null,
@Usuario varchar(20) = null,
@idProyecto int = null,
@numConseSub int= null,
@documentoPdfSub varbinary(max)=null,
@documentoWordSub varbinary(max)=null,
@fechaSub datetime =null,
@idCliente int= null,
@periodo varchar(50)=null,
@referenciaSub varchar(50)=null,
@ModificadoPor varchar(50)= null

as 

if @opcion=1
begin
insert into TbDocSubido values(@nombredSub,@detalledSub,@numConseSub,@idCliente,@referenciaSub,@Usuario,@fechaSub,@documentoWordSub,@documentoPdfSub,@idProyecto,@periodo,@ModificadoPor)
end 

if @opcion=2
begin
select * from TbDocSubido
end

if @opcion=3
begin
update TbDocSubido set @nombredSub=nombredSub,detalledSub=@detalledSub,@documentoWordSub=documentoWordSub,documentoPdfSub=@documentoPdfSub,periodo=@periodo,ModificadoPor=@ModificadoPor where numtotalSub=@numtotalSub
end



select a.numTotalSub,a.nombredSub,a.detalledSub,a.documentoPdfSub,a.documentoWordSub,a.fechaSub,a.idCliente,c.nombrecliente,a.idProyecto,b.nombreusu,a.referenciaSub,b.nombreUsu as [Modificado Por]

from tbdocsubido a, TbUsuario b,TbCliente c where  a.idCliente=c.idCliente and a.idUsuario = b.cedulaUsu and  a.ModificadoPor=b.cedulaUsu

update TbDocSubido set ModificadoPor='1131706783' where ModificadoPor='Sin Modidificar' 
