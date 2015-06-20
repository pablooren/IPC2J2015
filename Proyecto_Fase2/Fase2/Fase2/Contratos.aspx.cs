using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Contratos : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        String deptt = "";
        string aux1 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            deptt = Master.depa.Text;
            if (deptt == "Servicio_cliente") {
                aux1 = "1";
            }
            else if (deptt == "Paqueteria") { aux1 = "2"; 
            }
            else if (deptt == "Bodega") { aux1 = "3"; }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            bool exito = false;
            string datos = id.Text+ ",'"+nom.Text+"','"+ape.Text+"',"+dpi.Text+","+ tele.Text+",'"+domi.Text+"'";
            exito = referencia.Ingresar("Empleado", "ID_empleado,Nombre,Apellido,DPI,Telefono,Domicilio", datos);
            if (exito) { 
            // lo hiimos perro
                bool exito2 = false;
                String datos2 = id.Text+","+aux1+",'"+cargo.SelectedItem.Text+"',"+ sueldo.Text+",'"+user.Text+"','"+pass.Text+"'";
                exito2 = referencia.Ingresar("Planilla", "ID_empleado,Departamento,Cargo,Sueldo,Nombre_usuario,Contraseña", datos2);
                if (exito2)
                {
                    // perro
                    Response.Redirect("Contratos.aspx");

                }
                else { 
                // en la mierda
                    Response.Redirect(datos2);
                }


            }
            else
            {
                Response.Redirect(datos);
            }


        }
    }
}