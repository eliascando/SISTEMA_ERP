namespace view.Visual
{
    partial class VentanaPrincipalAdminBodega
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
            lblNombreUsuarioAdminB = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblNombreUsuarioAdminB
            // 
            lblNombreUsuarioAdminB.AutoSize = true;
            lblNombreUsuarioAdminB.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioAdminB.Location = new Point(12, 416);
            lblNombreUsuarioAdminB.Name = "lblNombreUsuarioAdminB";
            lblNombreUsuarioAdminB.Size = new Size(192, 25);
            lblNombreUsuarioAdminB.TabIndex = 3;
            lblNombreUsuarioAdminB.Text = "NombresUsuario";
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
            // VentanaPrincipalAdminBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblNombreUsuarioAdminB);
            Name = "VentanaPrincipalAdminBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalAdminBodega";
            Load += VentanaPrincipalAdminBodega_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblNombreUsuarioAdminB;
        private Button btnLogout;
    }
}