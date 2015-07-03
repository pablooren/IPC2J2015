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
    public partial class Lote : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView2.SelectedRow == null)
            {
                MessageBox.Show("Porfavor Selecciona una sucursal de envio");
            }
            else
            {
                GridViewRow row = GridView2.SelectedRow;
                if (TextBox1.Text == "" || TextBox1.Text == "dd/mm/aa")
                {
                    MessageBox.Show("Porfavor ingresa una fecha de salida dd/mm/aa");
                }
                else
                {
                  
                    if (referencia.Gestion_EnvioE(TextBox1.Text ,row.Cells[1].Text))
                    {
                        MessageBox.Show("Lote creado con exito");
                        ArrayList arr1 = new ArrayList(referencia.Consulta("Paquete p,Historial h, Lote l","p.ID_paquete","p.ID_paquete = h.Paquete AND l.id_lote = p.Lote AND p.Lote IS NOT NULL AND l.fecha_salida = ","'"+TextBox1.Text+"'"));
                        foreach (string pac in arr1) {
                            referencia.Update("Historial", "Fecha_enviado", "'" + TextBox1.Text + "'","Fecha_enviado = 'Sin datos' AND Paquete ",pac);
                        }

              //         referencia.Update("Historial","Fecha_Enviado","'"+TextBox1.Text+"'", "")

                        Response.Redirect("Lote.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al crear el lote, porfavor verifica los campos");
                    }
                }


            }
        }
    }
}