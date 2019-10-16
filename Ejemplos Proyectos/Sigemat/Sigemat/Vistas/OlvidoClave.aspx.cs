using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigemat.Negocio;
using System.Data;

namespace Sigemat.Vistas
{
    public partial class OvidoClave : System.Web.UI.Page
    {
        private EnvioCorreo c;
        private Usuario usuario;
        private DataTable datos;
        private UsuarioHelper UsuarioHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnvio_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.usuario = new Usuario();

                this.usuario.IdentificacionUsuario = this.TxtIdenti.Text;
                this.usuario.CorreoElectronico = this.TxtCorreoE.Text;
                // uso de la opcion del proceso almacenado
                this.usuario.Opc = 2;
                this.UsuarioHelper = new UsuarioHelper(usuario);
                this.datos = new DataTable();
                this.datos = this.UsuarioHelper.ValidarUsuario();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];

                    
                    Usuario.SetCorreo(fila["correoElectronico"].ToString());

                    if (fila["correoElectronico"].ToString() == this.LblCorreoE.Text)
                    {
                        Usuario.SetNombre(fila["nombre"].ToString());
                        Usuario.SetApellidos(fila["apellidos"].ToString());
                        Usuario.SetIdentificacion(fila["identificacion"].ToString());
                        Usuario.SetCorreo(fila["correoElectronico"].ToString());
                        Usuario.SetClave(fila["clave"].ToString());
                        EnviarCorreos();
                        Response.Redirect("Loging.aspx");

                    }                                      
                }
            }
            catch (Exception ex)
            {
                //this.TxtIdenti.Text = ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    

        public void EnviarCorreos()
        {
            this.c = new EnvioCorreo();
            this.c.Enviar_Correo(Usuario.GlocorreoUsuario, "Solicitud Clave",
               "Estimado/a:"+ " "+ Usuario.GlonombreUsuario + " "+Usuario.GloapellidoUsuario +" "+"Usted ha solicitado el envío de su contraseña para el ingreso a SIGEMAT Matricula,"
               + " " +"La cual es: " + " " + Usuario.Gloclave + " "+"le sugerimos por favor Eliminar este mensaje para evitar el robo de información");

        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Loging.aspx");
        }
    }
}