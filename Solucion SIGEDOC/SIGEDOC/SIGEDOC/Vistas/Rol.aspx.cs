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
                this.pr.Estado_rol = 1;
                this.pr.IdUsuario = Usuarios.GloIdUsuario;
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

                this.pr.Consultar_cliente = "Consultar Cliente";
                this.pr.Crear_cliente = "Crear Cliente";
                this.pr.Modificar_cliente = "Modificar Cliente";
                this.pr.Consultar_proyecto = "Consultar Proyecto";
                this.pr.Crear_proyecto ="Crear Proyecto";
                this.pr.Modificar_proyecto = "Modificar Proyecto";
                this.pr.Consultar_usuario = "Consultar Usuario";
                this.pr.Agreagr_usuario = "Agregar Usuario";
                this.pr.Modificar_usuario = "Modificar Usuario";
                this.pr.Consultar_documento = "Consultar Documentos Creados";
                this.pr.Crear_documento = "Crear Documento";
                this.pr.Modificar_documento = "Modificar Documento";
                this.pr.Subir_documento = "Subir Documento";
                this.pr.Consultar_documento_subido = "Consultar Documento Subido";
                this.pr.Modificar_documento_subido = "Modificar Documento Subido";
                this.pr.Consultar_rol = "Consultar Rol";
                this.pr.Crear_rol = "Crear Rol";
                this.pr.Modificar_rol = "Modificar Rol";
                this.pr.Bitacora = "Bitacora";
                this.pr.Reportes_auditoria = "Reporte de Auditoria";
                this.pr.Reportes_de_movimientos = "Reporte de Movimientos";
                this.pr.Reportes_de_proyectos = "Reportes de Proyectos";
                if (cbPermisos.Items[0].Selected == true)
                { this.pr.Opcconsultar_cliente= 1 ;
                    if (cbPermisos.Items[1].Selected == true)
                    {  this.pr.Opccrear_cliente = 1;
                        if (cbPermisos.Items[2].Selected == true)
                        { this.pr.Opcmodificar_cliente = 1;
                            if (cbPermisos.Items[3].Selected == true)
                            { this.pr.Opcconsultar_proyecto = 1;
                                if (cbPermisos.Items[4].Selected == true)
                                { this.pr.Opccrear_proyecto = 1;
                                    if (cbPermisos.Items[5].Selected == true)
                                    { this.pr.Opcmodificar_proyecto = 1;
                                        if (cbPermisos.Items[6].Selected == true)
                                        { this.pr.Opcconsultar_usuario = 1;
                                            if (cbPermisos.Items[7].Selected == true)
                                            { this.pr.Opccrear_usuario = 1;
                                                if (cbPermisos.Items[8].Selected == true)
                                                { this.pr.Opcmodificar_usuario = 1;
                                                    if (cbPermisos.Items[9].Selected == true)
                                                    { this.pr.Opcconsultar_doc_creado = 1;
                                                        if (cbPermisos.Items[10].Selected == true)
                                                        { this.pr.Opccrear_doc_creado = 1;
                                                            if (cbPermisos.Items[11].Selected == true)
                                                            { this.pr.Opcmodificar_doc_creado = 1;
                                                                if (cbPermisos.Items[12].Selected == true)
                                                                { this.pr.Opcconsultar_doc_subido = 1;
                                                                    if (cbPermisos.Items[13].Selected == true)
                                                                    { this.pr.Opccrear_doc_creado = 1;
                                                                        if (cbPermisos.Items[14].Selected == true)
                                                                        { this.pr.Opcmodificar_doc_subido = 1;
                                                                            if (cbPermisos.Items[15].Selected == true)
                                                                            { this.pr.Opcconsultar_rol = 1;
                                                                                if (cbPermisos.Items[16].Selected == true)
                                                                                { this.pr.Opccrear_rol = 1;
                                                                                    if (cbPermisos.Items[17].Selected == true)
                                                                                    { this.pr.Opcmodificar_rol = 1;
                                                                                        if (cbPermisos.Items[18].Selected == true)
                                                                                        { this.pr.Opcbitacora = 1;
                                                                                            if (cbPermisos.Items[19].Selected == true) 
                                                                                            { this.pr.Opccrear_repo_movi = 1;
                                                                                                if (cbPermisos.Items[20].Selected == true)
                                                                                                { this.pr.Opcconsultar_repo_audi = 1;
                                                                                                    if (cbPermisos.Items[21].Selected == true)
                                                                                                    { this.pr.Opcmodificar_repo_proye= 1;
                                                                                                    }
                                                                                                    else 
                                                                                                    { this.pr.Opcmodificar_repo_proye = 0;
                                                                                                    }
                                                                                                }
                                                                                                else 
                                                                                                { this.pr.Opcconsultar_repo_audi = 0;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            { this.pr.Opccrear_repo_movi = 0;
                                                                                            }
                                                                                        }
                                                                                        else 
                                                                                        { this.pr.Opcbitacora = 0;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    { this.pr.Opcmodificar_rol = 0;
                                                                                    }
                                                                                }
                                                                                else
                                                                                { this.pr.Opccrear_rol = 0;
                                                                                }
                                                                            }
                                                                            else 
                                                                            { this.pr.Opcconsultar_rol = 0;
                                                                            }
                                                                        }
                                                                        else
                                                                        { this.pr.Opcmodificar_doc_subido = 0;
                                                                        }
                                                                    }
                                                                    else 
                                                                    { this.pr.Opccrear_doc_creado = 0;
                                                                    }
                                                                }
                                                                else 
                                                                { this.pr.Opcconsultar_doc_subido = 0;
                                                                }                                                                                                                             
                                                            }
                                                            else 
                                                            { this.pr.Opcmodificar_doc_creado = 0;
                                                            }
                                                        }
                                                        else
                                                        { this.pr.Opccrear_doc_creado = 0;
                                                        }
                                                    }
                                                    else
                                                    { this.pr.Opcconsultar_doc_creado = 0;
                                                    }
                                                }
                                                else
                                                { this.pr.Opcmodificar_usuario = 0;
                                                }
                                            }
                                            else
                                            { this.pr.Opccrear_usuario = 0;
                                            }
                                        }
                                        else
                                        { this.pr.Opcconsultar_usuario = 0;
                                        }
                                    }
                                    else
                                    { this.pr.Opcmodificar_proyecto = 0;
                                    }
                                }
                                else
                                { this.pr.Opccrear_proyecto = 0;
                                }
                            }
                            else
                            { this.pr.Opcconsultar_proyecto = 0;
                            }
                        }
                        else
                        { this.pr.Opcmodificar_cliente = 0;
                        }
                    }
                    else
                    {
                        this.pr.Opccrear_cliente = 0;
                    }
                }
                else
                { this.pr.Opcconsultar_cliente = 0;
                }
                this.pr.IdRol = id_Rol;
                this.pr.IdUsuario = Usuarios.GloIdUsuario;
                this.pr.Opc = 1;                
                this.prh = new PermisosHelper(pr);
                this.prh.IngresaPermiso();
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