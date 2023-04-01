namespace view.Visual
{
    partial class VentanaPrincipalAdminCaja
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
            lblNombreUsuarioAdminC = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblNombreUsuarioAdminC
            // 
            lblNombreUsuarioAdminC.AutoSize = true;
            lblNombreUsuarioAdminC.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioAdminC.Location = new Point(12, 416);
            lblNombreUsuarioAdminC.Name = "lblNombreUsuarioAdminC";
            lblNombreUsuarioAdminC.Size = new Size(192, 25);
            lblNombreUsuarioAdminC.TabIndex = 3;
            lblNombreUsuarioAdminC.Text = "NombresUsuario";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(671, 402);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 36);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // VentanaPrincipalAdminCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblNombreUsuarioAdminC);
            Name = "VentanaPrincipalAdminCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalAdminCaja";
            Load += VentanaPrincipalAdminCaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblNombreUsuarioAdminC;
        private Button btnLogout;
    }
}