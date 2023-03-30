namespace view.Visual
{
    partial class VentanaPrincipalGG
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
            lblNombreUsuario = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(12, 416);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(192, 25);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "NombresUsuario";
            // 
            // button3
            // 
            button3.Location = new Point(316, 246);
            button3.Name = "button3";
            button3.Size = new Size(169, 40);
            button3.TabIndex = 6;
            button3.Text = "Ver Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(316, 154);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 4;
            button1.Text = "Registrar Gerente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 200);
            button2.Name = "button2";
            button2.Size = new Size(169, 40);
            button2.TabIndex = 5;
            button2.Text = "Registrar Nuevo Personal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(671, 402);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // VentanaPrincipalGG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblNombreUsuario);
            Name = "VentanaPrincipalGG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalGG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button btnLogout;
    }
}