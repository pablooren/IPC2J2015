using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class Editar_cliente : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
        String users = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            users = referencia.Consulta1("Cliente c", "c.DPI", "c.Nombre_usuario", "'" + log.user() + "'");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (nom_box.Text != "") { 
            // cambiar nombre
                if (referencia.Update("Cliente ", "Nombre", "'" + nom_box.Text + "'", "DPI", users)) {
                    MessageBox.Show("Nombre cambiado con exito");
                }
            }
             if (ape_box.Text != "") { 
            // cambiar apellido
                if (referencia.Update("Cliente ", "Apellido", "'" + ape_box.Text + "'", "DPI", users))
                {
                    MessageBox.Show("Apellido cambiado con exito");
                }
            }
             if (dir_box.Text != "") { 
            // cambiar direccion
                if (referencia.Update("Cliente ", "Direccion_domiciliar", "'" + dir_box.Text + "'", "DPI", users))
                {
                    MessageBox.Show("Direccion cambiada con exito");
                }
            }
             if (tele_box.Text != "") { 
            // cambiar telefono
                if (referencia.Update("Cliente ", "Telefono",   tele_box.Text , "DPI", users))
                {
                    MessageBox.Show("Telefono cambiado con exito");
                }
            }
             if (tarj_box.Text != "")
            {
                // cambiar tarjeta
                if (referencia.Update("Cliente ", "Tarjeta_asociada", tarj_box.Text, "DPI", users))
                {
                    MessageBox.Show("Tarjeta  cambiada con exito");
                }
            }
          //  else {
          //      MessageBox.Show("Edita alguna espacio porfavor");
          //  }
            Response.Redirect("Editar_cliente.aspx");


        }
    }
}