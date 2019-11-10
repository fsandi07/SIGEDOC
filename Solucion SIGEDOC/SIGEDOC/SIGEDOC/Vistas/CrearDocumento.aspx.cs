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

namespace SIGEDOC.Vistas
{
    public partial class CrearDocumento : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {

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
                this.FindAndReplace(wordApp, "<asunto>",this.txtasunto.Text);
                this.FindAndReplace(wordApp, "<usuario>",this.txtusuario.Text);
                this.FindAndReplace(wordApp, "<referencia>", this.txtreferencia.Text);
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
        // hilo para hacer esperar un proceso 
        public static void esperar(int segundos)
        {
            try
            {
               

                Thread.Sleep(segundos * 1000);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void abrirWord()
        {
            //Thread.Sleep(6000);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
          
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
                Thread hilo1 = new Thread(new ThreadStart(abrirWord));
                hilo1.Start();
                hilo1.Join();

                if (hilo1.IsAlive == false)
                {
                    CreateWordDocument(@"C:\Users\Usuario\Documents\SIGEDOC_N\Solucion SIGEDOC\SIGEDOC\documentos word\temp1.docx", @"C:\Users\Usuario\Documents\SIGEDOC_N\Solucion SIGEDOC\SIGEDOC\documentos word\documento creado\PQS.docx");

                }
            }
            catch (Exception ex)
            {

                this.txtcentro_costos.Text = ex.Message;
            }

            
        }
      
    }
}