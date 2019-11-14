using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEDOC.Vistas
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {

        // variables locales para usar en modal.
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalUsuario", "$('#ModalUsuario').modal();", true);

            this.txtcedula.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[1].Text;
            this.txtnombre.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[2].Text;
            this.txtnikcname.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[3].Text;
            this.txtcorreo.Text = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[4].Text;
            this.dptrol.SelectedValue = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[6].Text;
            this.dptestado.SelectedValue = this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[7].Text;
            if (this.dptestado.SelectedValue == "2")
            {
                this.dptestado.Items.FindByText("Inactivo").Selected = true;
            }
            else
            {
                this.dptestado.Items.FindByText("Activo").Selected = true;

            }
            this.txtcontacto.Text = int.Parse(this.GridUsuarios.Rows[GridUsuarios.SelectedIndex].Cells[8].Text).ToString();
        }
    }
}