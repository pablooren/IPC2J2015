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
    public partial class Cotizacion : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arr2 = new ArrayList(referencia.Consulta("Impuesto i", "i.Nombre,i.Porcentaje", "Porcentaje IS NOT NULL", " "));
            for (int b = 0; b < arr2.Count; b++)
            {
                DropDownList1.Items.Add(arr2[b].ToString() + " %");

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" || TextBox1.Text != "")
            {
                try
             {
                    int pes = Convert.ToInt32(TextBox1.Text);
                    int prec = Convert.ToInt32(TextBox2.Text);
                    String[] aux3 = DropDownList1.SelectedItem.Text.Split(' ');
                    int imp = Convert.ToInt32(aux3[1]);
                    float total = ((pes * 5) + (prec * imp / 100)) * 5 / 100;
                    total = total + ((pes * 5) + (prec * imp / 100));
                    MessageBox.Show("El valor total es : " + total.ToString());
               }
               catch (System.FormatException ) {
                    MessageBox.Show("Verifica los valores");
               }

            }
            else {
                MessageBox.Show("Porfavor escriba en todos los campos");
            }
            
            }
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        }
    }
