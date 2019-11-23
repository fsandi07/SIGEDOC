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
                this.pr.Crear_cliente = "Crear Cliente";
                this.pr.Consultar_cliente = "Consultar Cliente";
                this.pr.Crear_documento = "Crear Documento";
                this.pr.Subir_documento = "Subir Documento";
                this.pr.Consultar_documento = "Consultar Documento";
                this.pr.Usuarios = "Usuarios";
                this.pr.Roles = "Roles";
                this.pr.Bitacora = "Bitacora";
                this.pr.Reportes_auditoria = "Reportes de Auditoria";
                this.pr.Reportes_de_movimientos = "Reportes de Movimientos";
                this.pr.Reportes_de_proyectos = "Reportes de Proyectos";


                if (cbPermisos.Items[0].Selected == true)
                {
                    this.pr.Opccrear_cliente = 1;


                    if (cbPermisos.Items[1].Selected == true)
                    {

                        this.pr.Opcconsultar_cliente = 1;
                        if (cbPermisos.Items[2].Selected == true)
                        {

                            this.pr.Opccrear_documento = 1;
                            if (cbPermisos.Items[3].Selected == true)
                            {

                                this.pr.Opcsubir_documento = 1;
                                if (cbPermisos.Items[4].Selected == true)
                                {

                                    this.pr.Opcconsultar_documento = 1;
                                    if (cbPermisos.Items[5].Selected == true)
                                    {

                                        this.pr.Opcusuarios = 1;
                                        if (cbPermisos.Items[6].Selected == true)
                                        {

                                            this.pr.Opcroles = 1;
                                            if (cbPermisos.Items[7].Selected == true)
                                            {
                                                this.pr.Estado_rol = 1;
                                                this.pr.Opcbitacora = 1;
                                                if (cbPermisos.Items[8].Selected == true)
                                                {

                                                    this.pr.Opcreportes_auditoria = 1;
                                                    if (cbPermisos.Items[9].Selected == true)
                                                    {

                                                        this.pr.Opcreportes_de_movimientos = 1;
                                                        if (cbPermisos.Items[10].Selected == true)
                                                        {

                                                            this.pr.Opcreportes_de_proyectos = 1;
                                                        }
                                                        else
                                                        {

                                                            this.pr.Opcreportes_de_proyectos = 0;
                                                        }
                                                    }
                                                    else
                                                    {

                                                        this.pr.Opcreportes_de_movimientos = 0;
                                                    }

                                                }
                                                else
                                                {

                                                    this.pr.Opcreportes_auditoria = 0;
                                                }

                                            }
                                            else
                                            {

                                                this.pr.Opcbitacora = 0;
                                            }

                                        }
                                        else
                                        {

                                            this.pr.Opcroles = 0;
                                        }
                                    }

                                    else
                                    {

                                        this.pr.Opcusuarios = 0;
                                    }
                                }

                                else
                                {
                                    this.pr.Opcconsultar_documento = 0;
                                }

                            }

                            else
                            {

                                this.pr.Opcsubir_documento = 0;
                            }

                        }
                        else
                        {

                            this.pr.Opccrear_documento = 0;
                        }

                    }

                    else
                    {

                        this.pr.Opcconsultar_cliente = 0;
                    }

                }

                else
                {

                    this.pr.Opccrear_cliente = 0;

                }
                this.pr.Id_rol = id_Rol;
                this.pr.Opc = 1;
                this.prh = new PermisosHelper(pr);
                this.prh.IngresarPermisos();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }

            catch (Exception ex)
            {
                this.txtDetalleRol.Text = ex.Message;
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