using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEDOC.Vistas
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblfecha_hora.Text = DateTime.Now.ToString("hh:mm");
            this.lblfecha.Text = DateTime.Now.ToString("dd/MM/yyy");
        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}