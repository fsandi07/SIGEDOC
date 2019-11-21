using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;

namespace SIGEDOC.Vistas
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.lblfecha.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.LblIdentUsu.Text = Usuarios.GloIdUsuario;
            this.LblNomUsu.Text = Usuarios.GloUsuario +" " + Usuarios.GloApellidos;
            string  valid = Usuarios.GloIdUsuario;

            if (valid == "" || Session["Idusuario"] == null)
            {
                Response.Redirect("Error.aspx");

            }
                       
        }
        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnusuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarUsuarios.aspx");
        }

        protected void BtnRpt_audi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte.aspx");
        }

        protected void Btnrpt_movi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Movimientos.aspx");
        }

        protected void btn_modicar_usu_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarUsuario.aspx");
        }
    }
}