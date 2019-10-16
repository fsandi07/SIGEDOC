using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Sigemat.Negocio;

namespace Sigemat.Vistas
{
    public partial class Loging : System.Web.UI.Page
    {
        private Usuario usuario;
        private UsuarioHelper UsuarioHelper;
        private DataTable datos;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngreso_Click(object sender, EventArgs e)
        {
           

            try
            {
                this.usuario = new Usuario();

                this.usuario.IdentificacionUsuario = this.TxtIdenti.Text;
                this.usuario.Clave = this.TxtClave.Text;
                // uso de la opcion del proceso almacenado
                this.usuario.Opc = 1;
                this.UsuarioHelper = new UsuarioHelper(usuario);
                this.datos = new DataTable();
                this.datos = this.UsuarioHelper.ValidarUsuario();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];

                    Usuario.SetTipo(int.Parse(fila["idPerfil"].ToString())); 

                    if (int.Parse(fila["idPerfil"].ToString()) == 1)
                    {
                        Usuario.SetNombre(fila["nombre"].ToString());
                        Usuario.SetApellidos(fila["apellidos"].ToString());
                        Usuario.SetIdentificacion(fila["identificacion"].ToString());
                        Usuario.SetCorreo(fila["correoElectronico"].ToString());
                        Usuario.SetTipo(int.Parse(fila["idPerfil"].ToString()));
                        Usuario.SetTipo(int.Parse(fila["contacto"].ToString()));
                        Response.Redirect("InicioAdmin.aspx");

                    }
                    else if (int.Parse(fila["idPerfil"].ToString()) == 2)
                    {
                        Usuario.SetNombre(fila["nombre"].ToString());
                        Usuario.SetApellidos(fila["apellidos"].ToString());
                        Usuario.SetIdentificacion(fila["identificacion"].ToString());
                        Usuario.SetCorreo(fila["correoElectronico"].ToString());
                        Usuario.SetTipo(int.Parse(fila["idPerfil"].ToString()));
                        Usuario.SetTipo(int.Parse(fila["contacto"].ToString()));
                        Response.Redirect("InicioProfesor.aspx");
                    }
                    else if (int.Parse(fila["idPerfil"].ToString()) == 3)
                    {
                        Usuario.SetNombre(fila["nombre"].ToString());
                        Usuario.SetApellidos(fila["apellidos"].ToString());
                        Usuario.SetIdentificacion(fila["identificacion"].ToString());
                        Usuario.SetCorreo(fila["correoElectronico"].ToString());
                        Usuario.SetTipo(int.Parse(fila["idPerfil"].ToString())); ;
                        Usuario.SetTipo(int.Parse(fila["contacto"].ToString()));
                        Response.Redirect("InicioEstudiante.aspx");
                    }
                }

            }
            catch (Exception ex)
            {
                this.TxtIdenti.Text = ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

    }
    
}