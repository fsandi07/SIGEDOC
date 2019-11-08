using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias agregadas
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
using System.IO;

namespace SIGEDOC.Negocio
{
   public class UsuarioHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        Usuarios objUsuarios = null;
        public UsuarioHelper(Usuarios parObjususarios)
        {
            objUsuarios = parObjususarios;
        }
        //VALIDAR USUARIOS.
        public DataTable validarusuario()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                // validar usuarios.
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nicknameUsu";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula_susuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@claveUsu";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Clave_usuario;

                //para  mi proceso almacenado USUARIO
                tblDatos = cnGeneral.RetornaTabla(parParameter,"SPValidacionUsu");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        // Agregar un Usuario Nuevo al sistema

        public void AgregarUsuarios()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[10];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedulaUsu ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula_susuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombreUsu";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 40;
                parParameter[2].SqlValue = objUsuarios.Nombre_usuario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellidosUsu";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objUsuarios.Apellidos;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@nicknameUsu";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objUsuarios.Nicname_usuario;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correoElectUsu";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objUsuarios.Correo_usuario;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@claveUsu";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objUsuarios.Clave_usuario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@idRol";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = objUsuarios.Rol_usuario;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@estadoUsu";
                parParameter[8].SqlDbType = SqlDbType.NChar;
                parParameter[8].Size = 1;
                parParameter[8].SqlValue = objUsuarios.Estado_usuarios;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@contactoUsu";
                parParameter[9].SqlDbType = SqlDbType.Int;
                parParameter[9].SqlValue = objUsuarios.Contacto_usuario;


                cnGeneral.EjecutarSP(parParameter, "SPUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        // Actualizar usuarios

        public void ActualizarUsuario()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[10];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedulaUsu ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula_susuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombreUsu";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 40;
                parParameter[2].SqlValue = objUsuarios.Nombre_usuario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellidosUsu";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objUsuarios.Apellidos;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@nicknameUsu";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objUsuarios.Nicname_usuario;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correoElectUsu";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objUsuarios.Correo_usuario;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@claveUsu";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objUsuarios.Clave_usuario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@idRol";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = objUsuarios.Rol_usuario;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@estadoUsu";
                parParameter[8].SqlDbType = SqlDbType.NChar;
                parParameter[8].Size = 1;
                parParameter[8].SqlValue = objUsuarios.Estado_usuarios;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@contactoUsu";
                parParameter[9].SqlDbType = SqlDbType.Int;
                parParameter[9].SqlValue = objUsuarios.Contacto_usuario;


                cnGeneral.EjecutarSP(parParameter, "SPUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public DataTable listarUsuarios()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }


    }
}
