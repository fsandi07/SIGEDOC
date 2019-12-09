using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;
namespace SIGEDOC.Vistas
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {   // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        // instacia de calse y heper para modificar usuarios.
        SIGEDOC.Negocio.Usuarios usu = new SIGEDOC.Negocio.Usuarios();
        private UsuarioHelper usuh;
        protected void Page_Load(object sender, EventArgs e)
        {
            Num_Estado_Permiso();

            if (validar == 0 || Session["Idusuario"] == null)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
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
                this.pr.IdRol = Usuarios.GlotIdRol;
                this.pr.Nom_Per1 = "";
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
        protected void GridUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalUsuario", "$('#ModalUsuario').modal();", true);
            this.txtcedula.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[1].Text;
            this.txtnombre.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[2].Text;
            this.txtapellido.Text= this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[3].Text;
            this.txtnikcname.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[4].Text;
            this.txtcorreo.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[5].Text;
            this.dptrol.SelectedValue = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[7].Text;
            this.dptestado.SelectedValue = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[8].Text;
            if (this.dptestado.SelectedValue ==2.ToString())
            {
                this.dptestado.Items.FindByText("Inactivo").Selected = true;
            }
            else
            {
                this.dptestado.Items.FindByText("Activo").Selected = true;

            }
            this.txtcontacto.Text = int.Parse(this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[9].Text).ToString();
        }
        protected void GridUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int estado;
                estado = (int)DataBinder.Eval(e.Row.DataItem,"estadoUsu");
                if (estado==2)
                {
                    e.Row.BackColor = System.Drawing.Color.Yellow;
                    e.Row.Font.Bold = true;
                }
            }
        }
        protected void btningresar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    this.usu.Cedula_usuario = this.txtcedula.Text;
                    this.usu.Nombre_usuario = this.txtnombre.Text;
                    this.usu.Apellidos = this.txtapellido.Text;
                    this.usu.Nicname_usuario = this.txtnikcname.Text;
                    this.usu.Rol_usuario = int.Parse(this.dptrol.SelectedValue);
                    this.usu.Correo_usuario = this.txtcorreo.Text;
                    this.usu.Estado_usuarios = int.Parse(this.dptestado.SelectedValue);
                    this.usu.Contacto_usuario = int.Parse(this.txtcontacto.Text);
                    this.usu.Idusuario = Usuarios.GloIdUsuario;
                    this.usu.Opc = 3;
                    this.usuh = new UsuarioHelper(usu);
                    this.usuh.Actualizar_Usuario();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }
            }
        }
        protected void DptBuscarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)GridBusquedaUsuarios.DataSource;
                this.usu.Nombre_usuario = DptBuscarUsuario.SelectedValue.ToString();
                this.usu.Opc = 4;
                this.usuh = new UsuarioHelper(usu);
                this.datos = new DataTable();
                GridBusquedaUsuarios.DataSource = this.usuh.Busqueda();
                GridBusquedaUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                this.lblbuscarUsuario.Text = ex.Message;

            }
        }
        protected void Dptbuscar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)GridBusquedaUsuarios.DataSource;
                this.usu.Estado_usuarios = int.Parse(Dptbuscar2.SelectedValue);
                this.usu.Opc = 5;
                this.usuh = new UsuarioHelper(usu);
                this.datos = new DataTable();
                GridBusquedaUsuarios.DataSource = this.usuh.Busqueda2();
                GridBusquedaUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                this.lblbuscarUsuario.Text = ex.Message;
            }
        }
    }
}