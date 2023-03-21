namespace view
{
    partial class InicioSesion_prueba
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIniciarSesion = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 41);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 34);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 77);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(90, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(161, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(141, 235);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(98, 34);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(51, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 132);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Credenciales";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // InicioSesion_prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 281);
            Controls.Add(groupBox1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label1);
            Name = "InicioSesion_prueba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion_prueba";
            Load += InicioSesion_prueba_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIniciarSesion;
        private GroupBox groupBox1;
    }
}