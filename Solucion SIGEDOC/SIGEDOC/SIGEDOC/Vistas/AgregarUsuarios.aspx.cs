using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;
// libreria agregada.
using System.Text;

namespace SIGEDOC.Vistas
{
    public partial class AgregarUsuarios : System.Web.UI.Page
    {
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();        
        private PermisosHelper prh;
        private DataTable datos;
        private EnviosCorreo c;
        private static int validar;
        // instancia de clases 
        SIGEDOC.Negocio.Usuarios usu = new SIGEDOC.Negocio.Usuarios();
        private UsuarioHelper usuh;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Num_Estado_Permiso();

            //if (validar == 0 || Session["Idusuario"] == null)
            //{

            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
            //}
            //else
            //{

            //}
        }
        public void Limpiar()
        {
            this.txtnombre.Text = null;
            this.txtidentifiaccion.Text = null;
            this.txtapellido.Text = null;
            this.txtcontacto.Text = null;
            this.txtnickname.Text = null;
            this.dptrol.SelectedValue = null;
            this.txtcorreo.Text = null;
        }

        private void Num_Estado_Permiso()
        {
            try
            {
                this.pr.Opc = 1;
                this.pr.IdRol = Usuarios.GlotIdRol;
                this.pr.Nom_Per1 = "Usuarios";
                this.prh = new PermisosHelper(pr);
                this.datos = new DataTable();
                this.datos = this.prh.Estado_Permisos();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    validar = int.Parse(fila["estadoPermiso"].ToString());
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        // metodo para crear las claves de forma aleatoria;
        public string CrearPassword(int longitud)
        {
            string caracteres = "auq357bhai87634db09747uFYBF348579021RDSRH1123JKLCTH";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }
        public void EnviarCorreos()
        {
            this.c = new EnviosCorreo();
            this.c.Enviar_Correo(this.usu.Correo_usuario, "Registro SiGEDOC",
               "<a href='https://imgbb.com/'><img src='https://i.ibb.co/s6P7VLC/PQS.png' alt='PQS' border='0'></a>" + "<br>"+"<br>"+ "Estimado/a:" + " "+ this.usu.Nombre_usuario + " " + this.usu.Apellidos + " <br>" + "Usted ha sido registrado/a para el ingreso al Sistema SIGEDOC-PQS." + "<br>" +
               "Sus credenciales para ingresar son: " + "<br>"+ "Usuario:  " + this.usu.Nicname_usuario +"<br>" +" Contraseña:  " + this.usu.Clave_usuario + "<br>" +
               "Le Sugerimos cambiar su clave cuando ingrese al sistema,Consulte el manual antes de ingresar." + "<br>"+"Este es un correo Autogenerado,Por fabor no responder." );
        }
        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.usu.Cedula_usuario = this.txtidentifiaccion.Text;
                this.usu.Nombre_usuario = this.txtnombre.Text;
                this.usu.Apellidos = this.txtapellido.Text;
                this.usu.Nicname_usuario = this.txtnickname.Text;
                this.usu.Rol_usuario = int.Parse(this.dptrol.SelectedValue);
                this.usu.Correo_usuario = this.txtcorreo.Text;
                this.usu.Clave_usuario = CrearPassword(8);
                this.usu.Estado_usuarios = 1;
                this.usu.Contacto_usuario = int.Parse(this.txtcontacto.Text);
                this.usu.Idusuario = Usuarios.GloIdUsuario;
                this.usu.Opc = 1;
                this.usuh = new UsuarioHelper(usu);
                this.usuh.Agregar_Usuarios();
                EnviarCorreos();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                Limpiar();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }
        }
    }
}