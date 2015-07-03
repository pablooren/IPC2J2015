using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class Confirmacion_usuario : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {
      
 
      

      







        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
           // intbox.Text = row.Cells[1].Text;
            bool s = false;
            s =referencia.Update("Cliente", "Cas_Int", intbox.Text, "DPI", row.Cells[1].Text);
            Response.Redirect("Confirmacion_usuario.aspx");
            MessageBox.Show("Hola mi vida");
        }
    }
}