﻿namespace view.Visual.Personal
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
            label4 = new Label();
            lblCedulaPersonal = new Label();
            PassStatusIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).BeginInit();
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
            // PassStatusIcon
            // 
            PassStatusIcon.BackColor = SystemColors.Window;
            PassStatusIcon.Image = Properties.Resources.hide_pass;
            PassStatusIcon.Location = new Point(270, 111);
            PassStatusIcon.Name = "PassStatusIcon";
            PassStatusIcon.Size = new Size(23, 19);
            PassStatusIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PassStatusIcon.TabIndex = 14;
            PassStatusIcon.TabStop = false;
            PassStatusIcon.Click += PassStatusIcon_Click;
            // 
            // CambiarCredenciales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 252);
            Controls.Add(PassStatusIcon);
            Controls.Add(lblCedulaPersonal);
            Controls.Add(label4);
            Controls.Add(txtConfirmNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CambiarCredenciales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambiarCredenciales";
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).EndInit();
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
        private Label label4;
        public Label lblCedulaPersonal;
        private PictureBox PassStatusIcon;
    }
}