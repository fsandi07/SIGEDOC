using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEDOC.Vistas
{
    public partial class Rol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbPermisos.Items.Count; i++)
            {
                if (cbPermisos.Items[i].Selected == true)
                {
                    //Alguna accion al encontrar un check seleccionado
                    string valor = cbPermisos.Items[i].Value.ToString();
                    string Nombre = cbPermisos.Items[i].Text;
                    this.txtDetalleRol.Text = valor;
                    this.txtNombreRol.Text = Nombre;
                }
            }
        }
    }
}