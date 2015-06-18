using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class About : Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient(); 
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_autenticacion()
        {
            bool autenticado = false;
            autenticado = referencia.Login(usuario.Text, password.Text, grupo.SelectedItem.ToString());

            if (autenticado)
            {
                Response.Redirect("google.com.gt"); // aqui para confirmar el login
            }
            else
            {
                Response.Redirect("facebook.com"); // aqui el login fue una vil mierda
            }


        }
        protected void inicio_Click(object sender, EventArgs e)
        {
            Login_autenticacion();

        }
    }
}