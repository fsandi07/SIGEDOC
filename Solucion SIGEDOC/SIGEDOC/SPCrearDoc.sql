create procedure SPCrearDoc
@opcion int,
@numtotaldocu int= null,
@nombredCreado varchar(50) = null,
@asuntodCreado varchar(50)=null,
@detalledCreadol varchar(max)=null,
@Usuario varchar(20) = null,
@idProyecto int = null,
@numConsecu int= null,
@documentoPDF varbinary(max)=null,
@documentoWord varbinary(max)=null,
@estatus varchar(20)=null,
@fecha datetime =null,
@idCliente int= null,
@Periodo varchar(50)=null
as

if @opcion=1

begin

insert into TbDocCreado values(@nombredCreado,@asuntodCreado,@detalledCreadol, 
@Usuario,@idProyecto,@numConsecu,@documentoPDF,@documentoWord,@estatus,@fecha,@idCliente,@Periodo)

end

if @opcion=2

begin
select * from TbDocCreado
end

if @opcion=3

begin 

update TbDocCreado set nombredCreado=@nombredCreado,asuntodCreado=@asuntodCreado,detalledCreadol=@detalledCreadol,
documentoPDF=@documentoPDF,documentoWord=@documentoWord,estatus=@estatus,Periodo=@Periodo where numtotaldocu=@numtotaldocu

end
