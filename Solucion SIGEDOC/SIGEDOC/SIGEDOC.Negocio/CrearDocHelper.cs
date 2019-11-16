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
    public class CrearDocHelper
    {
        Datos cnGneral = null;
        DataTable tbldatos = null;
        CrearDocumento objdocCreado;

        public CrearDocHelper(CrearDocumento parObjdocCreado)
        {
            objdocCreado = parObjdocCreado;
        }
        public DataTable Numero_Consecutivo()
        {
            tbldatos = new DataTable();
            try
            {
                cnGneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdocCreado.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@idProyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdocCreado.Id_proyecto;

                tbldatos = cnGneral.RetornaTabla(parParameter, "SPNum_Doc");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tbldatos;
        }

    }
}
