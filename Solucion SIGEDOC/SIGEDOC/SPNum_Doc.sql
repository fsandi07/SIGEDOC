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
