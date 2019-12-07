using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace SIGEDOC.Negocio
{

    public class MoviBitacoraHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        MoviBitacora objMoviBitacora = null;
        public MoviBitacoraHelper(MoviBitacora parobjMoviBitacora)
        {
            objMoviBitacora = parobjMoviBitacora;
        }

        public void Agregar_Movimiento()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objMoviBitacora.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@accion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 250;
                parParameter[1].SqlValue = objMoviBitacora.Accion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@idUsuario";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = objMoviBitacora.IdUsuario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@fechaAccion";
                parParameter[3].SqlDbType = SqlDbType.DateTime;
                parParameter[3].SqlValue = objMoviBitacora.Fecha;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Tipo";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objMoviBitacora.Tipo;


                cnGeneral.EjecutarSP(parParameter, "SPMovimiento");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


    }
}