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
   public  class DomunetoSubHelper
    {
        Datos cnGneral = null;
        DataTable tbldatos = null;
        DocumentoSub objdoDocumentoSub;

        public DomunetoSubHelper(DocumentoSub parObjdoDocumentoSub)
        {
            objdoDocumentoSub = parObjdoDocumentoSub;
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
                parParameter[0].SqlValue = objdoDocumentoSub.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@idProyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdoDocumentoSub.Id_proyecto;

                tbldatos = cnGneral.RetornaTabla(parParameter, "SPNum_DocSub");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tbldatos;
        }
        public DataTable Numero_total_Doc()
        {
            tbldatos = new DataTable();
            try
            {
                cnGneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdoDocumentoSub.Opc;

                tbldatos = cnGneral.RetornaTabla(parParameter, "SPtotal_DocSub");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tbldatos;
        }

        public void Ingresar_DocSubido()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[14];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdoDocumentoSub.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numTotalSub";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdoDocumentoSub.Total_doc_creado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombredSub";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objdoDocumentoSub.Nom_doc_creado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@detalledSub";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objdoDocumentoSub.Detalle_doc_creado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Usuario";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objdoDocumentoSub.Id_usuario;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@idProyecto";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objdoDocumentoSub.Id_proyecto;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@numConseSub";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objdoDocumentoSub.Num_consecutivo;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@documentoPdfSub";
                parParameter[7].SqlDbType = SqlDbType.VarBinary;
                parParameter[7].SqlValue = objdoDocumentoSub.Pdf_doc_creado;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@documentoWordSub";
                parParameter[8].SqlDbType = SqlDbType.VarBinary;
                parParameter[8].SqlValue = objdoDocumentoSub.Word_doc_creado;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@fechaSub";
                parParameter[9].SqlDbType = SqlDbType.DateTime;
                parParameter[9].SqlValue = objdoDocumentoSub.Fecha_doc_subido;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@idCliente";
                parParameter[10].SqlDbType = SqlDbType.Int;
                parParameter[10].SqlValue = objdoDocumentoSub.Id_cliente;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@periodo";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = objdoDocumentoSub.Periodo;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@referenciaSub";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = objdoDocumentoSub.Num_referencia_creado;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@ModificadoPor";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = objdoDocumentoSub.ModificadoPor1;

                cnGneral.EjecutarSP(parParameter, "SPDocsubido");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Actualizar_DocSubido()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdoDocumentoSub.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numTotalSub";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdoDocumentoSub.Total_doc_creado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombredSub";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objdoDocumentoSub.Nom_doc_creado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@detalledSub";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objdoDocumentoSub.Detalle_doc_creado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@documentoPdfSub";
                parParameter[4].SqlDbType = SqlDbType.VarBinary;
                parParameter[4].SqlValue = objdoDocumentoSub.Pdf_doc_creado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@documentoWordSub";
                parParameter[5].SqlDbType = SqlDbType.VarBinary;
                parParameter[5].SqlValue = objdoDocumentoSub.Word_doc_creado;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@periodo";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objdoDocumentoSub.Periodo;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@referenciaSub";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objdoDocumentoSub.Num_referencia_creado;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@ModificadoPor";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = objdoDocumentoSub.ModificadoPor1;

                cnGneral.EjecutarSP(parParameter, "SPDocsubido");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
