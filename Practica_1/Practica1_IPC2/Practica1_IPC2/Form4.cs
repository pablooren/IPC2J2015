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
    public partial class Form4 : Form
    {
        private ServiceReference1.ServiceSoapClient conexion = new ServiceReference1.ServiceSoapClient(); 
     
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String libro = "";
            libro = conexion.Cargar_libros();
            String[] libros = libro.Split('/');
            for (int a = 0; a< libros.Count(); a++) {
                libro_box.Items.Add(libros[a]);

            }
           


        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

        private void libro_box_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  try
          //  {
                String lb = "";
                String selec = "";
              
                lb = conexion.Consulta_Libros(libro_box.SelectedItem.ToString());
                String[] lbs = lb.Split('/');
                nomb_text.Text = lbs[0];
                autor_text.Text = lbs[1];
                existencia_text.Text = lbs[2];
                Dispo_text.Text = lbs[3];
                prest_text.Text = lbs[4];
                reser_text.Text = lbs[5];
           // }
           // catch (Exception exce)
           // {

           // }
        }
    }
}
