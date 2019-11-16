alter procedure SPNum_Doc
@opcion int,
@idProyecto int = null
as

if @opcion=1

begin 

Select "TbDocCreado".idProyecto, Sum("TbDocCreado".numConsecu+1)AS [Sub total]
FROM "TbDocCreado" where idProyecto = @idProyecto
GROUP BY "TbDocCreado".idProyecto

end

insert into TbProyecto values('Barranca san jose ','2019-cd-pec','Proyecto de asfaltado e infraestructura vial',
2,'121212','en proceso','2019-10-01',1)


select * from TbProyecto

select * from TbCliente
select * from TbUsuario