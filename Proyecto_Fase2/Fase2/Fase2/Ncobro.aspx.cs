using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class Ncobro : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                String aux1 = TextBox1.Text.Replace(' ', '_');
                String aux2 = TextBox2.Text.TrimEnd('%');
                if (referencia.Ingresar("Impuesto", "Nombre,Porcentaje", "'" + aux1 + "'," + aux2))
                {
                    MessageBox.Show("impuesto agregado con exito");
                }


            }
            else {
                MessageBox.Show("Debe de llenar todos los espacios solicitados");
            }


        }
    }
}