using System;
using System.Web.UI;
using SIGEDOC.Negocio;
using System.Data;

namespace SIGEDOC.Vistas
{
    public partial class OlvidoClave : System.Web.UI.Page
    {
        private EnviosCorreo c;
        private Usuarios usuarios;
        private DataTable datos;
        private UsuarioHelper UsuarioHelper;

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void EnviarCorreos()
        {
            this.c = new EnviosCorreo();
            this.c.Enviar_Correo(Usuarios.GloCorreo, "Solicitud Clave SIGEDOC",
               "<a href='https://imgbb.com/'><img src='https://i.ibb.co/s6P7VLC/PQS.png' alt='PQS' border='0'></a>" + "<br>" + "<br>" + "Estimado/a:" + " " + Usuarios.GloUsuario + " " +
               Usuarios.GloApellidos + " <br>" + "Usted ha sido registrado/a para el ingreso al Sistema SIGEDOC-PQS." + "<br>" + "Sus credenciales para ingresar son: " +
               "<br>" + "Usuario:  " + Usuarios.GloNicname + "<br>" + " Contraseña:  " + Usuarios.GloClave + "<br>" + "Le Sugerimos eliminar este correo para evitar el robo de su información." +
               "<br>" + "Este es un mensaje autogenerado,por favor no responder.");
        }
        protected void BtnEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarios = new Usuarios();
                this.usuarios.Nicname_usuario = this.TxtIdenti.Text;
                this.usuarios.Correo_usuario = this.TxtEmail.Text;
                this.usuarios.Opc = 1;
                this.UsuarioHelper = new UsuarioHelper(usuarios);
                this.datos = new DataTable();
                this.datos = this.UsuarioHelper.Validar_Usuario();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    Usuarios.SetCorreo(fila["correoElectUsu"].ToString());
                    Usuarios.SetNicName(fila["nicknameUsu"].ToString());
                    if (this.TxtEmail.Text == Usuarios.GloCorreo && this.TxtIdenti.Text == Usuarios.GloNicname)
                    {
                        Usuarios.SetNombre(fila["nombreUsu"].ToString());
                        Usuarios.SetNicName(fila["nicknameUsu"].ToString());
                        Usuarios.SetApellidos(fila["apellidosUsu"].ToString());
                        Usuarios.SetCorreo(fila["correoElectUsu"].ToString());
                        Usuarios.SetClave(fila["claveUsu"].ToString());
                        EnviarCorreos();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                    }
                }
            }
            catch (Exception ex)
            {
                // this.TxtIdenti.Text = ex.Message;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        protected void BtnCancela_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}