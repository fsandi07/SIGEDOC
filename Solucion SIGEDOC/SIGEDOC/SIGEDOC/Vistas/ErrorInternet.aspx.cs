using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;


namespace SIGEDOC.Vistas
{
    public partial class ErrorInternet : System.Web.UI.Page
    {         
        
        protected void Page_Load(object sender, EventArgs e)
        {        
            Session["Idusuario"] = null;
        }
    }
}