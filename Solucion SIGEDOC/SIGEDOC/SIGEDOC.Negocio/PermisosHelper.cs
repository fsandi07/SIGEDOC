using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias agrgadas 
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
using System.IO;

namespace SIGEDOC.Negocio
{
   public class PermisosHelper
    {
        Datos cnGneral = null;
        DataTable tbldatos = null;
        Permisos objPermisos;

        public PermisosHelper(Permisos parObjPermisos)
        {
            objPermisos = parObjPermisos;
        }

        public DataTable Numero_Rol()
        {
            tbldatos = new DataTable();
            try
            {
                cnGneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;                

                tbldatos = cnGneral.RetornaTabla(parParameter, "SPNumRol");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tbldatos;
        }

        public void IngrewsarPermisos1() {

            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[46];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@crear_cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objPermisos.Crear_cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@consultar_cliente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objPermisos.Consultar_cliente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@modificarCliente";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objPermisos.Modificar_cliente;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@crear_proyecto";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objPermisos.Crear_proyecto;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@consultarProyecto";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objPermisos.Consultar_proyecto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@modificarProyecto";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objPermisos.Modificar_proyecto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@agreagarUsuario";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objPermisos.Agreagr_usuario;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@consultarUsuario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = objPermisos.Consultar_usuario;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@modificarUsuario";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objPermisos.Modificar_usuario;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@DocCreado";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objPermisos.Crear_documento;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@consultarDocCreado";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = objPermisos.Consultar_documento;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@modificarDocCreado";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = objPermisos.Modificar_documento;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@docSubido";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = objPermisos.Subir_documento;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@consultarDocSubido";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = objPermisos.Consultar_documento_subido;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@modificarDocSubido";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = objPermisos.Modificar_documento_subido;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@crearRol";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = objPermisos.Crear_rol;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@consultarRol";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = objPermisos.Consultar_rol;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@modificarRol";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = objPermisos.Modificar_rol;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@bitacora";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size = 50;
                parParameter[19].SqlValue = objPermisos.Bitacora;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@reporAudi";
                parParameter[20].SqlDbType = SqlDbType.VarChar;
                parParameter[20].Size = 50;
                parParameter[20].SqlValue = objPermisos.Reportes_auditoria;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@repoMovi";
                parParameter[21].SqlDbType = SqlDbType.VarChar;
                parParameter[21].Size = 50;
                parParameter[21].SqlValue = objPermisos.Reportes_de_movimientos;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@repoProye";
                parParameter[22].SqlDbType = SqlDbType.VarChar;
                parParameter[22].Size = 50;
                parParameter[22].SqlValue = objPermisos.Reportes_de_proyectos;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@opcConCliente";
                parParameter[23].SqlDbType = SqlDbType.Int;
                parParameter[23].SqlValue = objPermisos.Opcconsultar_cliente;

                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@opCreCliente";
                parParameter[24].SqlDbType = SqlDbType.Int;
                parParameter[24].SqlValue = objPermisos.Opccrear_cliente;

                parParameter[25] = new SqlParameter();
                parParameter[25].ParameterName = "@opcModiCliente";
                parParameter[25].SqlDbType = SqlDbType.Int;
                parParameter[25].SqlValue = objPermisos.Opcmodificar_cliente;

                parParameter[26] = new SqlParameter();
                parParameter[26].ParameterName = "@opcConProye";
                parParameter[26].SqlDbType = SqlDbType.Int;
                parParameter[26].SqlValue = objPermisos.Opcconsultar_proyecto;

                parParameter[27] = new SqlParameter();
                parParameter[27].ParameterName = "@opCreProye";
                parParameter[27].SqlDbType = SqlDbType.Int;
                parParameter[27].SqlValue = objPermisos.Opccrear_proyecto;

                parParameter[28] = new SqlParameter();
                parParameter[28].ParameterName = "@opcModiProye";
                parParameter[28].SqlDbType = SqlDbType.Int;
                parParameter[28].SqlValue = objPermisos.Opcmodificar_proyecto;

                parParameter[29] = new SqlParameter();
                parParameter[29].ParameterName = "@opcConUsuario";
                parParameter[29].SqlDbType = SqlDbType.Int;
                parParameter[29].SqlValue = objPermisos.Opcconsultar_usuario;

                parParameter[30] = new SqlParameter();
                parParameter[30].ParameterName = "@opCreUsuario";
                parParameter[30].SqlDbType = SqlDbType.Int;
                parParameter[30].SqlValue = objPermisos.Opccrear_usuario;

                parParameter[31] = new SqlParameter();
                parParameter[31].ParameterName = "@opcModiUsuario";
                parParameter[31].SqlDbType = SqlDbType.Int;
                parParameter[31].SqlValue = objPermisos.Opcmodificar_usuario;

                parParameter[32] = new SqlParameter();
                parParameter[32].ParameterName = "@opcCondocCreado";
                parParameter[32].SqlDbType = SqlDbType.Int;
                parParameter[32].SqlValue = objPermisos.Opcconsultar_doc_creado;

                parParameter[33] = new SqlParameter();
                parParameter[33].ParameterName = "@opCreadocCreado";
                parParameter[33].SqlDbType = SqlDbType.Int;
                parParameter[33].SqlValue = objPermisos.Opccrear_doc_subido;

                parParameter[34] = new SqlParameter();
                parParameter[34].ParameterName = "@opcModidocCreado";
                parParameter[34].SqlDbType = SqlDbType.Int;
                parParameter[34].SqlValue = objPermisos.Opcmodificar_doc_creado;

                parParameter[35] = new SqlParameter();
                parParameter[35].ParameterName = "@opcCondocSub";
                parParameter[35].SqlDbType = SqlDbType.Int;
                parParameter[35].SqlValue = objPermisos.Opcconsultar_doc_subido;

                parParameter[36] = new SqlParameter();
                parParameter[36].ParameterName = "@opCredocSub";
                parParameter[36].SqlDbType = SqlDbType.Int;
                parParameter[36].SqlValue = objPermisos.Opccrear_doc_subido;

                parParameter[37] = new SqlParameter();
                parParameter[37].ParameterName = "@opcModidocSub";
                parParameter[37].SqlDbType = SqlDbType.Int;
                parParameter[37].SqlValue = objPermisos.Opcmodificar_doc_subido;

                parParameter[38] = new SqlParameter();
                parParameter[38].ParameterName = "@opcConRol";
                parParameter[38].SqlDbType = SqlDbType.Int;
                parParameter[38].SqlValue = objPermisos.Opcconsultar_rol;

                parParameter[39] = new SqlParameter();
                parParameter[39].ParameterName = "@opCreRol";
                parParameter[39].SqlDbType = SqlDbType.Int;
                parParameter[39].SqlValue = objPermisos.Opccrear_rol;

                parParameter[40] = new SqlParameter();
                parParameter[40].ParameterName = "@opcModiRol";
                parParameter[40].SqlDbType = SqlDbType.Int;
                parParameter[40].SqlValue = objPermisos.Opcmodificar_rol;

                parParameter[41] = new SqlParameter();
                parParameter[41].ParameterName = "@opcBitacora";
                parParameter[41].SqlDbType = SqlDbType.Int;
                parParameter[41].SqlValue = objPermisos.Opcbitacora;

                parParameter[42] = new SqlParameter();
                parParameter[41].ParameterName = "@opcConRepoAudi";
                parParameter[42].SqlDbType = SqlDbType.Int;
                parParameter[42].SqlValue = objPermisos.Opcconsultar_repo_audi;

                parParameter[43] = new SqlParameter();
                parParameter[43].ParameterName = "@opCreRepoMovi";
                parParameter[43].SqlDbType = SqlDbType.Int;
                parParameter[43].SqlValue = objPermisos.Opccrear_repo_movi;

                parParameter[44] = new SqlParameter();
                parParameter[44].ParameterName = "@opcModiRepoProye";
                parParameter[44].SqlDbType = SqlDbType.Int;
                parParameter[44].SqlValue = objPermisos.Opcmodificar_repo_proye;

                parParameter[45] = new SqlParameter();
                parParameter[45].ParameterName = "@idRol";
                parParameter[45].SqlDbType = SqlDbType.Int;
                parParameter[45].SqlValue = objPermisos.IdRol;

                cnGneral.EjecutarSP(parParameter, "SPCrearPermisos");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        
        
        }

                          
        public void IngresarPermisos()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[46];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;
                                
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@crear_cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objPermisos.Crear_cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@consultar_cliente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objPermisos.Consultar_cliente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@modificarCliente";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objPermisos.Modificar_cliente;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@crear_proyecto";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objPermisos.Crear_proyecto;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@consultarProyecto";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objPermisos.Consultar_proyecto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@modificarProyecto";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objPermisos.Modificar_proyecto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@agreagarUsuario";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objPermisos.Agreagr_usuario;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@consultarUsuario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = objPermisos.Consultar_usuario;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@modificarUsuario";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objPermisos.Modificar_usuario;
                
                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@DocCreado";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objPermisos.Crear_documento;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@consultarDocCreado";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = objPermisos.Consultar_documento;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@modificarDocCreado";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = objPermisos.Modificar_documento;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@docSubido";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = objPermisos.Subir_documento;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@consultarDocSubido";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = objPermisos.Consultar_documento_subido;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@modificarDocSubido";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = objPermisos.Modificar_documento_subido;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@crearRol";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = objPermisos.Crear_rol;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@consultarRol";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = objPermisos.Consultar_rol;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@modificarRol";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = objPermisos.Modificar_rol;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@bitacora";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size = 50;
                parParameter[19].SqlValue = objPermisos.Bitacora;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@reporAudi";
                parParameter[20].SqlDbType = SqlDbType.VarChar;
                parParameter[20].Size = 50;
                parParameter[20].SqlValue = objPermisos.Reportes_auditoria;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@repoMovi";
                parParameter[21].SqlDbType = SqlDbType.VarChar;
                parParameter[21].Size = 50;
                parParameter[21].SqlValue = objPermisos.Reportes_de_movimientos;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@repoProye";
                parParameter[22].SqlDbType = SqlDbType.VarChar;
                parParameter[22].Size = 50;
                parParameter[22].SqlValue = objPermisos.Reportes_de_proyectos;
                
                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@opcConCliente";
                parParameter[23].SqlDbType = SqlDbType.Int;
                parParameter[23].SqlValue = objPermisos.Opcconsultar_cliente;
                
                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@opCreCliente";
                parParameter[24].SqlDbType = SqlDbType.Int;
                parParameter[24].SqlValue = objPermisos.Opccrear_cliente;
                
                parParameter[25] = new SqlParameter();
                parParameter[25].ParameterName = "@opcModiCliente";
                parParameter[25].SqlDbType = SqlDbType.Int;
                parParameter[25].SqlValue = objPermisos.Opcmodificar_cliente;

                parParameter[26] = new SqlParameter();
                parParameter[26].ParameterName = "@opcConProye";
                parParameter[26].SqlDbType = SqlDbType.Int;
                parParameter[26].SqlValue = objPermisos.Opcconsultar_proyecto;

                parParameter[27] = new SqlParameter();
                parParameter[27].ParameterName = "@opCreProye";
                parParameter[27].SqlDbType = SqlDbType.Int;
                parParameter[27].SqlValue = objPermisos.Opccrear_proyecto;
            
                parParameter[28] = new SqlParameter();
                parParameter[28].ParameterName = "@opcModiProye";
                parParameter[28].SqlDbType = SqlDbType.Int;
                parParameter[28].SqlValue = objPermisos.Opcmodificar_proyecto;

                parParameter[29] = new SqlParameter();
                parParameter[29].ParameterName = "@opcConUsuario";
                parParameter[29].SqlDbType = SqlDbType.Int;
                parParameter[29].SqlValue = objPermisos.Opcconsultar_usuario;

                parParameter[30] = new SqlParameter();
                parParameter[30].ParameterName = "@opCreUsuario";
                parParameter[30].SqlDbType = SqlDbType.Int;
                parParameter[30].SqlValue = objPermisos.Opccrear_usuario;

                parParameter[31] = new SqlParameter();
                parParameter[31].ParameterName = "@opcModiUsuario";
                parParameter[31].SqlDbType = SqlDbType.Int;
                parParameter[31].SqlValue = objPermisos.Opcmodificar_usuario;

                parParameter[32] = new SqlParameter();
                parParameter[32].ParameterName = "@opcCondocCreado";
                parParameter[32].SqlDbType = SqlDbType.Int;
                parParameter[32].SqlValue = objPermisos.Opcconsultar_doc_creado;

                parParameter[33] = new SqlParameter();
                parParameter[33].ParameterName = "@opCreadocCreado";
                parParameter[33].SqlDbType = SqlDbType.Int;
                parParameter[33].SqlValue = objPermisos.Opccrear_doc_subido;

                parParameter[34] = new SqlParameter();
                parParameter[34].ParameterName = "@opcModidocCreado";
                parParameter[34].SqlDbType = SqlDbType.Int;
                parParameter[34].SqlValue = objPermisos.Opcmodificar_doc_creado;

                parParameter[35] = new SqlParameter();
                parParameter[35].ParameterName = "@opcCondocSub";
                parParameter[35].SqlDbType = SqlDbType.Int;
                parParameter[35].SqlValue = objPermisos.Opcconsultar_doc_subido;

                parParameter[36] = new SqlParameter();
                parParameter[36].ParameterName = "@opCredocSub";
                parParameter[36].SqlDbType = SqlDbType.Int;
                parParameter[36].SqlValue = objPermisos.Opccrear_doc_subido;

                parParameter[37] = new SqlParameter();
                parParameter[37].ParameterName = "@opcModidocSub";
                parParameter[37].SqlDbType = SqlDbType.Int;
                parParameter[37].SqlValue = objPermisos.Opcmodificar_doc_subido;

                parParameter[38] = new SqlParameter();
                parParameter[38].ParameterName = "@opcConRol";
                parParameter[38].SqlDbType = SqlDbType.Int;
                parParameter[38].SqlValue = objPermisos.Opcconsultar_rol;
            
                parParameter[39] = new SqlParameter();
                parParameter[39].ParameterName = "@opCreRol";
                parParameter[39].SqlDbType = SqlDbType.Int;
                parParameter[39].SqlValue = objPermisos.Opccrear_rol;

                parParameter[40] = new SqlParameter();
                parParameter[40].ParameterName = "@opcModiRol";
                parParameter[40].SqlDbType = SqlDbType.Int;
                parParameter[40].SqlValue = objPermisos.Opcmodificar_rol;

                parParameter[41] = new SqlParameter();
                parParameter[41].ParameterName = "@opcBitacora";
                parParameter[41].SqlDbType = SqlDbType.Int;
                parParameter[41].SqlValue = objPermisos.Opcbitacora;

                parParameter[42] = new SqlParameter();
                parParameter[41].ParameterName = "@opcConRepoAudi";
                parParameter[42].SqlDbType = SqlDbType.Int;
                parParameter[42].SqlValue = objPermisos.Opcconsultar_repo_audi;

                parParameter[43] = new SqlParameter();
                parParameter[43].ParameterName = "@opCreRepoMovi";
                parParameter[43].SqlDbType = SqlDbType.Int;
                parParameter[43].SqlValue = objPermisos.Opccrear_repo_movi;

                parParameter[44] = new SqlParameter();
                parParameter[44].ParameterName = "@opcModiRepoProye";
                parParameter[44].SqlDbType = SqlDbType.Int;
                parParameter[44].SqlValue = objPermisos.Opcmodificar_repo_proye;

                parParameter[45] = new SqlParameter();
                parParameter[45].ParameterName = "@idRol";
                parParameter[45].SqlDbType = SqlDbType.Int;
                parParameter[45].SqlValue = objPermisos.IdRol;                                           

                cnGneral.EjecutarSP(parParameter, "SPCrearPermisos");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void IngresarRoles()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_rol";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objPermisos.Nombre_rol;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@detalle_rol";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objPermisos.Detalle_rol;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_rol";
                parParameter[3].SqlDbType = SqlDbType.Int;                
                parParameter[3].SqlValue = objPermisos.Estado_rol;

                cnGneral.EjecutarSP(parParameter,"SPCrearRol");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable Estado_Permisos()
        {
            tbldatos = new DataTable();
            try
            {
                cnGneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_rol";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objPermisos.IdRol;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objPermisos.Nom_Per1;

                tbldatos = cnGneral.RetornaTabla(parParameter, "SPValidaPermisos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tbldatos;
        }
    }
}
