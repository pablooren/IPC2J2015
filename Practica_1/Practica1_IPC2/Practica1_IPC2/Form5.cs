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
    public partial class Form5 : Form
    {
        private ServiceReference1.ServiceSoapClient conexion = new ServiceReference1.ServiceSoapClient();
        public Boolean dispo = false;
        public Boolean lleno = false;
        private String tabla = "";
        private String columnas = "";
        private String valores = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Today.ToString("d");

            String libro = "";
            libro = conexion.Cargar_libros();
            cliente_box.Items.Add("201314881");
            String[] libros = libro.Split('/');
            for (int a = 0; a < libros.Count(); a++)
            {
               
                lb_combo.Items.Add(libros[a]);

            }
        }

        private void lb_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String lb = "";
           
            lb = conexion.Consulta_Libros(lb_combo.SelectedItem.ToString());
            String[] lbs = lb.Split('/');
            nombre_label.Text = lbs[0];
            if (lbs[3] != "0") {
                dispo = true;
            }
            
            if ((Convert.ToInt32(lbs[4]) + Convert.ToInt32(lbs[5])) == Convert.ToInt32(lbs[2])) {
                lleno = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dispo == false)
            {
                MessageBox.Show("Libro no disponible");
                if (lleno == true)
                {
                    MessageBox.Show("Este libro ya no puede ser reservado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se puede reservar");
                    
                }
            }
            else {
                MessageBox.Show("Este libro esta disponible :) ");
            }
        }

        private void cliente_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cliente = "";
            cliente = conexion.Cargar_libros();
            String[] clientes = cliente.Split('/');
            for (int a = 0; a < clientes.Count(); a++)
            {

                cliente_box.Items.Add(clientes[a]);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla = "Prestamo";
            columnas = "Fecha_prestamo,Fecha_devolucion,cliente,cod_libro";
           String aux1 = lb_combo.SelectedItem.ToString();
            valores = "'5/5/5''6/5/5''201314881''7'";
            valores = "'" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + cliente_box.SelectedItem.ToString() + "','" + aux1 + "'";

            if (conexion.Registrar(tabla, columnas, valores))
            {
                MessageBox.Show("Prestamo realizado");

            }
            else {
                MessageBox.Show("la cagaste puto");
            }
            
        }
    }
}
