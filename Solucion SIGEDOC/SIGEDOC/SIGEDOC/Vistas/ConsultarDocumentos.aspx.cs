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
        // instacia de clase 
        SIGEDOC.Negocio.CrearDocumento crearDocumento = new SIGEDOC.Negocio.CrearDocumento();
        private CrearDocHelper docHelper;

        // variable global para capturar el id para actualizar 
        private static int numdocu;
        private static int numdocuSubido;

        // insatancia de calse para los documentos que se han subido
        SIGEDOC.Negocio.DocumentoSub docsub = new SIGEDOC.Negocio.DocumentoSub();
        private DomunetoSubHelper docSupHelper;
        // variable global para capturara el index
        private static int GloID;
        private static int GloID2;


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

            for (int i = 2010; i <= 2050; i++)
            {
                this.dptPeriodo.Items.Add(new ListItem(i.ToString(), i.ToString()));

            }
            // para el segundo periodo, de la segunda modal
            for (int i = 2010; i <= 2050; i++)
            {
                this.dptPeriodo1.Items.Add(new ListItem(i.ToString(), i.ToString()));

            }
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
            if (IsValid)
            {
                try
                {
                    if (!FileSubirWord.HasFile && !FileSubirPdf.HasFile)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorDocumento", "mensajeErrorDocumento('" + "" + "');", true);
                    }
                    else
                    {
                        this.crearDocumento.Total_doc_creado = numdocu;
                        this.crearDocumento.Nom_doc_creado = this.txtnombre.Text;
                        this.crearDocumento.Asunto_doc_creado = this.txtasunto.Text;
                        this.crearDocumento.Detalle_doc_creado = this.txtdetalle.Text;
                        this.crearDocumento.Estado_doc_creado = dptestado.SelectedValue.ToString();
                        this.crearDocumento.Fecha_doc_subido = DateTime.Parse(this.txtfecha.Text);
                        this.crearDocumento.Word_doc_creado = this.FileSubirWord.FileBytes;
                        this.crearDocumento.NombreRealWord1 = this.FileSubirWord.FileName;
                        this.crearDocumento.Pdf_doc_creado = this.FileSubirPdf.FileBytes;
                        this.crearDocumento.NombreRealPdf1 = this.FileSubirPdf.FileName;
                        this.crearDocumento.Num_referencia_creado = dptPeriodo.SelectedValue.ToString() + this.txtreferencia.Text;
                        this.crearDocumento.Periodo = dptPeriodo.SelectedValue.ToString();
                        this.crearDocumento.ModificadoPor1 = Usuarios.GloIdUsuario;
                        this.crearDocumento.Opc = 3;
                        this.docHelper = new CrearDocHelper(crearDocumento);
                        this.docHelper.Actualizar_documento();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);


                    }
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }


            }
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
                else if (estado == "Terminado")
                {
                    e.Row.ForeColor = System.Drawing.Color.White;
                    e.Row.BackColor = System.Drawing.Color.Green;

                }
                //e.Row.Cells[4].Text = "<i size='5xp' style='color:black' class='far fa-file-pdf'></i>";
                //e.Row.Cells[5].Text = "<i class='fas fa-file - alt'></i>";


            }
        }

        protected void GridDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentos", "$('#ModalDocumentos').modal();", true);
                numdocu = int.Parse(this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[1].Text);
                this.txtnombre.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[2].Text;
                this.txtasunto.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[3].Text;
                this.txtdetalle.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[4].Text;
                this.dptestado.SelectedValue = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[7].Text;
                this.txtfecha.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[8].Text;
                this.txtcentrocostos.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[10].Text;
                this.txtusuario.Text = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[11].Text;
                // creacion del substring
                string subcadena2 = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[12].Text.Substring(0, 4);
                this.dptPeriodo.SelectedValue = subcadena2;
                string subcadena = this.GridDocumento.Rows[GridDocumento.SelectedIndex].Cells[12].Text.Substring(4);
                this.txtreferencia.Text = subcadena;
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
     


        }
        protected void GridDocumento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Editar1")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(GridDocumento.DataKeys[index].Value.ToString());
                    AbririWord();
                }

                if (e.CommandName == "Editar")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(GridDocumento.DataKeys[index].Value.ToString());
                    AbrirPdf();
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
       

        }

        protected void GridDocSubido_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentosSubidos", "$('#ModalDocumentosSubidos').modal();", true);
            numdocuSubido = int.Parse(this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[1].Text);
            this.txtnombresubido.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[2].Text;
            this.txtnombre_cliente.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[7].Text;
            this.txtdetallesubido.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[3].Text;
            this.txtcreacion.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[6].Text;
            this.txtcentro_costos.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[8].Text;
            this.txtusuario_subido.Text = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[9].Text;
            // creacion del substring
            string subcadena2 = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[10].Text.Substring(0,4);
            this.dptPeriodo1.SelectedValue = subcadena2;
            string subcadena = this.GridDocSubido.Rows[GridDocSubido.SelectedIndex].Cells[10].Text.Substring(4);
            this.txtreferencia_Subido.Text = subcadena;

        }

        protected void btnactualizar_docSubido_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    if (!Filedocsubido_word.HasFile && !Filedocsubiodo_pdf.HasFile)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorDocumento", "mensajeErrorDocumento('" + "" + "');", true);
                    }
                    else
                    {
                        this.docsub.Total_doc_creado = numdocuSubido;
                        this.docsub.Nom_doc_creado = this.txtnombresubido.Text;
                        this.docsub.Detalle_doc_creado = this.txtdetallesubido.Text;
                        this.docsub.Word_doc_creado = this.Filedocsubido_word.FileBytes;
                        this.docsub.NombrerealWordSub = this.Filedocsubido_word.FileName;
                        this.docsub.Pdf_doc_creado = this.Filedocsubiodo_pdf.FileBytes;
                        this.docsub.NombrerealPdfSub = this.Filedocsubiodo_pdf.FileName;
                        this.docsub.Num_referencia_creado = dptPeriodo1.SelectedValue.ToString() + this.txtreferencia_Subido.Text;
                        this.docsub.Periodo = dptPeriodo1.SelectedValue.ToString();
                        this.docsub.ModificadoPor1 = Usuarios.GloIdUsuario;
                        this.docsub.Opc = 3;
                        this.docSupHelper = new DomunetoSubHelper (docsub);
                        this.docSupHelper.Actualizar_DocSubido();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);


                    }
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }


            }




        }

        private void AbririWord()
        {
            try
            {
                using (SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities db = new SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities())
                {
                    var oDocument = db.TbDocCreado.Find(GloID);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.nombrereal;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.documentoWord);
                    Process.Start(fullFilePath);

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }
     
                       
        }

        private void AbrirPdf()
        {
            try
            {
                using (SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities db = new SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities())
                {
                    var oDocument = db.TbDocCreado.Find(GloID);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.nombrealpdf;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.documentoPDF);
                    Process.Start(fullFilePath);

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }
   

        }

        protected void GridDocSubido_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                if (e.CommandName == "WORD1")
                    {
                        int index = int.Parse(e.CommandArgument.ToString());
                        GloID2 = int.Parse(GridDocSubido.DataKeys[index].Value.ToString());
                        AbrirWordSub();
                    }

                    if (e.CommandName == "PDF1")
                    {
                        int index = int.Parse(e.CommandArgument.ToString());
                        GloID2 = int.Parse(GridDocSubido.DataKeys[index].Value.ToString());
                       AbrirPdfSub();
                    }
        }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

        }
    }

        private void AbrirWordSub()
        {
            try
            {
                using (SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities1 db = new SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities1())
                {
                    var oDocument = db.TbDocSubido.Find(GloID2);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.nombrerealWordSub;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.documentoWordSub);
                    Process.Start(fullFilePath);
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }


        }

        private void AbrirPdfSub()
        {
            try
            {
                using (SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities1 db = new SIGEDOC.Entidad.DB_A4DE45_SIGEDOCEntities1())
                {
                    var oDocument = db.TbDocSubido.Find(GloID2);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.nombrerealPdfSub;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.documentoPdfSub);
                    Process.Start(fullFilePath);
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }


        }
    }
}