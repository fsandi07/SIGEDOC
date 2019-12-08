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
     
        protected void Page_Load(object sender, EventArgs e)
        {
            RptMoviminetos rpt = new RptMoviminetos();
            rpt.SetParameterValue("@opcion", 2);
            RptMovimientos.ReportSource = rpt;

        }
    }
}