using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Contact : Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient(); 
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //    boton_usuario.Enabled = false;
            
        }

        protected void boton_usuario_Click(object sender, EventArgs e)
        {
         //   if (nombre_box.Text.Equals("") || apellido_box.Text.Equals("") || dpi_box.Text.Equals("") || tele_box.Text.Equals("") || dir_box.Text.Equals("") || nit_box.Text.Equals("") || tarjeta.Text.Equals("") || usuario_box.Text.Equals("") || contraseña_box.Text.Equals("") || confir_box.Text.Equals(""))
          //  {
                if (contraseña_box.Text == confir_box.Text)
                {
                    String tabla = "Cliente";
                    String columnas = "DPI,Nombre,Apellido,NIT,Telefono,Direccion_domiciliar,Tarjeta_asociada,Nombre_usuario,Contraseña";
                    String valores = "" + dpi_box.Text + ",'" + nombre_box.Text + "','" + apellido_box.Text + "'," + nit_box.Text + "," + tele_box.Text + ",'" + dir_box.Text + "'," + tarjeta.Text + ",'" + usuario_box.Text + "','" + contraseña_box.Text + "'";
                    bool confirma = false;
                   confirma = referencia.Ingresar(tabla,columnas,valores);
                    if (confirma)
                    {
                        Response.Redirect("registro_usuario.aspx");
                        // ingreso exitoso
                    }
                    else {
                        Response.Redirect(valores);
                    // para que putas !!!
                    }

                }
                else
                {
                    //las contraseñas son diferentes 
                }
         //   }
          //  else { 
            // hay campos vacios
           // }
        }

        protected void condiciones_CheckedChanged(object sender, EventArgs e)
        {
            boton_usuario.Enabled = true;
        }
    }
}