using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SIGEDOC.Vistas
{
    public partial class Movimientos : System.Web.UI.Page
    {
        String vCadenaConexion = @"Data Source = den1.mssql7.gear.host; initial catalog = sigedoc; user id = sigedoc; password = Ip4805Xtg~2-";
     
        SqlConnection vConexion;
        SqlDataAdapter vDataAdapter;
        DataTable vDT;
        protected void Page_Load(object sender, EventArgs e)
        {
            String vSQL;
            vDT = new DataTable();

            vSQL = "SELECT * FROM TbProyecto";


            rptMovimientos rpt = new rptMovimientos();

            vDT = EjecutarSELECT(vSQL);

            rpt.SetDataSource(vDT);

            RptMovimientos.ReportSource = rpt;
        }
        private void ConectarBD()
        {
            try
            {
                vConexion = new SqlConnection(vCadenaConexion);
                vConexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DesconectarBD()
        {
            try
            {
                vConexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable EjecutarSELECT(String pSQL)
        {
            vDT = new DataTable();

            ConectarBD();

            vDataAdapter = new SqlDataAdapter(pSQL, vConexion);
            vDataAdapter.Fill(vDT);

            DesconectarBD();

            return vDT;
        }
    }
}