USE [sigedoc]
GO
/****** Object:  StoredProcedure [dbo].[SPCrearDoc]    Script Date: 29/11/2019 16:35:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SPCrearDoc]
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
@periodo varchar(50)=null,
@numReferencia varchar(50) = null,
@habilitado int =null
as

if @opcion=1

begin

insert into TbDocCreado values(@nombredCreado,@asuntodCreado,@detalledCreadol, 
@Usuario,@idProyecto,@numConsecu,@documentoPDF,@documentoWord,@estatus,@fecha,@idCliente,@periodo,@numReferencia,@habilitado)

end

if @opcion=2

begin
select * from TbDocCreado
end

if @opcion=3

begin 

update TbDocCreado set nombredCreado=@nombredCreado,asuntodCreado=@asuntodCreado,detalledCreadol=@detalledCreadol,
documentoPDF=@documentoPDF,documentoWord=@documentoWord,estatus=@estatus,periodo=@periodo,habilitado=@habilitado where numtotaldocu=@numtotaldocu


end


if @opcion=4
begin
select documentoWord from TbDocCreado where idProyecto=@idProyecto
end