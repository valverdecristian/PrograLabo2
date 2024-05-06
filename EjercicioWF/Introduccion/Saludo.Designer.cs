namespace Introduccion
{
    partial class SaludoForm
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
            lbl_mensaje = new Label();
            SuspendLayout();
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mensaje.Location = new Point(37, 68);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(77, 23);
            lbl_mensaje.TabIndex = 0;
            lbl_mensaje.Text = "label1";
            // 
            // SaludoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(398, 206);
            Controls.Add(lbl_mensaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaludoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_mensaje;
    }
}