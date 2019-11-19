using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Web.Services;
using SIGEDOC.Negocio;
using System.Data;

namespace SIGEDOC.Vistas
{
    public partial class CrearDocumento : System.Web.UI.Page
    {
        SIGEDOC.Negocio.CrearDocumento cd = new SIGEDOC.Negocio.CrearDocumento();
        private CrearDocHelper cdh;
        private DataTable datos;

        public static int numcosecu;
        public static int numtotaldocu;
        private static int id_cliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 2010; i <= 2050; i++)
            {
                dptPeriodo.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }
        public void Limpiar()
        {

            this.txtNombreDoc.Text = null;
            this.txtAsunto.Text = null;
            this.txtDescripcion.Text = null;
            this.txtCenCos.Text = null;
            this.txtReferencia.Text = null;

        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;


            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            object missing = Missing.Value;
            Microsoft.Office.Interop.Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;
                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                //find and replace
                this.FindAndReplace(wordApp, "<asunto>", this.txtAsunto.Text);
                this.FindAndReplace(wordApp, "<usuario>", this.txtUsuario.Text);
                this.FindAndReplace(wordApp, "<referencia>", this.txtReferencia.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Today);
            }
            else
            {
                //MessageBox.Show("File not Found!");
            }
            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            myWordDoc.Close();
            wordApp.Quit();
            Process.Start(@"C:\Users\Usuario\Documents\SIGEDOC_N\Solucion SIGEDOC\SIGEDOC\documentos word\documento creado\PQS.docx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
                CreateWordDocument(@"C:\Users\Usuario\Documents\SIGEDOC_N\Solucion SIGEDOC\SIGEDOC\documentos word\temp1.docx", @"C:\Users\Usuario\Documents\SIGEDOC_N\Solucion SIGEDOC\SIGEDOC\documentos word\documento creado\PQS.docx");
            }
            catch (Exception ex)
            {

                this.txtCenCos.Text = ex.Message;
            }
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    if (!FileSubirWord.HasFile)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeValidacionDoc", "mensajeDeValidacionDoc('" + "" + "');", true);
                    }
                    else
                    {
                        Num_IdCliente();
                        this.cd.Total_doc_creado = numtotaldocu;
                        this.cd.Nom_doc_creado = this.txtNombreDoc.Text;
                        this.cd.Asunto_doc_creado = this.txtAsunto.Text;
                        this.cd.Detalle_doc_creado = this.txtDescripcion.Text;
                        this.cd.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue);
                        this.cd.Periodo = this.dptPeriodo.SelectedValue;
                        this.cd.Estado_doc_creado = this.lblEstado.Text;
                        this.cd.Num_consecutivo = numcosecu;
                        this.cd.Word_doc_creado = this.FileSubirWord.FileBytes;
                        this.cd.Pdf_doc_creado = this.FileSubirPdf.FileBytes;
                        this.cd.Estado_doc_creado = "En Proceso";
                        this.cd.Fecha_doc_subido = DateTime.Today.ToString();
                        this.cd.Id_cliente = id_cliente;
                        this.cd.Id_usuario = 121212;
                        this.cd.Num_referencia_creado = this.txtReferencia.Text;
                        this.cd.Habilitado = 1;
                        this.cd.Opc = 1;
                        this.cdh = new CrearDocHelper(cd);
                        this.cdh.Ingresar_DocCreado();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + ex + "');", true);
                // aqui podemos dispar un insert a bitacora con el error y la fecha y el usuario
            }
        }

        protected void BtnPrueba_Click(object sender, EventArgs e)
        {
            //Num_consecu();
        }

        private void Num_consecu()
        {
            try
            {
                this.cd.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue.ToString());
                this.cd.Opc = 1;
                this.cdh = new CrearDocHelper(cd);
                this.datos = new DataTable();
                this.datos = this.cdh.Numero_Consecutivo();

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    numtotaldocu = int.Parse(fila["numtotaldocu"].ToString() );
                    numcosecu = int.Parse(fila["numConsecu"].ToString() + 1);
                    this.txtReferencia.Text = this.dptPeriodo.SelectedValue + "-" + this.dptProyecto.SelectedValue + "-" +
                         numcosecu + "-" + (numtotaldocu+1);

                }
                else
                {
                    numcosecu = 1;
                    this.txtReferencia.Text = this.dptPeriodo.SelectedValue + "-" + this.dptProyecto.SelectedValue + "-" +
                    numcosecu + "-" + 1;
                }

                this.txtCenCos.Text = this.dptProyecto.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                this.txtDescripcion.Text = ex.Message;

            }
        }

        private void Num_IdCliente()
        {
            try
            {
                this.cd.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue.ToString());
                this.cd.Opc = 2;
                this.cdh = new CrearDocHelper(cd);
                this.datos = new DataTable();
                this.datos = this.cdh.Numero_Consecutivo();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    id_cliente = int.Parse(fila["idCliente"].ToString());
                }
            }

            catch (Exception ex)
            {
                this.txtDescripcion.Text = ex.Message;
            }
        }



        protected void dptProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Num_consecu();
        }
    }
}