using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class PreCarga : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null)
            {
              GridViewRow row = GridView1.SelectedRow;
                          
              MemoryStream ms = new MemoryStream();

              
            }
            else { MessageBox.Show("Porfavor seleccione paquete"); }
        }
    }
}