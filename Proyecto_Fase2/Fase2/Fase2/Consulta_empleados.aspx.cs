using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class Consulta_empleados : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        

        protected void Page_Load(object sender, EventArgs e)
        {
         // GridView1.DataSource = referencia.datos(depto);
       //    GridView1.DataBind();
       //     depto_label11.Text = Master.depa.Text;
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null) {
                MessageBox.Show("Porfavor Selecciona un empleado");
            }else{
                GridViewRow row = GridView1.SelectedRow;

                ArrayList aux2 = new ArrayList(referencia.Consulta("Empleado e,Planilla p", "e.Nombre,e.Apellido,e.DPI,e.Telefono,p.Cargo,p.Nombre_usuario", "e.ID_Empleado = p.ID_empleado AND p.ID_empleado = ", row.Cells[1].Text));
              //  MessageBox.Show(row.Cells[1].Text);  
               MessageBox.Show(aux2[0].ToString());

            }


        }
    }
}