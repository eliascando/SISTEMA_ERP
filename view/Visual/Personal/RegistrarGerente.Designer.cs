namespace view.Visual
{
    partial class RegistrarGerente
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
            btnGuardar = new Button();
            rbtnSexoM = new RadioButton();
            rbtnSexoF = new RadioButton();
            dateIngreso = new DateTimePicker();
            dateNacimiento = new DateTimePicker();
            txtSalario = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtCedula = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnAddImagen = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label12 = new Label();
            label13 = new Label();
            picFotoPersonal = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picFotoPersonal).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(393, 334);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // rbtnSexoM
            // 
            rbtnSexoM.AutoSize = true;
            rbtnSexoM.Location = new Point(578, 107);
            rbtnSexoM.Name = "rbtnSexoM";
            rbtnSexoM.Size = new Size(80, 19);
            rbtnSexoM.TabIndex = 41;
            rbtnSexoM.TabStop = true;
            rbtnSexoM.Text = "Masculino";
            rbtnSexoM.UseVisualStyleBackColor = true;
            // 
            // rbtnSexoF
            // 
            rbtnSexoF.AutoSize = true;
            rbtnSexoF.Location = new Point(494, 107);
            rbtnSexoF.Name = "rbtnSexoF";
            rbtnSexoF.Size = new Size(78, 19);
            rbtnSexoF.TabIndex = 40;
            rbtnSexoF.TabStop = true;
            rbtnSexoF.Text = "Femenino";
            rbtnSexoF.UseVisualStyleBackColor = true;
            // 
            // dateIngreso
            // 
            dateIngreso.Format = DateTimePickerFormat.Short;
            dateIngreso.Location = new Point(494, 137);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(164, 23);
            dateIngreso.TabIndex = 45;
            // 
            // dateNacimiento
            // 
            dateNacimiento.Format = DateTimePickerFormat.Short;
            dateNacimiento.Location = new Point(160, 139);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(164, 23);
            dateNacimiento.TabIndex = 39;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(494, 211);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(164, 23);
            txtSalario.TabIndex = 46;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 211);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(164, 23);
            txtDireccion.TabIndex = 44;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(494, 174);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(164, 23);
            txtCorreo.TabIndex = 43;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(164, 23);
            txtTelefono.TabIndex = 42;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(494, 71);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(164, 23);
            txtApellidos.TabIndex = 37;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(160, 71);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(164, 23);
            txtNombres.TabIndex = 36;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(160, 105);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(164, 23);
            txtCedula.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(375, 219);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 34;
            label11.Text = "Salario Mensual:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 147);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 33;
            label10.Text = "Fecha Nacimiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 145);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 32;
            label9.Text = "Fecha Ingreso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 219);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 31;
            label8.Text = "Direccion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 182);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 30;
            label7.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 182);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 29;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 113);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 28;
            label5.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 79);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 26;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 25;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 113);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 24;
            label1.Text = "Cédula:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 23);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAddImagen
            // 
            btnAddImagen.Location = new Point(527, 431);
            btnAddImagen.Name = "btnAddImagen";
            btnAddImagen.Size = new Size(87, 23);
            btnAddImagen.TabIndex = 6;
            btnAddImagen.Text = "Añadir Foto";
            btnAddImagen.UseVisualStyleBackColor = true;
            btnAddImagen.Click += btnAddImagen_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(457, 275);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(84, 283);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 3;
            label12.Text = "Contraseña:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(393, 278);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 2;
            label13.Text = "Usuario:";
            // 
            // picFotoPersonal
            // 
            picFotoPersonal.Location = new Point(527, 315);
            picFotoPersonal.Name = "picFotoPersonal";
            picFotoPersonal.Size = new Size(87, 110);
            picFotoPersonal.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoPersonal.TabIndex = 1;
            picFotoPersonal.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 27);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 51;
            label4.Text = "Nuevo Gerente";
            // 
            // RegistrarGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 514);
            Controls.Add(txtPassword);
            Controls.Add(btnAddImagen);
            Controls.Add(label12);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(label13);
            Controls.Add(btnGuardar);
            Controls.Add(rbtnSexoM);
            Controls.Add(picFotoPersonal);
            Controls.Add(rbtnSexoF);
            Controls.Add(dateIngreso);
            Controls.Add(dateNacimiento);
            Controls.Add(txtSalario);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtCedula);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarGerente";
            ((System.ComponentModel.ISupportInitialize)picFotoPersonal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private RadioButton rbtnSexoM;
        private RadioButton rbtnSexoF;
        private DateTimePicker dateIngreso;
        private DateTimePicker dateNacimiento;
        private TextBox txtSalario;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtCedula;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAddImagen;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label12;
        private Label label13;
        private PictureBox picFotoPersonal;
        private Label label4;
    }
}