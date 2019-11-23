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
                          
        public void IngresarPermisos()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[24];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objPermisos.Opc;
                
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@consultar_cliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objPermisos.Consultar_cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@crear_cliente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objPermisos.Crear_cliente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@crear_documento";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 20;
                parParameter[3].SqlValue = objPermisos.Crear_documento;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@subir_documento";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 20;
                parParameter[4].SqlValue = objPermisos.Subir_documento;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@consultar_documento";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 20;
                parParameter[5].SqlValue = objPermisos.Consultar_documento;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@usuarios";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 20;
                parParameter[6].SqlValue = objPermisos.Usuarios;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@roles";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 20;
                parParameter[7].SqlValue = objPermisos.Roles;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@bitacora";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 20;
                parParameter[8].SqlValue = objPermisos.Bitacora;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@reportes_auditoria";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 20;
                parParameter[9].SqlValue = objPermisos.Reportes_auditoria;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@reportes_de_movimientos";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 20;
                parParameter[10].SqlValue = objPermisos.Reportes_de_movimientos;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@reportes_de_proyectos";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 20;
                parParameter[11].SqlValue = objPermisos.Reportes_de_proyectos;
                
                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@opconsultar_cliente";
                parParameter[12].SqlDbType = SqlDbType.Int;
                parParameter[12].SqlValue = objPermisos.Opcconsultar_cliente;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@opccrear_cliente";
                parParameter[13].SqlDbType = SqlDbType.Int;
                parParameter[13].SqlValue = objPermisos.Opccrear_cliente;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@opccrear_documento";
                parParameter[14].SqlDbType = SqlDbType.Int;
                parParameter[14].SqlValue = objPermisos.Opccrear_documento;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@opcsubir_documento";
                parParameter[15].SqlDbType = SqlDbType.Int;
                parParameter[15].SqlValue = objPermisos.Opcsubir_documento;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@opcusuarios";
                parParameter[16].SqlDbType = SqlDbType.Int;
                parParameter[16].SqlValue = objPermisos.Opcusuarios;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@opcroles";
                parParameter[17].SqlDbType = SqlDbType.Int;
                parParameter[17].SqlValue = objPermisos.Opcroles;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@opcbitacora";
                parParameter[18].SqlDbType = SqlDbType.Int;
                parParameter[18].SqlValue = objPermisos.Opcbitacora;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@opcreportes_auditoria";
                parParameter[19].SqlDbType = SqlDbType.Int;
                parParameter[19].SqlValue = objPermisos.Opcreportes_auditoria;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@opcreportes_de_movimientos";
                parParameter[20].SqlDbType = SqlDbType.Int;
                parParameter[20].SqlValue = objPermisos.Opcreportes_de_movimientos; ;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@opcreportes_de_proyectos";
                parParameter[21].SqlDbType = SqlDbType.Int;
                parParameter[21].SqlValue = objPermisos.Opcreportes_de_proyectos;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@id_rol";
                parParameter[22].SqlDbType = SqlDbType.Int;
                parParameter[22].SqlValue = objPermisos.Id_rol;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@opcconsultar_documento";
                parParameter[23].SqlDbType = SqlDbType.Int;
                parParameter[23].SqlValue = objPermisos.Opcconsultar_documento;

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
                SqlParameter[] parParameter = new SqlParameter[3];

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
                parParameter[1].SqlValue = objPermisos.Id_rol;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objPermisos.Nombre_permiso;

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
