using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using SIGEDOC.Negocio;

namespace SIGEDOC.Vistas
{
    public partial class Bitacora : System.Web.UI.Page
    {
        String vCadenaConexion = @"Data Source = den1.mssql7.gear.host; initial catalog = sigedoc; user id = sigedoc; password = Ip4805Xtg~2-";
        SqlConnection vConexion;
        SqlDataAdapter vDataAdapter;
        DataTable vDT;
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        protected void Page_Load(object sender, EventArgs e)
        {
            Num_Estado_Permiso();

            if (validar == 0 || Session["Idusuario"] == null)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
            }
            else
            {

            }
            String vSQL;
            vDT = new DataTable();

            vSQL = "SELECT * FROM TbBitacora";


           RptBitacora rpt = new RptBitacora();

            vDT = EjecutarSELECT(vSQL);

            rpt.SetDataSource(vDT);

            ReporteB.ReportSource = rpt;
        }
        private void Num_Estado_Permiso()
        {
            try
            {
                this.pr.Opc = 1;
                this.pr.Id_rol = Usuarios.GlotIdRol;
                this.pr.Nombre_permiso = "Bitacora";
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





        private void ConectarBD()
        {
            try
            {
                vConexion = new SqlConnection(vCadenaConexion);
                vConexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DesconectarBD()
        {
            try
            {
                vConexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable EjecutarSELECT(String pSQL)
        {
            vDT = new DataTable();

            ConectarBD();

            vDataAdapter = new SqlDataAdapter(pSQL, vConexion);
            vDataAdapter.Fill(vDT);

            DesconectarBD();

            return vDT;
        }
    }
}