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
    public partial class ConsultarProyecto : System.Web.UI.Page
    {
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        // instancia para actualizar un proyecto
        SIGEDOC.Negocio.Proyectos proyecto = new SIGEDOC.Negocio.Proyectos();
        private ProyectoHelper proyectoHelper;
        private static int cCostos;
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
                this.pr.Nom_Per1 = "Consultar Proyecto";
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
        protected void GridProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalProyectos", "$('#ModalProyectos').modal();", true);
                cCostos = int.Parse(this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[1].Text);
                this.txtnombreProyecto.Text = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[2].Text;
                this.txtlicitacion.Text = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[3].Text;
                this.txtdetalleproyecto.Text = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[4].Text;
                this.DptCliente.SelectedValue = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[5].Text;
                this.dptestado.SelectedValue = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[6].Text.ToString();
                this.txtusuario.Text = this.GridProyectos.Rows[GridProyectos.SelectedIndex].Cells[9].Text;
                this.txtcentro_costos.Text = cCostos.ToString();
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        protected void btnActalizar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    this.proyecto.Centro_costos = cCostos;
                    this.proyecto.Nombre_Proyecto = this.txtnombreProyecto.Text;
                    this.proyecto.Numero_Licitacion = this.txtlicitacion.Text;
                    this.proyecto.Detalle_del_proyecto = this.txtdetalleproyecto.Text;
                    this.proyecto.Id_cliente = int.Parse(this.DptCliente.SelectedValue);
                    this.proyecto.Estado_Proyecto = this.dptestado.SelectedValue;
                    this.proyecto.Opc=3;
                    this.proyectoHelper = new ProyectoHelper(proyecto);
                    this.proyectoHelper.Actualizar_Proyecto();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }
            }
        }
        protected void GridProyectos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado;
                estado = (string)DataBinder.Eval(e.Row.DataItem, "estadoProyec");
                if (estado =="Ganado")
                {
                    e.Row.ForeColor = System.Drawing.Color.White;
                    e.Row.BackColor = System.Drawing.Color.Green;
                    e.Row.Font.Bold = true;
                }
                else if ((estado =="Perdido"))
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.Red;
                    e.Row.Font.Bold = true;
                }
            }
        }
        protected void DptnombreProtyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)gridPbusquedas.DataSource;
                this.proyecto.Nombre_Proyecto = DptnombreProtyecto.SelectedValue.ToString();
                this.proyecto.Opc = 2;
                this.proyectoHelper = new ProyectoHelper(proyecto);
                this.datos = new DataTable();
                gridPbusquedas.DataSource = this.proyectoHelper.Busqueda2();
                gridPbusquedas.DataBind();
            }
            catch (Exception ex)
            {
                this.lblcentrocostos.Text = ex.Message;
            }
        }
        protected void Dptcentrocostos_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)gridPbusquedas.DataSource;
                this.proyecto.Centro_costos = int.Parse(this.Dptcentrocostos.SelectedValue);
                this.proyecto.Opc = 1;
                this.proyectoHelper = new ProyectoHelper(proyecto);
                this.datos = new DataTable();
                gridPbusquedas.DataSource = this.proyectoHelper.Busqueda();
                gridPbusquedas.DataBind();
            }
            catch (Exception ex)
            {
                this.lblcentrocostos.Text = ex.Message;

            }
        }
    }
}