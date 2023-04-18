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
            btnCancelar = new Button();
            lblIngreseCredenciales = new Label();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            btnEnviarOTP = new Button();
            txtOTP = new TextBox();
            label3 = new Label();
            lblSendEmailStatus = new Label();
            btnValidar = new Button();
            lblValidateOTP = new Label();
            Loading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(484, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(154, 198);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 14;
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
            // btnEnviarOTP
            // 
            btnEnviarOTP.Location = new Point(333, 198);
            btnEnviarOTP.Name = "btnEnviarOTP";
            btnEnviarOTP.Size = new Size(75, 23);
            btnEnviarOTP.TabIndex = 17;
            btnEnviarOTP.Text = "Enviar";
            btnEnviarOTP.UseVisualStyleBackColor = true;
            btnEnviarOTP.Click += btnEnviarOTP_Click;
            // 
            // txtOTP
            // 
            txtOTP.Anchor = AnchorStyles.None;
            txtOTP.Location = new Point(154, 270);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(254, 23);
            txtOTP.TabIndex = 19;
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
            lblSendEmailStatus.Location = new Point(209, 226);
            lblSendEmailStatus.Name = "lblSendEmailStatus";
            lblSendEmailStatus.Size = new Size(90, 15);
            lblSendEmailStatus.TabIndex = 20;
            lblSendEmailStatus.Text = "Estado de envío";
            lblSendEmailStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(209, 321);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(140, 28);
            btnValidar.TabIndex = 21;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidateOTP
            // 
            lblValidateOTP.AutoSize = true;
            lblValidateOTP.Location = new Point(209, 296);
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
            Loading.Location = new Point(344, 182);
            Loading.Name = "Loading";
            Loading.Size = new Size(54, 52);
            Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            Loading.TabIndex = 23;
            Loading.TabStop = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(Loading);
            Controls.Add(lblValidateOTP);
            Controls.Add(btnValidar);
            Controls.Add(lblSendEmailStatus);
            Controls.Add(txtOTP);
            Controls.Add(label3);
            Controls.Add(btnEnviarOTP);
            Controls.Add(lblIngreseCredenciales);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)Loading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label lblIngreseCredenciales;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Button btnEnviarOTP;
        private TextBox txtOTP;
        private Label label3;
        public Label lblSendEmailStatus;
        private Button btnValidar;
        public Label lblValidateOTP;
        private PictureBox Loading;
    }
}