namespace Registro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbl_Edad = new Label();
            lbl_Direccion = new Label();
            lbl_Nombre = new Label();
            txt_Nombre = new TextBox();
            txt_Direccion = new TextBox();
            num_Edad = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Edad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(num_Edad);
            groupBox1.Controls.Add(txt_Direccion);
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(lbl_Edad);
            groupBox1.Controls.Add(lbl_Direccion);
            groupBox1.Controls.Add(lbl_Nombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Edad.Location = new Point(23, 111);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(52, 21);
            lbl_Edad.TabIndex = 2;
            lbl_Edad.Text = "Edad:";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Direccion.Location = new Point(23, 75);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(87, 21);
            lbl_Direccion.TabIndex = 1;
            lbl_Direccion.Text = "Direccion:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(23, 37);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(77, 21);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(124, 35);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(109, 23);
            txt_Nombre.TabIndex = 3;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(124, 75);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(109, 23);
            txt_Direccion.TabIndex = 4;
            // 
            // num_Edad
            // 
            num_Edad.Location = new Point(124, 114);
            num_Edad.Name = "num_Edad";
            num_Edad.Size = new Size(109, 23);
            num_Edad.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "frm_principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Edad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_Edad;
        private Label lbl_Direccion;
        private Label lbl_Nombre;
        private NumericUpDown num_Edad;
        private TextBox txt_Direccion;
        private TextBox txt_Nombre;
    }
}