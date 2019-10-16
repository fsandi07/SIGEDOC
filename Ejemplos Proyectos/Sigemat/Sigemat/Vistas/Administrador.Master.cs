using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigemat.Negocio;

namespace Sigemat
{
    public partial class Administrador : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LblNomUsu.Text = Usuario.GlonombreUsuario + " "+ Usuario.GloapellidoUsuario;
            this.Lbltime.Text = Usuario.GloIdentificacion;

            int valid = Usuario.GlotipoUsu; 

            if (valid == 0 || valid == 1)
            {
                Response.Redirect("LOGING.aspx");
            }
        }
    }
}