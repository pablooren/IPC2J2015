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
    public partial class Form3 : Form
    {
        private String tabla = "";
        private String columnas = "";
        private String valores = "";
        private ServiceReference1.ServiceSoapClient conexion = new ServiceReference1.ServiceSoapClient(); 
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla = "Libro";
            columnas = "Nombre,Num_existencia,No_paginas,Tema,Autor,Disponible,Prestados,Reservados";
            valores = "'" + noli_text.Text + "','" + Exist_text.Text + "','" + pags_text.Text + "','" + tema_text.Text + "','" + autor_text.Text + "','" + Exist_text.Text + "','" + "0" + "','" +"0"+ "'";
            if (conexion.Registrar(tabla, columnas, valores))
            {
                MessageBox.Show("Libro  creado");
                this.Close();
                
            }
        }
    }
}
