﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica1_IPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 usuario = new Form2();
            usuario.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 libro = new Form3();
            libro.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 consulta = new Form4();
            consulta.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 pres = new Form5();
            pres.Show();

        }

    }
}
