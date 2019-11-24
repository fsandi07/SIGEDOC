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
    public partial class CrearProyecto : System.Web.UI.Page
    { 
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        // instacias para la insercion de nuevos clientes 
        SIGEDOC.Negocio.Proyectos pry = new SIGEDOC.Negocio.Proyectos();
        private ProyectoHelper pryh;
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

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.pry.Nombre_Proyecto = this.txtnombreproye.Text;
                this.pry.Numero_Licitacion = this.txtLicitacion.Text;
                this.pry.Id_cliente = int.Parse(this.DptCliente.SelectedValue.ToString());
                this.pry.Detalle_del_proyecto = this.txtDescripcion.Text;
                this.pry.Fecha_Proyecto = DateTime.Today;
                this.pry.Estado_Proyecto = this.dptestado.SelectedValue.ToString();
                this.pry.Usuario = Usuarios.GloIdUsuario;
                this.pry.Status_proyecto = "1";
                this.pry.Opc = 1;
                this.pryh = new ProyectoHelper(pry);
                this.pryh.Agregar_Proyecto();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }
        }
    }
}