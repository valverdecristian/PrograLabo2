namespace Introduccion
{
    partial class Principal
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
            tbx_nombre = new TextBox();
            txb_apellido = new TextBox();
            lb_nombre = new Label();
            lb_apellido = new Label();
            btn_saludar = new Button();
            SuspendLayout();
            // 
            // tbx_nombre
            // 
            tbx_nombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_nombre.Location = new Point(12, 83);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new Size(174, 35);
            tbx_nombre.TabIndex = 0;
            // 
            // txb_apellido
            // 
            txb_apellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_apellido.Location = new Point(206, 83);
            txb_apellido.Name = "txb_apellido";
            txb_apellido.Size = new Size(174, 35);
            txb_apellido.TabIndex = 1;
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.BackColor = SystemColors.Control;
            lb_nombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nombre.Location = new Point(12, 48);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(94, 30);
            lb_nombre.TabIndex = 2;
            lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            lb_apellido.AutoSize = true;
            lb_apellido.BackColor = SystemColors.Control;
            lb_apellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_apellido.Location = new Point(206, 48);
            lb_apellido.Name = "lb_apellido";
            lb_apellido.Size = new Size(96, 30);
            lb_apellido.TabIndex = 3;
            lb_apellido.Text = "Apellido";
            // 
            // btn_saludar
            // 
            btn_saludar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_saludar.Location = new Point(127, 141);
            btn_saludar.Name = "btn_saludar";
            btn_saludar.Size = new Size(142, 36);
            btn_saludar.TabIndex = 4;
            btn_saludar.Text = "Saludar";
            btn_saludar.UseVisualStyleBackColor = true;
            btn_saludar.Click += btn_saludar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(399, 208);
            Controls.Add(btn_saludar);
            Controls.Add(lb_apellido);
            Controls.Add(lb_nombre);
            Controls.Add(txb_apellido);
            Controls.Add(tbx_nombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_nombre;
        private TextBox txb_apellido;
        private Label lb_nombre;
        private Label lb_apellido;
        private Button btn_saludar;
    }
}