namespace view.Visual
{
    partial class VentanaPrincipalAsistente
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
            lblNombreUsuarioAsistente = new Label();
            SuspendLayout();
            // 
            // lblNombreUsuarioAsistente
            // 
            lblNombreUsuarioAsistente.AutoSize = true;
            lblNombreUsuarioAsistente.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioAsistente.Location = new Point(12, 416);
            lblNombreUsuarioAsistente.Name = "lblNombreUsuarioAsistente";
            lblNombreUsuarioAsistente.Size = new Size(192, 25);
            lblNombreUsuarioAsistente.TabIndex = 3;
            lblNombreUsuarioAsistente.Text = "NombresUsuario";
            // 
            // VentanaPrincipalAsistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreUsuarioAsistente);
            Name = "VentanaPrincipalAsistente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalAsistente";
            Load += VentanaPrincipalAsistente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblNombreUsuarioAsistente;
        private Label lblNombreUsuario;
    }
}