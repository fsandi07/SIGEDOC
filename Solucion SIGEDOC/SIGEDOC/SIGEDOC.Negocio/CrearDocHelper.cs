using System;
//librerias agrgadas 
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
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
                parParameter[0].SqlValue = objdocCreado.Opc;
                tbldatos = cnGneral.RetornaTabla(parParameter, "SPtotal_Doc1");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tbldatos;
        }
        public void Ingresar_DocCreado()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[19];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdocCreado.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numtotaldocu";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdocCreado.Total_doc_creado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombredCreado";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objdocCreado.Nom_doc_creado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@asuntodCreado";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objdocCreado.Asunto_doc_creado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@detalledCreadol";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].SqlValue = objdocCreado.Detalle_doc_creado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Usuario";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objdocCreado.Id_usuario;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@idProyecto";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objdocCreado.Id_proyecto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@numConsecu";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = objdocCreado.Num_consecutivo;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@documentoPDF";
                parParameter[8].SqlDbType = SqlDbType.VarBinary;
                parParameter[8].SqlValue = objdocCreado.Pdf_doc_creado;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@documentoWord";
                parParameter[9].SqlDbType = SqlDbType.VarBinary;
                parParameter[9].SqlValue = objdocCreado.Word_doc_creado;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@estatus";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 20;
                parParameter[10].SqlValue = objdocCreado.Estado_doc_creado;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@fecha";
                parParameter[11].SqlDbType = SqlDbType.DateTime;
                parParameter[11].SqlValue = objdocCreado.Fecha_doc_subido;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@idCliente";
                parParameter[12].SqlDbType = SqlDbType.Int;
                parParameter[12].SqlValue = objdocCreado.Id_cliente;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@periodo";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = objdocCreado.Periodo;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@numReferencia ";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = objdocCreado.Num_referencia_creado;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@habilitado";
                parParameter[15].SqlDbType = SqlDbType.Int;
                parParameter[15].SqlValue = objdocCreado.Habilitado;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@ModificadoPor";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = objdocCreado.ModificadoPor1;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@nombreRealWord";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = objdocCreado.NombreRealWord1;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@nombreRealPdf";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = objdocCreado.NombreRealPdf1;
                cnGneral.EjecutarSP(parParameter, "SPCrearDoc");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // actualizar documentos creados
        public void Actualizar_documento()
        {
            try
            {
                cnGneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[14];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objdocCreado.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numtotaldocu";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objdocCreado.Total_doc_creado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombredCreado";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objdocCreado.Nom_doc_creado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@asuntodCreado";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objdocCreado.Asunto_doc_creado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@detalledCreadol";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].SqlValue = objdocCreado.Detalle_doc_creado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@documentoPDF";
                parParameter[5].SqlDbType = SqlDbType.VarBinary;
                parParameter[5].SqlValue = objdocCreado.Pdf_doc_creado;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@documentoWord";
                parParameter[6].SqlDbType = SqlDbType.VarBinary;
                parParameter[6].SqlValue = objdocCreado.Word_doc_creado;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@estatus";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 20;
                parParameter[7].SqlValue = objdocCreado.Estado_doc_creado;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@fecha";
                parParameter[8].SqlDbType = SqlDbType.DateTime;
                parParameter[8].SqlValue = objdocCreado.Fecha_doc_subido;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@periodo";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = objdocCreado.Periodo;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@numReferencia ";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = objdocCreado.Num_referencia_creado;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@ModificadoPor";
                parParameter[11].SqlDbType = SqlDbType.Int;
                parParameter[11].SqlValue = objdocCreado.ModificadoPor1;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@nombreRealWord";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = objdocCreado.NombreRealWord1;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@nombreRealPdf";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = objdocCreado.NombreRealPdf1;
                cnGneral.EjecutarSP(parParameter, "SPCrearDoc");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Busqueda()
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
                parParameter[1].ParameterName = "@NumeroReferencia";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objdocCreado.Num_referencia_creado;
                tbldatos = cnGneral.RetornaTabla(parParameter, "SPBusquedas");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tbldatos;
        }
        public DataTable Busqueda2()
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
                parParameter[1].ParameterName = "@nombreDocumento";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objdocCreado.Nom_doc_creado;
                tbldatos = cnGneral.RetornaTabla(parParameter, "SPBusquedas");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tbldatos;
        }
    }
}
