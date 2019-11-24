using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;
using System.Text;

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
            //Num_Estado_Permiso();

            //if (validar == 0 || Session["Idusuario"] == null)
            //{

            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
            //}
            //else
            //{

            //}
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
            if (this.dptestado.SelectedValue == "2")
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
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
               
            //     aux=e.Row.Cells[0].Text = "<i class='fas fa-edit'></i>"+e.Row.Cells[0].Text; 
                  
            //        e.Row.Font.Bold = true;
            

            //}
        }
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
                    this.usu.Clave_usuario = CrearPassword(8);
                    this.usu.Estado_usuarios = this.dptestado.SelectedValue;
                    this.usu.Contacto_usuario = int.Parse(this.txtcontacto.Text);
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
    }
}