using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica1_IPC2
{
    public partial class Form2 : Form
    {
       private String tabla = "";
       private String columnas = "";
       private String valores = "";
        ServiceReference1.ServiceSoapClient conexion = new ServiceReference1.ServiceSoapClient(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla = "Cliente";
            columnas = "Carnet,Nombre,DPI,Direccion,Telefono";
            valores = "'" + carnet_box.Text + "','" + Nombre_box.Text + "','" + dpi_box.Text + "','" + dir_box.Text + "','" + tele_box.Text + "'";
            if (conexion.Registrar(tabla, columnas, valores))
            {
                MessageBox.Show("Cliente creado");
                
            }
        }

    }

}
