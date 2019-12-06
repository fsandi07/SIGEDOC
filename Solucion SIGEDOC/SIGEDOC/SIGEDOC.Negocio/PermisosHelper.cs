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

        public void IngresaPermiso()
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
                parParameter[13].ParameterName = "@opcConCliente";
                parParameter[13].SqlDbType = SqlDbType.Int;
                parParameter[13].SqlValue = objPermisos.Opcconsultar_cliente;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@opCreCliente";
                parParameter[14].SqlDbType = SqlDbType.Int;
                parParameter[14].SqlValue = objPermisos.Opccrear_cliente;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@opcModiCliente";
                parParameter[15].SqlDbType = SqlDbType.Int;
                parParameter[15].SqlValue = objPermisos.Opcmodificar_cliente;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@opcConProye";
                parParameter[16].SqlDbType = SqlDbType.Int;
                parParameter[16].SqlValue = objPermisos.Opcconsultar_proyecto;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@opCreProye";
                parParameter[17].SqlDbType = SqlDbType.Int;
                parParameter[17].SqlValue = objPermisos.Opccrear_proyecto;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@opcModiProye";
                parParameter[18].SqlDbType = SqlDbType.Int;
                parParameter[18].SqlValue = objPermisos.Opcmodificar_proyecto;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@opcConUsuario";
                parParameter[19].SqlDbType = SqlDbType.Int;
                parParameter[19].SqlValue = objPermisos.Opcconsultar_usuario;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@opCreUsuario";
                parParameter[20].SqlDbType = SqlDbType.Int;
                parParameter[20].SqlValue = objPermisos.Opccrear_usuario;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@opcModiUsuario";
                parParameter[21].SqlDbType = SqlDbType.Int;
                parParameter[21].SqlValue = objPermisos.Opcmodificar_usuario;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@opcCondocCreado";
                parParameter[22].SqlDbType = SqlDbType.Int;
                parParameter[22].SqlValue = objPermisos.Opcconsultar_doc_creado;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@opCreadocCreado";
                parParameter[23].SqlDbType = SqlDbType.Int;
                parParameter[23].SqlValue = objPermisos.Opccrear_doc_creado;

                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@opcModidocCreado";
                parParameter[24].SqlDbType = SqlDbType.Int;
                parParameter[24].SqlValue = objPermisos.Opcmodificar_doc_creado;

                parParameter[25] = new SqlParameter();
                parParameter[25].ParameterName = "@idRol";
                parParameter[25].SqlDbType = SqlDbType.Int;
                parParameter[25].SqlValue = objPermisos.IdRol;

                parParameter[26] = new SqlParameter();
                parParameter[26].ParameterName = "@docSubido";
                parParameter[26].SqlDbType = SqlDbType.VarChar;
                parParameter[26].Size = 50;
                parParameter[26].SqlValue = objPermisos.Subir_documento;

                parParameter[27] = new SqlParameter();
                parParameter[27].ParameterName = "@consultarDocSubido";
                parParameter[27].SqlDbType = SqlDbType.VarChar;
                parParameter[27].Size = 50;
                parParameter[27].SqlValue = objPermisos.Consultar_documento_subido;

                parParameter[28] = new SqlParameter();
                parParameter[28].ParameterName = "@modificarDocSubido";
                parParameter[28].SqlDbType = SqlDbType.VarChar;
                parParameter[28].Size = 50;
                parParameter[28].SqlValue = objPermisos.Modificar_documento_subido;

                parParameter[29] = new SqlParameter();
                parParameter[29].ParameterName = "@opcCondocSub";
                parParameter[29].SqlDbType = SqlDbType.Int;
                parParameter[29].SqlValue = objPermisos.Opcconsultar_doc_subido;

                parParameter[30] = new SqlParameter();
                parParameter[30].ParameterName = "@opCredocSub";
                parParameter[30].SqlDbType = SqlDbType.Int;
                parParameter[30].SqlValue = objPermisos.Opccrear_doc_subido;

                parParameter[31] = new SqlParameter();
                parParameter[31].ParameterName = "@opcModidocSub";
                parParameter[31].SqlDbType = SqlDbType.Int;
                parParameter[31].SqlValue = objPermisos.Opcmodificar_doc_subido;

                parParameter[32] = new SqlParameter();
                parParameter[32].ParameterName = "@crearRol";
                parParameter[32].SqlDbType = SqlDbType.VarChar;
                parParameter[32].Size = 50;
                parParameter[32].SqlValue = objPermisos.Crear_rol;

                parParameter[33] = new SqlParameter();
                parParameter[33].ParameterName = "@consultarRol";
                parParameter[33].SqlDbType = SqlDbType.VarChar;
                parParameter[33].Size = 50;
                parParameter[33].SqlValue = objPermisos.Consultar_rol;

                parParameter[34] = new SqlParameter();
                parParameter[34].ParameterName = "@modificarRol";
                parParameter[34].SqlDbType = SqlDbType.VarChar;
                parParameter[34].Size = 50;
                parParameter[34].SqlValue = objPermisos.Modificar_rol;

                parParameter[35] = new SqlParameter();
                parParameter[35].ParameterName = "@opcConRol";
                parParameter[35].SqlDbType = SqlDbType.Int;
                parParameter[35].SqlValue = objPermisos.Opcconsultar_rol;

                parParameter[36] = new SqlParameter();
                parParameter[36].ParameterName = "@opCreRol";
                parParameter[36].SqlDbType = SqlDbType.Int;
                parParameter[36].SqlValue = objPermisos.Opccrear_rol;

                parParameter[37] = new SqlParameter();
                parParameter[37].ParameterName = "@opcModiRol";
                parParameter[37].SqlDbType = SqlDbType.Int;
                parParameter[37].SqlValue = objPermisos.Opcmodificar_rol;

                parParameter[38] = new SqlParameter();
                parParameter[38].ParameterName = "@bitacora";
                parParameter[38].SqlDbType = SqlDbType.VarChar;
                parParameter[38].Size = 50;
                parParameter[38].SqlValue = objPermisos.Bitacora;

                parParameter[39] = new SqlParameter();
                parParameter[39].ParameterName = "@reporAudi";
                parParameter[39].SqlDbType = SqlDbType.VarChar;
                parParameter[39].Size = 50;
                parParameter[39].SqlValue = objPermisos.Reportes_auditoria;

                parParameter[40] = new SqlParameter();
                parParameter[40].ParameterName = "@repoMovi";
                parParameter[40].SqlDbType = SqlDbType.VarChar;
                parParameter[40].Size = 50;
                parParameter[40].SqlValue = objPermisos.Reportes_de_movimientos;

                parParameter[41] = new SqlParameter();
                parParameter[41].ParameterName = "@repoProye";
                parParameter[41].SqlDbType = SqlDbType.VarChar;
                parParameter[41].Size = 50;
                parParameter[41].SqlValue = objPermisos.Reportes_de_proyectos;

                parParameter[42] = new SqlParameter();
                parParameter[42].ParameterName = "@opcBitacora";
                parParameter[42].SqlDbType = SqlDbType.Int;
                parParameter[42].SqlValue = objPermisos.Opcbitacora;

                parParameter[43] = new SqlParameter();
                parParameter[43].ParameterName = "@opcConRepoAudi";
                parParameter[43].SqlDbType = SqlDbType.Int;
                parParameter[43].SqlValue = objPermisos.Opcconsultar_repo_audi;

                parParameter[44] = new SqlParameter();
                parParameter[44].ParameterName = "@opCreRepoMovi";
                parParameter[44].SqlDbType = SqlDbType.Int;
                parParameter[44].SqlValue = objPermisos.Opccrear_repo_movi;

                parParameter[45] = new SqlParameter();
                parParameter[45].ParameterName = "@opcModiRepoProye";
                parParameter[45].SqlDbType = SqlDbType.Int;
                parParameter[45].SqlValue = objPermisos.Opcmodificar_repo_proye;

                cnGneral.EjecutarSP(parParameter, "SPIngresarPermisos");
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
