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

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 2010; i <= 2050; i++)
            {
                dptPeriodo.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
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
            if (IsValid)
            {
               
                
                if (!FileSubirWord.HasFile)
                {

                    this.txtCenCos.Text = "Debe cargar el documento word";

                }
                else
                {
                    this.txtCenCos.Text = "se guardo";

                }
            }
        }

        protected void dptProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cd.Id_proyecto = int.Parse(dptProyecto.SelectedValue.ToString());
                this.cd.Opc = 1;
                this.cdh = new CrearDocHelper(cd);
                this.datos = new DataTable();
                this.datos = this.cdh.Numero_Consecutivo();

                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    this.txtReferencia.Text = fila["idProyecto"].ToString() + "-" + fila["[Sub total]"].ToString(); 
                }


            }
            catch (Exception ex)
            {
                this.txtAsunto.Text = ex.Message;
             
            }
          
        }
    }
}