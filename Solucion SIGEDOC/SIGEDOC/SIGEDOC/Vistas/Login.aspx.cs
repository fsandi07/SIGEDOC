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

    public partial class Login : System.Web.UI.Page
    {
        private Usuarios usuvalid;
        private UsuarioHelper usuvalidhelper;
        private DataTable datos;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuvalid = new Usuarios();
                this.usuvalid.Nicname_usuario = this.TxtIdenti.Text;
                this.usuvalid.Clave_usuario = this.TxtClave.Text;
                this.usuvalid.Opc = 1;
                this.usuvalidhelper = new UsuarioHelper(usuvalid);
                this.datos = new DataTable();
                this.datos = this.usuvalidhelper.Validar_Usuario();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];

                    if (int.Parse(fila["estadoUsu"].ToString()) == 1)
                    {

                        Usuarios.SetIdRol(int.Parse(fila["idRol"].ToString()));
                        Usuarios.SetIdUsuario(fila["cedulaUsu"].ToString());
                        Usuarios.SetNicName(fila["nicknameUsu"].ToString());
                        Usuarios.SetNombre(fila["nombreUsu"].ToString());
                        Usuarios.SetApellidos(fila["apellidosUsu"].ToString());
                        Session["Idusuario"] = Usuarios.GloIdUsuario;
                        Response.Redirect("Menu.aspx");
                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorInhabilitado", "mensajeErrorInhabilitado('" + "" + "');", true);

                    }


                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }



        }
    }
}