using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Empleados : System.Web.UI.MasterPage
    {
        public static String usuario1 = "";
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {


            logeado lo = new logeado();
            nom.Text = lo.user();
            if (referencia.Consulta1("Planilla", "Departamento", "Nombre_usuario", "'"+nom.Text+"'") == "1") {
                depto.Text = "Servicio_cliente";
            }
            else if (referencia.Consulta1("Planilla", "Departamento", "Nombre_usuario","'"+ nom.Text+"'") == "2") {
                depto.Text = "Paqueteria";
            }
            else if (referencia.Consulta1("Planilla", "Departamento", "Nombre_usuario", "'"+nom.Text+"'") == "3") {
                depto.Text = "Bodega";
            }
            


        }

        public string Getdepto(){
            return depto.Text;

        }
        public Label depa {
            get
            {
                return depto;
            }
            set {
                depto = value;
            }
        }
      
    }

}
