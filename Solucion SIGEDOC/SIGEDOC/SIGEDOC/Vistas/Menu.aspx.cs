using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEDOC.Vistas
{
    public partial class Menu1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool Internet = ValidarIntenrt();
            if (Internet)
            {
                //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SI HAY INTERNET');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera2", "mensajeEspera2('" + "" + "');", true);
            }

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




    }
}