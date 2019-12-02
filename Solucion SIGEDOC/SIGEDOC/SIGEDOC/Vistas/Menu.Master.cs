using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;

namespace SIGEDOC.Vistas
{
    public partial class Menu : System.Web.UI.MasterPage
    {

        
        SIGEDOC.Negocio.MoviBitacora moviBita = new SIGEDOC.Negocio.MoviBitacora();
        private MoviBitacoraHelper moviHelp;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblfecha.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.LblIdentUsu.Text = Usuarios.GloIdUsuario;
            this.LblNomUsu.Text = Usuarios.GloUsuario + " " + Usuarios.GloApellidos;
        }
        protected void insertarMovimiento()
        {
            try
            {
                this.moviBita.IdUsuario = Usuarios.GloIdUsuario;
                this.moviBita.Accion = "Salida del Sistema de:" + Usuarios.GloUsuario + "" + Usuarios.GloApellidos;
                this.moviBita.Fecha = DateTime.Now;
                this.moviBita.Opc = 1;
                this.moviHelp = new MoviBitacoraHelper(moviBita);
                this.moviHelp.Agregar_Movimiento();

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            insertarMovimiento();        
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

        protected void btnModificarRoles_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarRol.aspx");
        }

        protected void Btnagregarrol_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rol.aspx");
        }
    }
}