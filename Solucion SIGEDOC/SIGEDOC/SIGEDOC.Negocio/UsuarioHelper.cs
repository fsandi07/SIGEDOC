using System;
//librerias agregadas
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
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
        public DataTable Validar_Usuario()
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
                parParameter[1].SqlValue = objUsuarios.Nicname_usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@claveUsu";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Clave_usuario;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPValidacionUsu");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public DataTable Olvido_Clave()
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
                parParameter[1].SqlValue = objUsuarios.Nicname_usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@correoElect";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Correo_usuario;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOlvidoClave");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        // Agregar un Usuario Nuevo al sistema
        public void Agregar_Usuarios()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[11];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedulaUsu ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula_usuario;

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
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objUsuarios.Estado_usuarios;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@contactoUsu";
                parParameter[9].SqlDbType = SqlDbType.Int;
                parParameter[9].SqlValue = objUsuarios.Contacto_usuario;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@idUsuario";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objUsuarios.Idusuario;
                cnGeneral.EjecutarSP(parParameter, "SPUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Actualizar usuarios
        public void Actualizar_Usuario()
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
                parParameter[1].SqlValue = objUsuarios.Cedula_usuario;

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
                parParameter[6].ParameterName = "@idRol";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objUsuarios.Rol_usuario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@estadoUsu";
                parParameter[7].SqlDbType = SqlDbType.NChar;
                parParameter[7].Size = 1;
                parParameter[7].SqlValue = objUsuarios.Estado_usuarios;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@contactoUsu";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objUsuarios.Contacto_usuario;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@idUsuario";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objUsuarios.Idusuario;
                cnGeneral.EjecutarSP(parParameter, "SPUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Listar_Usuarios()
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
        public void Actualizar_Usuario_Personal()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombreUsu";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 40;
                parParameter[1].SqlValue = objUsuarios.Nombre_usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@apellidosUsu";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuarios.Apellidos;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@correoElectUsu";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objUsuarios.Correo_usuario;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@contactoUsu";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuarios.Contacto_usuario;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@idUsuario";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objUsuarios.Idusuario;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@claveUsu";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objUsuarios.Clave_usuario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@cedulaUsu";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objUsuarios.Cedula_usuario;
                cnGeneral.EjecutarSP(parParameter, "SPActualizaPersonal");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Busqueda()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombreUusario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objUsuarios.Nombre_usuario;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBusquedas");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public DataTable Busqueda2()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@estado";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objUsuarios.Estado_usuarios;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBusquedas");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public DataTable Valida_Cedula()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedulaUsu";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objUsuarios.Cedula_usuario;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPValidaCedu");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
    }
}
