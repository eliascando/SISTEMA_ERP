namespace view.Visual.Main
{
    partial class ForgotPassword
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
            lblIngreseCredenciales = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSendEmailStatus = new Label();
            lblValidateOTP = new Label();
            Loading = new PictureBox();
            btnEnviar = new utilitaries.CustomControls.CustomButton();
            txtId = new utilitaries.CustomControls.CustomTextBox();
            txtOTP = new utilitaries.CustomControls.CustomTextBox();
            btnValidar = new utilitaries.CustomControls.CustomButton();
            btnCancelar = new utilitaries.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            SuspendLayout();
            // 
            // lblIngreseCredenciales
            // 
            lblIngreseCredenciales.AutoSize = true;
            lblIngreseCredenciales.Location = new Point(101, 143);
            lblIngreseCredenciales.Name = "lblIngreseCredenciales";
            lblIngreseCredenciales.Size = new Size(362, 15);
            lblIngreseCredenciales.TabIndex = 16;
            lblIngreseCredenciales.Text = "Se enviará un correo con la clave OTP para restablecer la contraseña";
            lblIngreseCredenciales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 108);
            label1.Name = "label1";
            label1.Size = new Size(302, 25);
            label1.TabIndex = 12;
            label1.Text = "Reestablecer Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 180);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 13;
            label2.Text = "Ingrese su ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 252);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 18;
            label3.Text = "Ingrese clave OTP:";
            // 
            // lblSendEmailStatus
            // 
            lblSendEmailStatus.AutoSize = true;
            lblSendEmailStatus.Location = new Point(209, 231);
            lblSendEmailStatus.Name = "lblSendEmailStatus";
            lblSendEmailStatus.Size = new Size(90, 15);
            lblSendEmailStatus.TabIndex = 20;
            lblSendEmailStatus.Text = "Estado de envío";
            lblSendEmailStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValidateOTP
            // 
            lblValidateOTP.AutoSize = true;
            lblValidateOTP.Location = new Point(217, 303);
            lblValidateOTP.Name = "lblValidateOTP";
            lblValidateOTP.Size = new Size(82, 15);
            lblValidateOTP.TabIndex = 22;
            lblValidateOTP.Text = "Estado de OTP";
            lblValidateOTP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            Loading.Anchor = AnchorStyles.None;
            Loading.Image = Properties.Resources.ajax_loader;
            Loading.Location = new Point(361, 186);
            Loading.Name = "Loading";
            Loading.Size = new Size(54, 52);
            Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            Loading.TabIndex = 23;
            Loading.TabStop = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.MediumSlateBlue;
            btnEnviar.BackgroundColor = Color.MediumSlateBlue;
            btnEnviar.BorderColor = Color.PaleVioletRed;
            btnEnviar.BorderRadius = 28;
            btnEnviar.BorderSize = 0;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(342, 197);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 30);
            btnEnviar.TabIndex = 24;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextColor = Color.White;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.BorderColor = Color.MediumSlateBlue;
            txtId.BorderFocusColor = Color.HotPink;
            txtId.BorderRadius = 25;
            txtId.BorderSize = 2;
            txtId.Location = new Point(154, 198);
            txtId.MaxLenght = 32767;
            txtId.Modified = false;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(10, 7, 10, 7);
            txtId.PasswordChar = false;
            txtId.Size = new Size(182, 30);
            txtId.TabIndex = 25;
            txtId.Texts = "";
            txtId.UnderlineStyle = false;
            // 
            // txtOTP
            // 
            txtOTP.BackColor = SystemColors.Window;
            txtOTP.BorderColor = Color.MediumSlateBlue;
            txtOTP.BorderFocusColor = Color.HotPink;
            txtOTP.BorderRadius = 25;
            txtOTP.BorderSize = 2;
            txtOTP.Location = new Point(154, 270);
            txtOTP.MaxLenght = 32767;
            txtOTP.Modified = false;
            txtOTP.Multiline = false;
            txtOTP.Name = "txtOTP";
            txtOTP.Padding = new Padding(10, 7, 10, 7);
            txtOTP.PasswordChar = false;
            txtOTP.Size = new Size(274, 30);
            txtOTP.TabIndex = 26;
            txtOTP.Texts = "";
            txtOTP.UnderlineStyle = false;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.MediumSlateBlue;
            btnValidar.BackgroundColor = Color.MediumSlateBlue;
            btnValidar.BorderColor = Color.PaleVioletRed;
            btnValidar.BorderRadius = 28;
            btnValidar.BorderSize = 0;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(250, 321);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(86, 30);
            btnValidar.TabIndex = 27;
            btnValidar.Text = "Validar";
            btnValidar.TextColor = Color.White;
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MediumSlateBlue;
            btnCancelar.BackgroundColor = Color.MediumSlateBlue;
            btnCancelar.BorderColor = Color.PaleVioletRed;
            btnCancelar.BorderRadius = 28;
            btnCancelar.BorderSize = 0;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(473, 408);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 30);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(571, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnValidar);
            Controls.Add(txtOTP);
            Controls.Add(txtId);
            Controls.Add(btnEnviar);
            Controls.Add(Loading);
            Controls.Add(lblValidateOTP);
            Controls.Add(lblSendEmailStatus);
            Controls.Add(label3);
            Controls.Add(lblIngreseCredenciales);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)Loading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIngreseCredenciales;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label lblSendEmailStatus;
        public Label lblValidateOTP;
        private PictureBox Loading;
        private utilitaries.CustomControls.CustomButton btnEnviar;
        private utilitaries.CustomControls.CustomTextBox txtId;
        private utilitaries.CustomControls.CustomTextBox txtOTP;
        private utilitaries.CustomControls.CustomButton btnValidar;
        private utilitaries.CustomControls.CustomButton btnCancelar;
    }
}