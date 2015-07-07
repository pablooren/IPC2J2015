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
    public partial class Servicio_al_cliente : System.Web.UI.Page
    {
        public static string casint = "";
     
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public String GetCas() {
            String ss = "";
            ss = casint;
            return ss;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            if (TextBox1.Text == "" && TextBox2.Text == "") {
                // no escribio nada
                MessageBox.Show("Porfavor llene uno de los espacios ");
            }
            else if (TextBox1.Text !="" && TextBox2.Text != "") { 
            // escribio en los dos
                MessageBox.Show("Porfavor escriba solamente en un criterio");
            }
            else if (TextBox1.Text != "" && TextBox2.Text == "") { 
            // se sabe la casiila
                String aux5 = "";
              aux5 = referencia.Consulta1("Cliente c", "c.DPI", "c.Cas_Int ", TextBox1.Text);
              if (aux5 != "")
              {

                  casint = TextBox1.Text;
                  Response.Redirect("servicio_paquete.aspx");
              }
              else {
                  MessageBox.Show("La casilla no existe, porfavor verifique");
              }
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                String[] aux1 = TextBox2.Text.Split(' ');
                if (aux1.Count() == 2)
                {

                    ArrayList us = new ArrayList(referencia.Consulta("Cliente c", "c.Nombre,c.Apellido,c.DPI ,c.Cas_Int", "c.Nombre = '"+aux1[0]+"' AND c.Apellido = '"+ aux1[1]+"'", " "));
                    for (int a = 0; a < us.Count; a++)
                    {
                        DialogResult result = MessageBox.Show(us[a].ToString(), "¿Este usted este señor?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            String[] aux2 = us[a].ToString().Split(' ');
                            casint = aux2[3];
                            Response.Redirect("servicio_paquete.aspx");
                            break;
                        }
                        else if (result == DialogResult.No)
                        {
                        }

                    }

                }
                else { MessageBox.Show("Debe de ingresar solo un nombre y apellido"); } 
            }

        }
    }
}