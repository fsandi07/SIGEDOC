﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGEDOC.Negocio;
using System.Data;

namespace SIGEDOC.Vistas
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        // instacia del hepler para los permisos de cada rol
        SIGEDOC.Negocio.Permisos pr = new SIGEDOC.Negocio.Permisos();
        private PermisosHelper prh;
        private DataTable datos;
        private static int validar;
        // instacias para la insercion de nuevos clientes 
        SIGEDOC.Negocio.Clientes cl = new SIGEDOC.Negocio.Clientes();
        private ClienteHelper clh;

        protected void Page_Load(object sender, EventArgs e)
        {
            //bool Internet = ValidarIntenrt();
            //if (Internet)
            //{
            //    //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SI HAY INTERNET');", true);
            //}
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera2", "mensajeEspera2('" + "" + "');", true);
            //}

            //Num_Estado_Permiso();

            //if (validar == 0 || Session["Idusuario"] == null)
            //{

            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
            //}
            //else
            //{

            //}
        }
        public bool ValidarIntenrt()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void Num_Estado_Permiso()
        {
            try
            {
                this.pr.Opc = 1;
                this.pr.IdRol = Usuarios.GlotIdRol;
                this.pr.Nom_Per1 = "Crear Cliente";
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

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.cl.Nombre_cliente = this.txtnombrecliente.Text;
                this.cl.Nombre_de_Contacto = this.txtnombrecontacto.Text;
                this.cl.Telefono_contacto = int.Parse(txttelefono.Text);
                this.cl.Correo_cliente = this.txtcorreo.Text;
                this.cl.Detalle_cliente = this.txtobservaciones.Text;
                this.cl.Estado_cliente = "1";
                this.cl.Opc = 1;
                this.clh = new ClienteHelper(cl);
                this.clh.Agregar_Cliente();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
    


        }
    }

}