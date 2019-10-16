using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigemat.Negocio;


namespace Sigemat.Vistas
{
    public partial class Estudiante : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Lblestudiante.Text = Usuario.GlonombreUsuario + " " + Usuario.GloapellidoUsuario;
            this.Lblinicio.Text = Usuario.GlonombreUsuario + " " + Usuario.GloapellidoUsuario;
            this.LblindenEstu.Text = Usuario.GloIdentificacion;

            int valid = Usuario.GlotipoUsu;

            if (valid == 0 || valid == 1)
            {
                Response.Redirect("LOGING.aspx");
            }
        }
    }
}