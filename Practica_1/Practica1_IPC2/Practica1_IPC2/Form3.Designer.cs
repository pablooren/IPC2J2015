namespace Practica1_IPC2
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pags_text = new System.Windows.Forms.TextBox();
            this.Exist_text = new System.Windows.Forms.TextBox();
            this.noli_text = new System.Windows.Forms.TextBox();
            this.tema_text = new System.Windows.Forms.TextBox();
            this.autor_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whizz Hard Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de Paginas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero de Existencias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre";
            // 
            // pags_text
            // 
            this.pags_text.Location = new System.Drawing.Point(133, 183);
            this.pags_text.Name = "pags_text";
            this.pags_text.Size = new System.Drawing.Size(100, 20);
            this.pags_text.TabIndex = 9;
            // 
            // Exist_text
            // 
            this.Exist_text.Location = new System.Drawing.Point(133, 144);
            this.Exist_text.Name = "Exist_text";
            this.Exist_text.Size = new System.Drawing.Size(100, 20);
            this.Exist_text.TabIndex = 10;
            // 
            // noli_text
            // 
            this.noli_text.Location = new System.Drawing.Point(133, 98);
            this.noli_text.Name = "noli_text";
            this.noli_text.Size = new System.Drawing.Size(100, 20);
            this.noli_text.TabIndex = 11;
            // 
            // tema_text
            // 
            this.tema_text.Location = new System.Drawing.Point(133, 223);
            this.tema_text.Name = "tema_text";
            this.tema_text.Size = new System.Drawing.Size(100, 20);
            this.tema_text.TabIndex = 12;
            // 
            // autor_text
            // 
            this.autor_text.Location = new System.Drawing.Point(133, 262);
            this.autor_text.Name = "autor_text";
            this.autor_text.Size = new System.Drawing.Size(100, 20);
            this.autor_text.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autor_text);
            this.Controls.Add(this.tema_text);
            this.Controls.Add(this.noli_text);
            this.Controls.Add(this.Exist_text);
            this.Controls.Add(this.pags_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pags_text;
        private System.Windows.Forms.TextBox Exist_text;
        private System.Windows.Forms.TextBox noli_text;
        private System.Windows.Forms.TextBox tema_text;
        private System.Windows.Forms.TextBox autor_text;
        private System.Windows.Forms.Button button1;
    }
}