namespace Practica1_IPC2
{
    partial class Form2
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.carnet_box = new System.Windows.Forms.TextBox();
            this.dpi_box = new System.Windows.Forms.TextBox();
            this.dir_box = new System.Windows.Forms.TextBox();
            this.Nombre_box = new System.Windows.Forms.TextBox();
            this.tele_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whizz Hard Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DPI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carné";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carnet_box
            // 
            this.carnet_box.Location = new System.Drawing.Point(62, 88);
            this.carnet_box.Name = "carnet_box";
            this.carnet_box.Size = new System.Drawing.Size(100, 20);
            this.carnet_box.TabIndex = 8;
            // 
            // dpi_box
            // 
            this.dpi_box.Location = new System.Drawing.Point(62, 155);
            this.dpi_box.Name = "dpi_box";
            this.dpi_box.Size = new System.Drawing.Size(100, 20);
            this.dpi_box.TabIndex = 9;
            // 
            // dir_box
            // 
            this.dir_box.Location = new System.Drawing.Point(62, 198);
            this.dir_box.Name = "dir_box";
            this.dir_box.Size = new System.Drawing.Size(172, 20);
            this.dir_box.TabIndex = 10;
            // 
            // Nombre_box
            // 
            this.Nombre_box.Location = new System.Drawing.Point(62, 121);
            this.Nombre_box.Name = "Nombre_box";
            this.Nombre_box.Size = new System.Drawing.Size(149, 20);
            this.Nombre_box.TabIndex = 11;
            // 
            // tele_box
            // 
            this.tele_box.Location = new System.Drawing.Point(62, 242);
            this.tele_box.Name = "tele_box";
            this.tele_box.Size = new System.Drawing.Size(115, 20);
            this.tele_box.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 331);
            this.Controls.Add(this.tele_box);
            this.Controls.Add(this.Nombre_box);
            this.Controls.Add(this.dir_box);
            this.Controls.Add(this.dpi_box);
            this.Controls.Add(this.carnet_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Nuevo Usuario";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox carnet_box;
        private System.Windows.Forms.TextBox dpi_box;
        private System.Windows.Forms.TextBox dir_box;
        private System.Windows.Forms.TextBox Nombre_box;
        private System.Windows.Forms.TextBox tele_box;
    }
}