namespace view
{
    partial class RegistroDatosUsuario_prueba
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
            picFotoPersonal = new PictureBox();
            groupBox1 = new GroupBox();
            lblCargoPersonal = new Label();
            lblApellidosPersonal = new Label();
            blbNombresPersonal = new Label();
            lblIdCedula = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnAddImagen = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotoPersonal).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 18);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Usuario";
            // 
            // picFotoPersonal
            // 
            picFotoPersonal.Location = new Point(230, 22);
            picFotoPersonal.Name = "picFotoPersonal";
            picFotoPersonal.Size = new Size(87, 110);
            picFotoPersonal.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoPersonal.TabIndex = 1;
            picFotoPersonal.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCargoPersonal);
            groupBox1.Controls.Add(lblApellidosPersonal);
            groupBox1.Controls.Add(blbNombresPersonal);
            groupBox1.Controls.Add(lblIdCedula);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 152);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Personal";
            // 
            // lblCargoPersonal
            // 
            lblCargoPersonal.AutoSize = true;
            lblCargoPersonal.Location = new Point(94, 121);
            lblCargoPersonal.Name = "lblCargoPersonal";
            lblCargoPersonal.Size = new Size(84, 15);
            lblCargoPersonal.TabIndex = 7;
            lblCargoPersonal.Text = "CargoPersonal";
            // 
            // lblApellidosPersonal
            // 
            lblApellidosPersonal.AutoSize = true;
            lblApellidosPersonal.Location = new Point(94, 88);
            lblApellidosPersonal.Name = "lblApellidosPersonal";
            lblApellidosPersonal.Size = new Size(101, 15);
            lblApellidosPersonal.TabIndex = 6;
            lblApellidosPersonal.Text = "ApellidosPersonal";
            // 
            // blbNombresPersonal
            // 
            blbNombresPersonal.AutoSize = true;
            blbNombresPersonal.Location = new Point(94, 57);
            blbNombresPersonal.Name = "blbNombresPersonal";
            blbNombresPersonal.Size = new Size(101, 15);
            blbNombresPersonal.TabIndex = 5;
            blbNombresPersonal.Text = "NombresPersonal";
            // 
            // lblIdCedula
            // 
            lblIdCedula.AutoSize = true;
            lblIdCedula.Location = new Point(94, 29);
            lblIdCedula.Name = "lblIdCedula";
            lblIdCedula.Size = new Size(89, 15);
            lblIdCedula.TabIndex = 4;
            lblIdCedula.Text = "CédulaPersonal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 121);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 88);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 57);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 29);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Cédula:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddImagen);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(picFotoPersonal);
            groupBox2.Location = new Point(25, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 171);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Usuario";
            // 
            // btnAddImagen
            // 
            btnAddImagen.Location = new Point(230, 136);
            btnAddImagen.Name = "btnAddImagen";
            btnAddImagen.Size = new Size(87, 23);
            btnAddImagen.TabIndex = 6;
            btnAddImagen.Text = "Añadir Foto";
            btnAddImagen.UseVisualStyleBackColor = true;
            btnAddImagen.Click += btnAddImagen_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(16, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(16, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 98);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 3;
            label7.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 34);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(286, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(25, 416);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistroDatosUsuario_prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 452);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "RegistroDatosUsuario_prueba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroDatosUsuario_prueba";
            Load += RegistroDatosUsuario_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoPersonal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picFotoPersonal;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Button btnAddImagen;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button btnGuardar;
        private Button btnCancelar;
        public Label lblCargoPersonal;
        public Label lblApellidosPersonal;
        public Label blbNombresPersonal;
        public Label lblIdCedula;
    }
}