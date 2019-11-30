using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;
// librerias agregadas 
using System.Diagnostics;
using System.IO;

namespace SIGEDOC.Vistas
{
    public partial class ConsultarDocumentos : System.Web.UI.Page
    {
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;

        private static int ccosto;

        // instacia de clase 
        SIGEDOC.Negocio.CrearDocumento crearDocumento = new SIGEDOC.Negocio.CrearDocumento();
        private CrearDocHelper docHelper;


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
                this.pr.Nom_Per1 = "Consultar Documento";
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void GridDocumento_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado;
                estado = (string)DataBinder.Eval(e.Row.DataItem, "estatus");
                if (estado == "En proceso")
                {
                 
                    //e.Row.BackColor = System.Drawing.Color.Yellow;
                    //e.Row.Font.Bold = true;
                }
                else if (estado == "Ganado")
                {

                    e.Row.BackColor = System.Drawing.Color.Green;

                }
                else if (estado == "Perdido")
                {

                    e.Row.BackColor = System.Drawing.Color.Red;

                }
                //e.Row.Cells[4].Text = "<i size='5xp' style='color:black' class='far fa-file-pdf'></i>";
                //e.Row.Cells[5].Text = "<i class='fas fa-file - alt'></i>";


            }
        }

        protected void GridDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentos", "$('#ModalDocumentos').modal();", true);

            ccosto = int.Parse(this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[9].Text);
        }

        protected void btnWord_Click(object sender, EventArgs e)
        {
            try
            {
                //this.crearDocumento.Id_proyecto = ccosto;              
    
                //this.crearDocumento.Opc = 4;
                //this.docHelper = new CrearDocHelper(crearDocumento);
                //this.datos = new DataTable();
                //this.datos = this.docHelper.listar_word();
                //if (datos.Rows.Count >= 0)
                //{
                //    DataRow fila = datos.Rows[0];                   
                //    var document = fila["documentoWord"].ToString();
                
                //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();                   
                //    Microsoft.Office.Interop.Word.Document myWordDoc = fila["documentoWord"].ToString(); ;                
                //    myWordDoc.Open();
                //    Process.Start(document);

                //}
            


            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}