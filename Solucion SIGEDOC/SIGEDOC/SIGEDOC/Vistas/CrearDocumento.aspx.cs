using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEDOC.Vistas
{
    public partial class CrearDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Label1.Text== "")
            {

                BtnGuardar.Enabled = false;
                //Button.Enabled = HttpContext.Current.User.IsInRole("Admin");

            }
            else {

                BtnGuardar.Enabled = true;
            }

        }
    }
}