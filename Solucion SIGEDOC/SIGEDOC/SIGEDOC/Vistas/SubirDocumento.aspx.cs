using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace SIGEDOC.Vistas
{

    public partial class SubirDocumento : System.Web.UI.Page
    {

        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private static int validar;

        SIGEDOC.Negocio.DocumentoSub docSub = new SIGEDOC.Negocio.DocumentoSub();
        private DomunetoSubHelper docsubHelp;
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
            this.txtDescripcion.Text = null;
            this.txtCenCos.Text = null;
            this.txtReferencia.Text = null;
            this.dptPeriodo = null;
            this.dptProyecto = null;

        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    if (!FileSubirWordsub.HasFile)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorDocumento", "mensajeErrorDocumento('" + "" + "');", true);
                    }
                    else
                    {
                        Num_IdCliente();

                        this.docSub.Nom_doc_creado = this.txtNombreDoc.Text;
                        this.docSub.Detalle_doc_creado = this.txtDescripcion.Text;
                        this.docSub.Periodo = this.dptPeriodo.SelectedValue;
                        this.docSub.Id_usuario = Usuarios.GloIdUsuario;
                        this.docSub.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue);
                        this.docSub.Num_consecutivo = numcosecu;
                        this.docSub.Word_doc_creado = FileSubirWordsub.FileBytes;
                        this.docSub.Pdf_doc_creado = FileSubirPdfsub.FileBytes;
                        this.docSub.Fecha_doc_subido = DateTime.Now;
                        this.docSub.Id_cliente = id_cliente;
                        this.docSub.Num_referencia_creado = this.txtReferencia.Text;
                        this.docSub.ModificadoPor1 = "Sin Modidificar";                  
                        this.docSub.Opc = 1;
                        this.docsubHelp = new DomunetoSubHelper(docSub);
                        this.docsubHelp.Ingresar_DocSubido();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                this.txtDescripcion.Text = ex.Message;
                // ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        private void Num_IdCliente()
        {
            try
            {
                this.docSub.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue.ToString());
                this.docSub.Opc = 2;
                this.docsubHelp = new DomunetoSubHelper(docSub);
                this.datos = new DataTable();
                this.datos = this.docsubHelp.Numero_Consecutivo();

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
        private void Num_consecu()
        {
            try
            {
                this.docSub.Id_proyecto = int.Parse(this.dptProyecto.SelectedValue.ToString());
                this.docSub.Opc = 1;
                this.docsubHelp = new DomunetoSubHelper(docSub);
                this.datos = new DataTable();
                this.datos = this.docsubHelp.Numero_Consecutivo();

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];
                    Num_Total_Documento();
                    numcosecu = int.Parse(fila["numConseSub"].ToString());
                    if (numcosecu == 0)
                    {
                        numcosecu = 1;
                        this.txtReferencia.Text = this.dptPeriodo.SelectedValue +"sub"+"-" + this.dptProyecto.SelectedValue + "-" +
                            numcosecu + "-" + numtotaldocu ;
                    }
                    else
                    {
                        this.txtReferencia.Text = this.dptPeriodo.SelectedValue +"sub"+"-" + this.dptProyecto.SelectedValue + "-" +
                            (numcosecu + 1) + "-" + numtotaldocu;
                    }
                }
                else
                {
                    numcosecu = 1;
                    numtotaldocu = 1;
                    this.txtReferencia.Text = this.dptPeriodo.SelectedValue + "sub"+"-" + this.dptProyecto.SelectedValue + "-" +
                    numcosecu + "-" + numtotaldocu;
                }
                this.txtCenCos.Text = this.dptProyecto.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                this.txtDescripcion.Text = ex.Message;

            }
        }
        private void Num_Total_Documento()
        {
            try
            {
                this.docSub.Opc = 1;
                this.docsubHelp = new DomunetoSubHelper(docSub);
                this.datos = new DataTable();
                this.datos = this.docsubHelp.Numero_total_Doc();

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];
                    numtotaldocu = int.Parse(fila["numtotalsub"].ToString());
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