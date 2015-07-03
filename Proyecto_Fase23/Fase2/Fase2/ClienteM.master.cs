using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class ClienteM : System.Web.UI.MasterPage
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            logeado lo = new logeado();
            nom_usu.Text = lo.user();
            nombre_l.Text = referencia.Consulta1("Cliente c", "c.Nombre", "c.Nombre_usuario", "'" + nom_usu.Text + "'");
            apellido_l.Text = referencia.Consulta1("Cliente c", "c.Apellido", "c.Nombre_usuario", "'" + nom_usu.Text + "'");
            direccion_l.Text = referencia.Consulta1("Cliente c", "c.Direccion_domiciliar", "c.Nombre_usuario", "'" + nom_usu.Text + "'");

        }
    }
}