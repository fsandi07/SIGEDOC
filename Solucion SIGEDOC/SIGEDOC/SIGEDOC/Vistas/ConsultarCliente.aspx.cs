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
    public partial class ConsultarCliente : System.Web.UI.Page
    {
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        // variable global para capturar id de cliente y poderlo actualizar
        private static int idcliente;

        // instacias para la actualizacion de nuevos clientes 
        SIGEDOC.Negocio.Clientes cl = new SIGEDOC.Negocio.Clientes();
        private ClienteHelper clh;

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
                this.pr.Nom_Per1 = "Consultar Cliente";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalCliente", "$('#ModalCliente').modal();", true);
            idcliente= int.Parse(this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[1].Text);
            this.txtnombre.Text= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[2].Text;
            this.txtencargado.Text= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[3].Text;
            this.txttelefono.Text= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[4].Text;
            this.txtcorreo.Text= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[5].Text;
            this.txtdetalle.Text= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[6].Text;
            this.dptestado.SelectedValue= this.GridCliente.Rows[GridCliente.SelectedIndex].Cells[7].Text;
            if (this.dptestado.SelectedValue == "Inactivo")
            {
                this.dptestado.SelectedValue = "2";
                this.dptestado.Items.FindByText("Inactivo").Selected = true;
            }
            else
            {
                this.dptestado.SelectedValue = "1";
                this.dptestado.Items.FindByText("Activo").Selected = true;

            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    this.cl.Nombre_cliente = this.txtnombre.Text;
                    this.cl.Nombre_de_Contacto = this.txtencargado.Text;
                    this.cl.Idcliente = idcliente;
                    this.cl.Telefono_contacto = int.Parse(this.txttelefono.Text);
                    this.cl.Correo_cliente = this.txtcorreo.Text;
                    this.cl.Detalle_cliente = this.txtdetalle.Text;
                    this.cl.Estado_cliente = this.dptestado.SelectedValue;
                    this.cl.Opc = 3;
                    this.clh = new ClienteHelper(cl);
                    this.clh.Actualizar_Cliente();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
               

                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }


            }

        }

        protected void GridCliente_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado;
                estado = (string)DataBinder.Eval(e.Row.DataItem,"estadoCliente");
                if (estado =="2")
                {
                    e.Row.Cells[7].Text = "Inactivo";
                    //e.Row.ForeColor = System.Drawing.Color.Red;
                    e.Row.BackColor = System.Drawing.Color.Yellow;
                    e.Row.Font.Bold = true;
                }
                else
                {

                    e.Row.Cells[7].Text = "Activo";

                }

            }



        }
    }
}