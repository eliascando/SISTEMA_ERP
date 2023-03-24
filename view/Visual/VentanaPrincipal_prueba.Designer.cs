namespace view
{
    partial class VentanaPrincipal_prueba
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
            button2 = new Button();
            lblNombreUsuario = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(266, 107);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 0;
            button1.Text = "Registrar Nuevo Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 163);
            button2.Name = "button2";
            button2.Size = new Size(169, 40);
            button2.TabIndex = 1;
            button2.Text = "Registrar Usuario Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(12, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(192, 25);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "NombresUsuario";
            // 
            // button3
            // 
            button3.Location = new Point(266, 209);
            button3.Name = "button3";
            button3.Size = new Size(169, 40);
            button3.TabIndex = 3;
            button3.Text = "Ver Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // VentanaPrincipal_prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(lblNombreUsuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VentanaPrincipal_prueba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipal";
            Load += VentanaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblNombreUsuario;
        private Button button3;
    }
}