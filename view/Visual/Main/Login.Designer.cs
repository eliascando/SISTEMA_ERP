namespace view.Visual
{
    partial class Login
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
            txtId = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            Loading = new PictureBox();
            AlertId = new PictureBox();
            AlertPass = new PictureBox();
            lblMensaje = new Label();
            panelLogo = new Panel();
            ExitIco = new PictureBox();
            panelLogin = new Panel();
            linklblForgotPass = new LinkLabel();
            PassStatusIcon = new PictureBox();
            lblIngreseCredenciales = new Label();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlertId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlertPass).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitIco).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 106);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 161);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 219);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(194, 180);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Location = new Point(194, 237);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(173, 23);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(215, 296);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Loading
            // 
            Loading.Anchor = AnchorStyles.None;
            Loading.Image = Properties.Resources.ajax_loader;
            Loading.Location = new Point(241, 278);
            Loading.Name = "Loading";
            Loading.Size = new Size(80, 73);
            Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            Loading.TabIndex = 7;
            Loading.TabStop = false;
            // 
            // AlertId
            // 
            AlertId.Anchor = AnchorStyles.None;
            AlertId.Image = Properties.Resources.alert;
            AlertId.InitialImage = Properties.Resources.alert;
            AlertId.Location = new Point(373, 180);
            AlertId.Name = "AlertId";
            AlertId.Size = new Size(24, 23);
            AlertId.SizeMode = PictureBoxSizeMode.StretchImage;
            AlertId.TabIndex = 8;
            AlertId.TabStop = false;
            // 
            // AlertPass
            // 
            AlertPass.Anchor = AnchorStyles.None;
            AlertPass.Image = Properties.Resources.alert;
            AlertPass.Location = new Point(373, 237);
            AlertPass.Name = "AlertPass";
            AlertPass.Size = new Size(24, 23);
            AlertPass.SizeMode = PictureBoxSizeMode.StretchImage;
            AlertPass.TabIndex = 9;
            AlertPass.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.Brown;
            lblMensaje.Location = new Point(170, 274);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(234, 15);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Debe ingresar todos los campos!";
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ActiveCaption;
            panelLogo.Controls.Add(ExitIco);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 450);
            panelLogo.TabIndex = 12;
            // 
            // ExitIco
            // 
            ExitIco.Image = Properties.Resources.exit_left_ico;
            ExitIco.Location = new Point(12, 398);
            ExitIco.Name = "ExitIco";
            ExitIco.Size = new Size(41, 40);
            ExitIco.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitIco.TabIndex = 12;
            ExitIco.TabStop = false;
            ExitIco.Click += ExitIco_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.InactiveCaption;
            panelLogin.Controls.Add(linklblForgotPass);
            panelLogin.Controls.Add(PassStatusIcon);
            panelLogin.Controls.Add(lblIngreseCredenciales);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(AlertPass);
            panelLogin.Controls.Add(txtPass);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(Loading);
            panelLogin.Controls.Add(lblMensaje);
            panelLogin.Controls.Add(txtId);
            panelLogin.Controls.Add(AlertId);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(label2);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(229, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(571, 450);
            panelLogin.TabIndex = 13;
            // 
            // linklblForgotPass
            // 
            linklblForgotPass.AutoSize = true;
            linklblForgotPass.Location = new Point(433, 423);
            linklblForgotPass.Name = "linklblForgotPass";
            linklblForgotPass.Size = new Size(126, 15);
            linklblForgotPass.TabIndex = 14;
            linklblForgotPass.TabStop = true;
            linklblForgotPass.Text = "Olvidó Su Contraseña?";
            linklblForgotPass.LinkClicked += linklblForgotPass_LinkClicked;
            // 
            // PassStatusIcon
            // 
            PassStatusIcon.BackColor = SystemColors.Window;
            PassStatusIcon.Image = Properties.Resources.hide_pass;
            PassStatusIcon.Location = new Point(343, 239);
            PassStatusIcon.Name = "PassStatusIcon";
            PassStatusIcon.Size = new Size(23, 19);
            PassStatusIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PassStatusIcon.TabIndex = 13;
            PassStatusIcon.TabStop = false;
            PassStatusIcon.Click += PassStatusIcon_Click;
            // 
            // lblIngreseCredenciales
            // 
            lblIngreseCredenciales.AutoSize = true;
            lblIngreseCredenciales.Location = new Point(212, 133);
            lblIngreseCredenciales.Name = "lblIngreseCredenciales";
            lblIngreseCredenciales.Size = new Size(133, 15);
            lblIngreseCredenciales.TabIndex = 11;
            lblIngreseCredenciales.Text = "Ingrese sus credenciales";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Controls.Add(panelLogo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlertId).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlertPass).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExitIco).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtPass;
        private Button btnLogin;
        private PictureBox Loading;
        private PictureBox AlertId;
        private PictureBox AlertPass;
        private Label lblMensaje;
        private Panel panelLogo;
        public Panel panelLogin;
        private Label lblIngreseCredenciales;
        private PictureBox ExitIco;
        private PictureBox PassStatusIcon;
        private LinkLabel linklblForgotPass;
    }
}