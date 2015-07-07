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
    public partial class ModificarContrato : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList suc = new ArrayList(referencia.Consulta("Sucursal s", "s.Serie_Suc,s.Pais,s.Direccion", " s.Serie_Suc = s.Serie_Suc "," "));
            for (int a = 0; a < suc.Count; a++) {
                DropDownList2.Items.Add(suc[a].ToString());

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                MessageBox.Show("Porfavor Seleccione empleado");
            }
            else {
                GridViewRow row = GridView1.SelectedRow;

                if (TextBox1.Text != "") {
                    
                     referencia.Update(" Planilla ", " Sueldo ", TextBox1.Text, " ID_empleado ", row.Cells[1].Text);

                }
                else if (DropDownList1.SelectedItem.Text != "-") {
                    referencia.Update("Planilla", " Cargo ","'"+ DropDownList1.SelectedItem.Text+ "'", "ID_empleado ", row.Cells[1].Text);

                }
                else if (DropDownList2.SelectedItem.Text != "-") {
                    if (DropDownList3.SelectedItem.Text == "-")
                    {
                        MessageBox.Show("Porfavor, si desea cambiar de sucursal, seleccione un departamento");
                    }
                    else {
                        String aux3 = "";
                        String aux4 = DropDownList2.SelectedItem.Text;
                        String[] aux5 = aux4.Split(' ');
                        aux3 = referencia.Consulta1(" Registro r,Departamento d,Sucursal s ","r.no_registro", " d.Serie_dept = r.depto_id AND s.Serie_Suc = r.sede_id AND s.Serie_Suc =  "+aux5[0]+" AND d.Nombre ","'"+ DropDownList3.SelectedItem.Text+ "'");
                        referencia.Update("Planilla", "Departamento", aux3, "ID_empleado", row.Cells[1].Text);

                    }

                }
                else if (DropDownList3.SelectedItem.Text != "-") {
                    String aux6 = "";
                    String aux7 = "";
                    aux6 = referencia.Consulta1("Registro r, Departamento d, Sucursal s, Planilla p", "s.Serie_Suc", "d.Serie_dept = r.depto_id AND s.Serie_Suc = r.sede_id AND p.Departamento = r.no_registro AND p.ID_empleado ", row.Cells[1].Text);
                    aux7 = referencia.Consulta1("Registro r, Departamento d", "r.no_registro", " d.Serie_dept = r.depto_id AND d.Nombre = '" + DropDownList3.SelectedItem.Text + "'AND r.sede_id", aux6);
                    referencia.Update("Planilla", "Departamento", aux7, "ID_empleado", row.Cells[1].Text);

                
                }
                
            }

            Response.Redirect("ModificarContrato.aspx");
        }
    }
}