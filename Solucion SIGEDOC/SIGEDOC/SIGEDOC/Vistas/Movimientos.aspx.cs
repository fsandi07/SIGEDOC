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
        String vCadenaConexion = @"Data Source=SQL5041.site4now.net;Initial Catalog=DB_A4DE45_SIGEDOC;User Id=DB_A4DE45_SIGEDOC_admin;Password=sigedoc2019;";
        SqlConnection vConexion;
        SqlDataAdapter vDataAdapter;
        DataTable vDT;
        protected void Page_Load(object sender, EventArgs e)
        {
            String vSQL;
            vDT = new DataTable();

            vSQL = "select * from tbbitacora where tipo=2";


            RptMovimientos  rpt = new RptMovimientos();

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