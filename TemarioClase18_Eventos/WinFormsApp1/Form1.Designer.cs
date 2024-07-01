namespace WinFormsApp1
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
            btn_EnviarNewsletterTecnologia = new Button();
            btn_EnviarNewsletterFinanzas = new Button();
            SuspendLayout();
            // 
            // btn_EnviarNewsletterTecnologia
            // 
            btn_EnviarNewsletterTecnologia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EnviarNewsletterTecnologia.Location = new Point(23, 27);
            btn_EnviarNewsletterTecnologia.Name = "btn_EnviarNewsletterTecnologia";
            btn_EnviarNewsletterTecnologia.Size = new Size(219, 95);
            btn_EnviarNewsletterTecnologia.TabIndex = 0;
            btn_EnviarNewsletterTecnologia.Text = "Enviar Newsletter Tecnologia";
            btn_EnviarNewsletterTecnologia.UseVisualStyleBackColor = true;
            // 
            // btn_EnviarNewsletterFinanzas
            // 
            btn_EnviarNewsletterFinanzas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EnviarNewsletterFinanzas.Location = new Point(258, 27);
            btn_EnviarNewsletterFinanzas.Name = "btn_EnviarNewsletterFinanzas";
            btn_EnviarNewsletterFinanzas.Size = new Size(219, 95);
            btn_EnviarNewsletterFinanzas.TabIndex = 1;
            btn_EnviarNewsletterFinanzas.Text = "Enviar Newsletter Finanzas";
            btn_EnviarNewsletterFinanzas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 148);
            Controls.Add(btn_EnviarNewsletterFinanzas);
            Controls.Add(btn_EnviarNewsletterTecnologia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_EnviarNewsletterTecnologia;
        private Button btn_EnviarNewsletterFinanzas;
    }
}