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
    public partial class Pendientes : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Casintl.Text = referencia.Consulta1("Cliente c", "c.DPI", "c.Nombre_usuario", "'" + log.user()+"'");


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                MessageBox.Show("No se selecciono ningun paquete");

            }
            else {
                GridViewRow row = GridView1.SelectedRow;
                ArrayList arr3 = new ArrayList(referencia.Consulta("Paquete p, Historial h", "p.ID_paquete,p.Categoria,p.Peso_lb,p.Precio,h.Fecha_Enviado,h.Fecha_Recibido,h.Fecha_Stock,h.Fecha_Facturado", "p.ID_paquete = h.Paquete AND p.ID_paquete ="+row.Cells[1].Text," "));
                for (int b = 0; b < arr3.Count; b++)
                {
                    MessageBox.Show("ID_paquete     Categoria     Peso_lb     Precio     Fecha_Enviado     Fecha_Recibido    Fecha_Stock   Fecha_Facturado   \n"+arr3[0]);

                }
            }
        }
    }
}