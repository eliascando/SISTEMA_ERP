namespace view.Visual.Personal
{
    partial class CambiarCredenciales
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
            btnActualizar = new Button();
            btnCancelar = new Button();
            txtNewPass = new TextBox();
            txtConfirmNewPass = new TextBox();
            AlertIcon = new PictureBox();
            AlertMessage = new Label();
            label4 = new Label();
            lblCedulaPersonal = new Label();
            ((System.ComponentModel.ISupportInitialize)AlertIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 91);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 135);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirmar Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 30);
            label3.Name = "label3";
            label3.Size = new Size(203, 19);
            label3.TabIndex = 2;
            label3.Text = "Cambiar Credenciales";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(220, 207);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(100, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(100, 109);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(195, 23);
            txtNewPass.TabIndex = 5;
            // 
            // txtConfirmNewPass
            // 
            txtConfirmNewPass.Location = new Point(100, 153);
            txtConfirmNewPass.Name = "txtConfirmNewPass";
            txtConfirmNewPass.Size = new Size(195, 23);
            txtConfirmNewPass.TabIndex = 6;
            // 
            // AlertIcon
            // 
            AlertIcon.Image = Properties.Resources.alert;
            AlertIcon.Location = new Point(301, 153);
            AlertIcon.Name = "AlertIcon";
            AlertIcon.Size = new Size(23, 23);
            AlertIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            AlertIcon.TabIndex = 7;
            AlertIcon.TabStop = false;
            // 
            // AlertMessage
            // 
            AlertMessage.AutoSize = true;
            AlertMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AlertMessage.ForeColor = Color.DarkRed;
            AlertMessage.Location = new Point(32, 182);
            AlertMessage.Name = "AlertMessage";
            AlertMessage.Size = new Size(354, 17);
            AlertMessage.TabIndex = 8;
            AlertMessage.Text = "La Nueva Contraseña  y la Confirmación deben coincidir";
            AlertMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 64);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Cédula:";
            // 
            // lblCedulaPersonal
            // 
            lblCedulaPersonal.AutoSize = true;
            lblCedulaPersonal.Location = new Point(153, 64);
            lblCedulaPersonal.Name = "lblCedulaPersonal";
            lblCedulaPersonal.Size = new Size(89, 15);
            lblCedulaPersonal.TabIndex = 10;
            lblCedulaPersonal.Text = "CedulaPersonal";
            // 
            // CambiarCredenciales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 252);
            Controls.Add(lblCedulaPersonal);
            Controls.Add(label4);
            Controls.Add(AlertMessage);
            Controls.Add(AlertIcon);
            Controls.Add(txtConfirmNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CambiarCredenciales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambiarCredenciales";
            ((System.ComponentModel.ISupportInitialize)AlertIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnActualizar;
        private Button btnCancelar;
        private TextBox txtNewPass;
        private TextBox txtConfirmNewPass;
        private PictureBox AlertIcon;
        private Label AlertMessage;
        private Label label4;
        public Label lblCedulaPersonal;
    }
}