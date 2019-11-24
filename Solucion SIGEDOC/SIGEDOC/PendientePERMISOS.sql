USE [sigedoc]
GO
/****** Object:  StoredProcedure [dbo].[SPCrearPermisos]    Script Date: 23/11/2019 15:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SPCrearPermisos]
@opcion int,
@estadoRol int = null,
@nombreRol varchar(20) = null,
@detalleRol varchar(20) = null,
@consultarCliente varchar(20) = null,
@crearCliente varchar(20) = null,
@modificarCliente varchar(20) = null,
@crearProyecto varchar(20) = null,
@consultarProyecto varchar(20) = null,
@modificarProyecto varchar(20) = null,
@agreagarUsuario varchar(20) = null,
@consultarUsuario varchar(20) = null,
@modificarUsuario varchar(20) = null,
@DocCreado varchar(20) = null,
@consultarDocCreadol varchar(20) = null,
@modificarDocCreado varchar(20) = null,
@docSubido varchar(20) = null,
@consultarDocSubido varchar(20) = null,
@crearRol varchar(20) = null,
@consultarRol varchar(20) = null,
@modificarRol varchar(20) = null,
@bitacora varchar(20) = null,
@repoMovi varchar(20) = null,
@@repoProyei varchar(20) = null,
-----------------------------------------------
@opcConCliente int =null,
@opCreCliente int =null,
@opcModiCliente int =null,
@opcConProye int =null,
@opCreProye int =null,
@opcModiProye int =null,
@opcConUsuario int =null,
@opCreUsuario int =null,
@opcModiUsuario int =null,
@opcCondocCreado int =null,
@opCreadocCreado int =null,
@opcModidocCreado int =null,
@opcCondocSub int =null,
@opCredocSub int =null,
@opcModidocSub int =null,
@opcConRol int =null,
@opCreRol int =null,
@opcModiRol int =null,
@opcBitacora int =null,
@opcConRepoAudi int =null,
@opCreRepoMovi int =null,
@opcModiRepoProye int =null,
@idRol int =null,
-----------------------------------------------

as
if @opcion=1
begin
insert into TbPermiso (nombrePermiso, IdRol, estadoPermiso) VALUES (@consultar_cliente,@id_rol ,@opconsultar_cliente ), 
(@crear_cliente, @id_rol  ,@opccrear_cliente),(@crear_documento, @id_rol  ,@opccrear_documento ),(@subir_documento, @id_rol  ,@opcsubir_documento),
(@consultar_documento, @id_rol ,@opcconsultar_documento),(@usuarios, @id_rol ,@opcusuarios),(@roles, @id_rol ,@opcroles) ,(@bitacora, @id_rol ,@opcbitacora),
(@reportes_auditoria, @id_rol ,@opcreportes_auditoria),(@reportes_de_movimientos, @id_rol ,@opcreportes_de_movimientos),
(@reportes_de_proyectos, @id_rol ,@opcreportes_de_proyectos),(@crear_proyecto,@id_rol,@opccrear_proyecto),(@modificar_usuario,@id_rol,@opcmodificar_usuario)
end