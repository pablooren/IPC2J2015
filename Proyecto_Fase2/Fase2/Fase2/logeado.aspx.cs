using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace Fase2
{
    public partial class logeado : System.Web.UI.Page
    {
        int rol = 0;
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        public static String usuario1 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected bool Login_autenticacion()
        {
            int autenticado = 0;
            bool aux = false;
            autenticado = referencia.Login(usuario.Text, password.Text, grupo.SelectedItem.ToString());

            if (autenticado != 0)
            {
             //   Response.Redirect("google.com.gt"); // aqui para confirmar el login
                usuario1 = usuario.Text;
                rol = autenticado;
                aux = true;
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al logearte, Intenta otra vez");
                aux = false;
            }

            return aux;
        }
        protected void inicio_Click(object sender, EventArgs e)
        {
            if (Login_autenticacion())
            {


                if (rol == 1)
                {
                    Response.Redirect("Administrador.aspx");
                }
                else if (rol == 2 || rol == 3 || rol == 4)
                {
                    Response.Redirect("Director.aspx");
                }
                else if (rol == 5 || rol == 6 || rol == 7)
                {
                    Response.Redirect("empleado");
                }
                else if (rol == 9)
                {
                    Response.Redirect("usuario");
                }
                else
                {
                    Response.Redirect("logeado.aspx");
                }

            }

        }
        public String user()
        {
            return usuario1;
        }
    }
}