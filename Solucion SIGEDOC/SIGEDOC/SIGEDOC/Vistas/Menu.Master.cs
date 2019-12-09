using System;
using System.Web.UI;
using SIGEDOC.Negocio;
namespace SIGEDOC.Vistas
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        SIGEDOC.Negocio.MoviBitacora moviBita = new SIGEDOC.Negocio.MoviBitacora();
        private MoviBitacoraHelper moviHelp;
        SIGEDOC.Negocio.Usuarios usu = new SIGEDOC.Negocio.Usuarios();
        private UsuarioHelper usuh;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblfecha.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.LblIdentUsu.Text = Usuarios.GloIdUsuario;
            this.LblNomUsu.Text = Usuarios.GloUsuario + " " + Usuarios.GloApellidos;
            this.txtnombre.Text = Usuarios.GloUsuario;
            this.txtapellido.Text = Usuarios.GloApellidos;
            this.txtcedula.Text = Usuarios.GloIdUsuario;
            this.txtnikcname.Text = Usuarios.GloNicname;
            this.txtcontacto.Text = Usuarios.GloContacto.ToString();
            this.txtcorreo.Text = Usuarios.GloCorreo;
            this.LblNombre.Text = Usuarios.GloUsuario;
            this.LblApellidos.Text = Usuarios.GloApellidos;
            this.LblCedula.Text = Usuarios.GloIdUsuario;
            this.LblNick.Text = Usuarios.GloNicname;
            this.LblCorreo.Text = Usuarios.GloCorreo;
            this.LblContacto.Text = Usuarios.GloContacto.ToString();
            bool Internet = ValidarIntenrt();
            if (Internet)
            {
                //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SI HAY INTERNET');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera2", "mensajeEspera2('" + "" + "');", true);
            }
        }
        public bool ValidarIntenrt()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");

                return true;
            }
            catch
            {
                return false;
            }
        }
        protected void insertarMovimiento()
        {
            try
            {
                this.moviBita.IdUsuario = Usuarios.GloIdUsuario;
                this.moviBita.Accion = "Salida del Sistema de:" + Usuarios.GloUsuario + "" + Usuarios.GloApellidos;
                this.moviBita.Fecha = DateTime.Now;
                this.moviBita.Tipo = "1";
                this.moviBita.Opc = 1;
                this.moviHelp = new MoviBitacoraHelper(moviBita);
                this.moviHelp.Agregar_Movimiento();
                this.txtnombre.Text = Usuarios.GloUsuario;
                this.txtapellido.Text = Usuarios.GloApellidos;
                this.txtcedula.Text = Usuarios.GloIdUsuario;
                this.txtnikcname.Text = Usuarios.GloNicname;
                this.txtcontacto.Text = Usuarios.GloContacto.ToString();
                this.txtcorreo.Text = Usuarios.GloCorreo;
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
        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtClave1.Text == "" || this.txtClaveConfirma.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError1", "mensajeError1('" + "" + "');", true);
            }
            else if (this.txtClave1.Text != this.txtClaveConfirma.Text)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError2", "mensajeError2('" + "" + "');", true);
            }
            else
            {
                try
                {
                    this.usu.Nombre_usuario = this.txtnombre.Text;
                    this.usu.Apellidos = this.txtapellido.Text;
                    this.usu.Cedula_usuario = Usuarios.GloIdUsuario;
                    this.usu.Correo_usuario = this.txtcorreo.Text;
                    this.usu.Contacto_usuario = int.Parse(this.txtcontacto.Text);
                    this.usu.Idusuario = Usuarios.GloIdUsuario;
                    this.usu.Clave_usuario = this.txtClave1.Text;
                    this.usu.Opc = 1;
                    this.usuh = new UsuarioHelper(usu);
                    this.usuh.Actualizar_Usuario_Personal();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }
            }
        }
    }
}