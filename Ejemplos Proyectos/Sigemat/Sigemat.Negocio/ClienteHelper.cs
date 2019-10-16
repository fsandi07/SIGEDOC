using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // tenemos que agregar estos dos using para poder utilizar la base de datos
using System.Data.SqlClient;
using Progra6.Negocio; // para poder utilizar lo que tenemos en esta capa
using MVC.Modelo; // Con esta capa hace referencia que es un "tipo de Arquitectura"

namespace Progra6.Negocio
{
   public class ClienteHelper // Recordar colocar el public
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;// se utiliza cuando hace busqeudas en la tabla de la base de datos
        // llama a mi clase cliente donde tengo mis constructores, y tambien llamar mis set and get 
        Cliente objusuario = null; 


        public ClienteHelper(Cliente parobjusuario) //Encapsular la informacion que tenemos en la clase para poder utilizarla en esta
        {                                           //clase
            objusuario = parobjusuario;
        }

        public void GuardarCliente()
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
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objusuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Apellido";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objusuario.Apellido;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Direccion";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objusuario.Direccion;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Identidad";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 20;
                parParameter[4].SqlValue = objusuario.Identificacion;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@CorreoElectronico";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 20;
                parParameter[5].SqlValue = objusuario.Email;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@Salario ";
                parParameter[6].SqlDbType = SqlDbType.Decimal;
                parParameter[6].SqlValue = objusuario.Salario;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@Aporte";
                parParameter[7].SqlDbType = SqlDbType.Decimal;
                parParameter[7].SqlValue = objusuario.Aporte;

              

                cnGeneral.EjecutarSP(parParameter, "SPCliente");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public DataTable BusquedaCliente()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objconsolas.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_deArticulo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objconsolas.Nombre_consola;

                //para  mi proceso almacenado cliente
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBusqueda");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }



    }
}
