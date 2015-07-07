using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class EstadoLote : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null) {
                MessageBox.Show("Porfavor selecciona un lote");
            }
            else if (TextBox1.Text == "" || TextBox1.Text == "dd/mm/aa")
            {
                MessageBox.Show("Porfavor escribe una fecha de llegada dd/mm/aa");
            }
            else {
                GridViewRow row = GridView1.SelectedRow; 
                if (referencia.Update("Lote","estado","'En stock'","id_lote",row.Cells[1].Text))
                {
                    MessageBox.Show("muy bien");
                    ArrayList arr1 = new ArrayList(referencia.Consulta("Paquete p,Historial h, Lote l", "p.ID_paquete", "p.ID_paquete = h.Paquete AND l.id_lote = p.Lote AND p.Lote IS NOT NULL AND l.id_lote = ",  row.Cells[1].Text));
                   
                    foreach (string pac in arr1)
                    {
                        referencia.Update("Historial", "Fecha_Stock", "'" + TextBox1.Text + "'", "Fecha_enviado = 'Sin datos' AND Paquete ", pac);
                    }

                }
                else {
                    MessageBox.Show("mal");
                }


            }

        }
    }
}