namespace FrmTest
{
    partial class FrmTest
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
            btnSalir = new Button();
            btnVender = new Button();
            btnVerInforme = new Button();
            lstStock = new ListBox();
            rtbInforme = new RichTextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(41, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 48);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVender
            // 
            btnVender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.Location = new Point(169, 362);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(108, 48);
            btnVender.TabIndex = 1;
            btnVender.Text = "VENDER";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerInforme.Location = new Point(294, 362);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(139, 48);
            btnVerInforme.TabIndex = 2;
            btnVerInforme.Text = "VER INFORME";
            btnVerInforme.UseVisualStyleBackColor = true;
            btnVerInforme.Click += btnVerInforme_Click;
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 15;
            lstStock.Location = new Point(12, 12);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(265, 334);
            lstStock.TabIndex = 3;
            // 
            // rtbInforme
            // 
            rtbInforme.Location = new Point(294, 12);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(265, 334);
            rtbInforme.TabIndex = 4;
            rtbInforme.Text = "";
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(576, 450);
            Controls.Add(rtbInforme);
            Controls.Add(lstStock);
            Controls.Add(btnVerInforme);
            Controls.Add(btnVender);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tester App de Cristian Valverde (323)";
            FormClosing += FrmTest_FormClosing;
            Load += TesterAppDeCristianValverde323_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnVender;
        private Button btnVerInforme;
        private ListBox lstStock;
        private RichTextBox rtbInforme;
    }
}