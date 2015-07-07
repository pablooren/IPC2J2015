using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class servicio_paquete : System.Web.UI.Page
    {
        Servicio_al_cliente serv = new Servicio_al_cliente();
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            String aux1 = "";
            aux1 = serv.GetCas();
            if (aux1 != "")
            {
                casi_label.Text ="Casilla Internacional :"+ aux1;
                Nombre_label.Text = referencia.Consulta1("Cliente c", "c.DPI", "c.Cas_Int", aux1);

            }
            else {
                casi_label.Text = "1";
                Nombre_label.Text = "N/A";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                MessageBox.Show("Porfavor seleccione un paquete");

            }
            else {
                if (DropDownList1.SelectedItem.Text == "Facturar") { 
                // Aqui toda la logica para facturar
                    MessageBox.Show("Vamos a facturar :)");
                }
                else if (DropDownList1.SelectedItem.Text == "Devolver") {
                    GridViewRow row = GridView1.SelectedRow;
                    if (referencia.Update("Paquete", "Estado", "'Devuelto'", "  ID_paquete", row.Cells[1].Text)) {
                        MessageBox.Show("El paquete se devolvera");
                        Response.Redirect("servicio_paquete.aspx");
                    }
                    

                
                }
            
            }


        }
    }
}