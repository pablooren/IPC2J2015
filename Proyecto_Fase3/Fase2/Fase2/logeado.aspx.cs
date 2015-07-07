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
            bool autenticado = false;
            bool aux = false;
            autenticado = referencia.Login(usuario.Text, password.Text, grupo.SelectedItem.ToString());

            if (autenticado == true)
            {
             //   Response.Redirect("google.com.gt"); // aqui para confirmar el login
                usuario1 = usuario.Text;
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


                if (grupo.SelectedItem.Text == "Administrador")
                {
                    Response.Redirect("Administrador.aspx");
                }
                else if (grupo.SelectedItem.Text == "Director")
                {
                    Response.Redirect("Director.aspx");
                }
                else if (grupo.SelectedItem.Text == "Empleado")
                {
             String aux45 =   referencia.Consulta1("Planilla p, Registro r , Departamento d	", "d.Nombre", "d.Serie_dept = r.depto_id AND p.Departamento = r.no_registro AND p.Nombre_usuario ","'"+ usuario.Text+"'");
             if (aux45 == "Servicio_cliente") {
                 Response.Redirect("Servicio al cliente.aspx");
             }
             else if (aux45 == "Bodega") { Response.Redirect("Bodega.aspx"); }
             else if (aux45 == "Paqueteria") { Response.Redirect("Paqueteria.aspx"); } else { MessageBox.Show("Hubo un error porfavor verifica"); }

                }
                else if (grupo.SelectedItem.Text == "Cliente")
                {
                    Response.Redirect("Clientes.aspx");
                }
                else
                {
                    MessageBox.Show("Usuario no valido");
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