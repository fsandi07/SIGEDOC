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
    public partial class Reporte : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
             RpteProy  rpt = new RpteProy();
             rpt.SetParameterValue("@opcion", 3);
             RptProyectos.ReportSource = rpt;


        }
      
    }
}