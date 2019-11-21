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
    public partial class Rol : System.Web.UI.Page
    {
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int id_Rol;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Insert_Rol();
            Insertar_Permisos();
        }
        
        private void Insert_Rol()
        {
            try
            {
                this.pr.Nombre_rol = this.txtNombreRol.Text;
                this.pr.Detalle_rol = this.txtDetalleRol.Text;
                this.pr.Opc = 1;
                this.prh = new PermisosHelper(pr);
                this.prh.IngresarRoles();
            }

            catch (Exception ex)
            {
                this.txtNombreRol.Text = ex.Message;
            }
        }
       
        private void Insertar_Permisos()
        {
            try
            {
                Num_IdRol();
                this.pr.Id_rol = id_Rol;
                this.pr.Opc = 1;
                this.prh = new PermisosHelper(pr);
                this.prh.IngresarPermisos();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

                for (int i = 0; i < cbPermisos.Items.Count; i++)
                {
                    if (cbPermisos.Items[i].Selected == true)
                    {
                        Num_IdRol();
                        this.pr.Id_rol = id_Rol;
                        this.pr.Crear_cliente = "Crear Cliente";
                        this.pr.Opccrear_cliente = int.Parse(cbPermisos.Items[0].Value.ToString());
                        this.pr.Consultar_cliente = cbPermisos.Items[1].Text;
                        this.pr.Opcconsultar_cliente = int.Parse(cbPermisos.Items[1].Value.ToString());
                        this.pr.Crear_documento = cbPermisos.Items[2].Text;
                        this.pr.Opccrear_documento = int.Parse(cbPermisos.Items[2].Value.ToString());
                        this.pr.Subir_documento = cbPermisos.Items[3].Text;
                        this.pr.Opcsubir_documento = int.Parse(cbPermisos.Items[3].Value.ToString());
                        this.pr.Consultar_documento = cbPermisos.Items[4].Text;
                        this.pr.Opcconsultar_documento = int.Parse(cbPermisos.Items[4].Value.ToString());
                        this.pr.Usuarios = cbPermisos.Items[5].Text;
                        this.pr.Opcusuarios = int.Parse(cbPermisos.Items[5].Value.ToString());
                        this.pr.Roles = cbPermisos.Items[6].Text;
                        this.pr.Opcroles = int.Parse(cbPermisos.Items[6].Value.ToString());
                        this.pr.Bitacora = cbPermisos.Items[7].Text;
                        this.pr.Opcbitacora = int.Parse(cbPermisos.Items[7].Value.ToString());
                        this.pr.Reportes_auditoria = cbPermisos.Items[8].Text;
                        this.pr.Opcreportes_auditoria = int.Parse(cbPermisos.Items[8].Value.ToString());
                        this.pr.Reportes_de_movimientos = cbPermisos.Items[9].Text;
                        this.pr.Opcreportes_de_movimientos = int.Parse(cbPermisos.Items[9].Value.ToString());
                        this.pr.Reportes_de_proyectos = cbPermisos.Items[10].Text;
                        this.pr.Opcreportes_de_proyectos = int.Parse(cbPermisos.Items[10].Value.ToString());
                        this.pr.Opc = 1;
                        this.prh = new PermisosHelper(pr);
                        this.prh.IngresarPermisos();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

                    }
                    else
                    {
                        Num_IdRol();
                        this.pr.Id_rol = id_Rol;
                        this.pr.Crear_cliente = "Crear Cliente";
                        this.pr.Opccrear_cliente = 0;
                        this.pr.Consultar_cliente = cbPermisos.Items[1].Text;
                        this.pr.Opcconsultar_cliente = int.Parse(cbPermisos.Items[1].Value.ToString());
                        this.pr.Crear_documento = cbPermisos.Items[2].Text;
                        this.pr.Opccrear_documento = int.Parse(cbPermisos.Items[2].Value.ToString());
                        this.pr.Subir_documento = cbPermisos.Items[3].Text;
                        this.pr.Opcsubir_documento = int.Parse(cbPermisos.Items[3].Value.ToString());
                        this.pr.Consultar_documento = cbPermisos.Items[4].Text;
                        this.pr.Opcconsultar_documento = int.Parse(cbPermisos.Items[4].Value.ToString());
                        this.pr.Usuarios = cbPermisos.Items[5].Text;
                        this.pr.Opcusuarios = int.Parse(cbPermisos.Items[5].Value.ToString());
                        this.pr.Roles = cbPermisos.Items[6].Text;
                        this.pr.Opcroles = int.Parse(cbPermisos.Items[6].Value.ToString());
                        this.pr.Bitacora = cbPermisos.Items[7].Text;
                        this.pr.Opcbitacora = int.Parse(cbPermisos.Items[7].Value.ToString());
                        this.pr.Reportes_auditoria = cbPermisos.Items[8].Text;
                        this.pr.Opcreportes_auditoria = int.Parse(cbPermisos.Items[8].Value.ToString());
                        this.pr.Reportes_de_movimientos = cbPermisos.Items[9].Text;
                        this.pr.Opcreportes_de_movimientos = int.Parse(cbPermisos.Items[9].Value.ToString());
                        this.pr.Reportes_de_proyectos = cbPermisos.Items[10].Text;
                        this.pr.Opcreportes_de_proyectos = int.Parse(cbPermisos.Items[10].Value.ToString());
                        this.pr.Opc = 1;
                        this.prh = new PermisosHelper(pr);
                        this.prh.IngresarPermisos();

                    }

                }


            }

            catch (Exception ex)
            {
                //this.txtDescripcion.Text = ex.Message;
            }
        }
        private void Num_IdRol()
        {
            try
            {
                this.pr.Opc = 1;
                this.prh = new PermisosHelper(pr);
                this.datos = new DataTable();
                this.datos = this.prh.Numero_Rol();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    id_Rol = int.Parse(fila["id_rol"].ToString());
                }
            }
            catch (Exception ex)
            {
                this.txtNombreRol.Text = ex.Message;
            }
        }




    }
}