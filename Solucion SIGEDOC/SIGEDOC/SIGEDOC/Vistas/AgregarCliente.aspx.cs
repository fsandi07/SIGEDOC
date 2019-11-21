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
    public partial class AgregarCliente : System.Web.UI.Page
    {
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;

        protected void Page_Load(object sender, EventArgs e)
        {
            Num_Estado_Permiso();

            if (validar == 0 || Session["Idusuario"] == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorIngreso", "mensajeErrorIngreso('" + "Contactar al administrador" + "');", true);
                //Response.Redirect("Menu.aspx");
            }
            else
            {

            }
        }

        private void Num_Estado_Permiso()
        {
            try
            {
                this.pr.Opc = 1;
                this.pr.Id_rol = Usuarios.GlotIdRol;
                this.pr.Nombre_permiso = "Consultar Cliente";
                this.prh = new PermisosHelper(pr);
                this.datos = new DataTable();
                this.datos = this.prh.Estado_Permisos();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    validar = int.Parse(fila["IdRol"].ToString());
                }
            }
            catch (Exception ex)
            {
                //this.txtNombreRol.Text = ex.Message;
            }
          


        }
                     
    }

}