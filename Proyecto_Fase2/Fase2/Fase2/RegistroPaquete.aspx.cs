﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class RegistroPaquete : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList(referencia.Consulta("Cliente c ", "c.Cas_Int,c.Nombre,c.Apellido ", " c.Cas_Int IS NOT NULL ", " "));
            for (int a = 0; a < arr.Count; a++) {
                DropDownList1.Items.Add(arr[a].ToString() );
            }
            arr.Clear();
            ArrayList arr2 = new ArrayList(referencia.Consulta("Impuesto i", "i.Nombre,i.Porcentaje", "Porcentaje IS NOT NULL", " "));
            for (int b = 0; b < arr2.Count; b++) {
                DropDownList2.Items.Add(arr2[b].ToString()+"%");

            }

            arr2.Clear();
            ArrayList arr3 = new ArrayList(referencia.Consulta("Sucursal s ", "s.Serie_Suc,s.Pais,s.Direccion", "s.Pais <> 'Estados Unidos' ", " "));
            for (int b = 0; b < arr3.Count; b++)
            {
                DropDownList3.Items.Add(arr3[b].ToString());

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "-" || DropDownList2.SelectedItem.Text == "-" || TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show("Porfavor, seleccione todos los campos");

            }
            else {
                String[] aux2 = DropDownList1.SelectedItem.Text.Split(' ');
                
                String aux1 = referencia.Consulta1("Cliente c", "DPI", "Cas_Int", aux2[0]);
                String[] aux3 = DropDownList2.SelectedItem.Text.Split(' ');
                String[] aux7 = DropDownList3.SelectedItem.Text.Split(' ');
            
               String aux4 = referencia.Consulta1("Impuesto i", "i.Serie_imp", "i.Nombre ", "'" + aux3[0] + "'");
              
                if (referencia.Ingresar("Paquete", " Cliente,Categoria,Peso_lb,Precio,Estado,Destino ", aux1+","+aux4+","+TextBox1.Text+","+TextBox2.Text+",'Registrado',"+aux7[0]))
                {
                       MessageBox.Show("Paquete ingresado con exito");

                  //  Response.Redirect("RegistroPaquete.aspx");
                }
                else {
                    MessageBox.Show("Hay un error, porfavor verifica los campos");
                }
            
            }


        }
    }
}