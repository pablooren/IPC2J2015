using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class EliminarEmpleado : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
      
        protected void Page_Load(object sender, EventArgs e)
        {

            String regis = referencia.Consulta1("Planilla ", "Departamento", "Nombre_usuario", "'" + log.user() + "'");
            String suc = referencia.Consulta1("Registro", "sede_id", "no_registro", regis);
            String depto = referencia.Consulta1("Registro", "depto_id", "no_registro", regis);
            depto_l.Text = depto;
            suc_l.Text = suc;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                MessageBox.Show("Porfavor seleccione un empleado");
            }
            else {
                GridViewRow row = GridView1.SelectedRow;

                if (referencia.DELETE("Empleado", "ID_Empleado = " + row.Cells[1].Text)) {
                    MessageBox.Show("Empleado eliminado");
                    Response.Redirect("EliminarEmpleado.aspx");
                }
            }
        }
    }
}