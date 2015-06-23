using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class GestionCobros : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null)
            {
                GridViewRow row = GridView1.SelectedRow;
                if (referencia.Update("Impuesto", "Porcentaje", "0", "Serie_imp", row.Cells[1].Text))
                {
                    MessageBox.Show("el impuesto ha sido deshabilitado");
                    Response.Redirect("GestionCobros.aspx");
                }
                else
                {
                    MessageBox.Show("el cobro no pudo ser deshabilitado");
                }

            }
            else {
                MessageBox.Show("porfavor selecciona un cobro a deshabilitar");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null)
            {
                if (TextBox1.Text != null)
                {
                    GridViewRow row = GridView1.SelectedRow;
                    if (referencia.Update("Impuesto", "Porcentaje", TextBox1.Text, "Serie_imp", row.Cells[1].Text))
                    {
                        MessageBox.Show("el impuesto ha sido modificado");
                        Response.Redirect("GestionCobros.aspx");
                    }
                    else
                    {
                        MessageBox.Show("el cobro no pudo ser deshabilitado");
                    }

                }
                else {
                    MessageBox.Show("porfavor escriba el porcentaje");
                }
            }
            else {
                MessageBox.Show("porfavor seleccione un cobro a modificar");
            }
        }
    }
}