namespace view.Visual
{
    partial class VentanaPrincipalRRHH
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
            button1 = new Button();
            button3 = new Button();
            lblNombreUsuarioRRHH = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(288, 188);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 1;
            button1.Text = "Registrar Nuevo Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(288, 234);
            button3.Name = "button3";
            button3.Size = new Size(169, 40);
            button3.TabIndex = 4;
            button3.Text = "Ver Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblNombreUsuarioRRHH
            // 
            lblNombreUsuarioRRHH.AutoSize = true;
            lblNombreUsuarioRRHH.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioRRHH.Location = new Point(12, 416);
            lblNombreUsuarioRRHH.Name = "lblNombreUsuarioRRHH";
            lblNombreUsuarioRRHH.Size = new Size(192, 25);
            lblNombreUsuarioRRHH.TabIndex = 5;
            lblNombreUsuarioRRHH.Text = "NombresUsuario";
            // 
            // VentanaPrincipalRRHH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreUsuarioRRHH);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "VentanaPrincipalRRHH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalRRHH";
            Load += VentanaPrincipalRRHH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        public Label lblNombreUsuarioRRHH;
    }
}