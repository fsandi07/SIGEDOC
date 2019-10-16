USE [DBSigemat]
GO
/****** Object:  StoredProcedure [dbo].[SPValida]    Script Date: 16/10/2019 14:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SPValida]
@opcion int,
@identificacion varchar(20)=null, 
@Clave varchar(50)=null,
@tipo int=null,
@correoElectronico varchar(20)=null
as

if @opcion=1
begin

select *from tblUsuario where identificacion =@identificacion  and   clave =@Clave 

end
if @opcion=2
begin
select *from tblUsuario where identificacion =@identificacion  and   correoElectronico =@correoElectronico 
end