namespace Practica1_IPC2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.libro_box = new System.Windows.Forms.ComboBox();
            this.autor_text = new System.Windows.Forms.TextBox();
            this.existencia_text = new System.Windows.Forms.TextBox();
            this.Dispo_text = new System.Windows.Forms.TextBox();
            this.prest_text = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nomb_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reser_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Libros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prestamos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disponibles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Autor";
            // 
            // libro_box
            // 
            this.libro_box.FormattingEnabled = true;
            this.libro_box.Location = new System.Drawing.Point(119, 67);
            this.libro_box.Name = "libro_box";
            this.libro_box.Size = new System.Drawing.Size(121, 21);
            this.libro_box.TabIndex = 6;
            this.libro_box.SelectedIndexChanged += new System.EventHandler(this.libro_box_SelectedIndexChanged);
            // 
            // autor_text
            // 
            this.autor_text.Location = new System.Drawing.Point(85, 109);
            this.autor_text.Name = "autor_text";
            this.autor_text.Size = new System.Drawing.Size(155, 20);
            this.autor_text.TabIndex = 7;
            // 
            // existencia_text
            // 
            this.existencia_text.Location = new System.Drawing.Point(85, 198);
            this.existencia_text.Name = "existencia_text";
            this.existencia_text.Size = new System.Drawing.Size(26, 20);
            this.existencia_text.TabIndex = 8;
            // 
            // Dispo_text
            // 
            this.Dispo_text.Location = new System.Drawing.Point(85, 244);
            this.Dispo_text.Name = "Dispo_text";
            this.Dispo_text.Size = new System.Drawing.Size(26, 20);
            this.Dispo_text.TabIndex = 9;
            // 
            // prest_text
            // 
            this.prest_text.Location = new System.Drawing.Point(85, 290);
            this.prest_text.Name = "prest_text";
            this.prest_text.Size = new System.Drawing.Size(26, 20);
            this.prest_text.TabIndex = 10;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(216, 297);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // nomb_text
            // 
            this.nomb_text.Location = new System.Drawing.Point(74, 156);
            this.nomb_text.Name = "nomb_text";
            this.nomb_text.Size = new System.Drawing.Size(155, 20);
            this.nomb_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reservados";
            // 
            // reser_text
            // 
            this.reser_text.Location = new System.Drawing.Point(85, 337);
            this.reser_text.Name = "reser_text";
            this.reser_text.Size = new System.Drawing.Size(26, 20);
            this.reser_text.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 359);
            this.Controls.Add(this.reser_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nomb_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.prest_text);
            this.Controls.Add(this.Dispo_text);
            this.Controls.Add(this.existencia_text);
            this.Controls.Add(this.autor_text);
            this.Controls.Add(this.libro_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox libro_box;
        private System.Windows.Forms.TextBox autor_text;
        private System.Windows.Forms.TextBox existencia_text;
        private System.Windows.Forms.TextBox Dispo_text;
        private System.Windows.Forms.TextBox prest_text;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomb_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reser_text;
    }
}