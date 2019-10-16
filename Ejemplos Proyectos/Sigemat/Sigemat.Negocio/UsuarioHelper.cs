using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Modelo; // Con esta capa hace referencia que es un "tipo de Arquitectura"
using System.Data; // tenemos que agregar estos dos using para poder utilizar la base de datos
using System.Data.SqlClient;


namespace Sigemat.Negocio
{
    public class UsuarioHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;// se utiliza cuando hace busqeudas en la tabla de la base de datos
        // llama a mi clase cliente donde tengo mis constructores, y tambien llamar mis set and get 
        Usuario objusuario = null;


        public UsuarioHelper (Usuario parobjusuario) //Encapsular la informacion que tenemos en la clase para poder utilizarla en esta
        {                                           //clase
            objusuario = parobjusuario;
        }

        public void GuardarUsuario()
        {

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objusuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objusuario.NombreUsuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@apellidos";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objusuario.NombreUsuario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@correoElectronico";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 20;
                parParameter[3].SqlValue = objusuario.CorreoElectronico;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@identificacion";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 20;
                parParameter[4].SqlValue = objusuario.IdentificacionUsuario;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@idPerfil";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objusuario.Perfil;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@direccion";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objusuario.DireccionUsuario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@clave";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objusuario.Clave;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@contacto";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objusuario.ContactoUsuario;
                               
                cnGeneral.EjecutarSP(parParameter, "SPCliente");
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public DataTable ValidarUsuario()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objusuario.Opc;

                // validar usuarios.
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@identificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objusuario.IdentificacionUsuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Clave";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = objusuario.Clave;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@tipo";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = objusuario.Perfil;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@correoElectronico";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objusuario.CorreoElectronico;

                //para  mi proceso almacenado USUARIO
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPValida");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


            return tblDatos;
        }



    }
}
