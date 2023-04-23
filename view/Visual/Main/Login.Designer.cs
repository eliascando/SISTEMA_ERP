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
            Loading = new PictureBox();
            panelLogo = new Panel();
            ExitIco = new PictureBox();
            panelLogin = new Panel();
            panel1 = new Panel();
            PassStatusIcon = new PictureBox();
            txtPass = new utilitaries.CustomControls.CustomTextBox();
            txtId = new utilitaries.CustomControls.CustomTextBox();
            btnLogin = new utilitaries.CustomControls.CustomButton();
            linklblForgotPass = new LinkLabel();
            lblIngreseCredenciales = new Label();
            customRoundedForms1 = new utilitaries.CustomComponents.CustomRoundedForms();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitIco).BeginInit();
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
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
            // Loading
            // 
            Loading.Anchor = AnchorStyles.None;
            Loading.Image = Properties.Resources.ajax_loader;
            Loading.Location = new Point(242, 278);
            Loading.Name = "Loading";
            Loading.Size = new Size(80, 73);
            Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            Loading.TabIndex = 7;
            Loading.TabStop = false;
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
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(txtPass);
            panelLogin.Controls.Add(txtId);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(linklblForgotPass);
            panelLogin.Controls.Add(lblIngreseCredenciales);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(Loading);
            panelLogin.Controls.Add(label2);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(229, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(571, 450);
            panelLogin.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(PassStatusIcon);
            panel1.Location = new Point(339, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(27, 23);
            panel1.TabIndex = 17;
            // 
            // PassStatusIcon
            // 
            PassStatusIcon.BackColor = SystemColors.InactiveCaption;
            PassStatusIcon.Dock = DockStyle.Fill;
            PassStatusIcon.Image = Properties.Resources.hide_pass;
            PassStatusIcon.Location = new Point(0, 0);
            PassStatusIcon.Name = "PassStatusIcon";
            PassStatusIcon.Size = new Size(27, 23);
            PassStatusIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PassStatusIcon.TabIndex = 13;
            PassStatusIcon.TabStop = false;
            PassStatusIcon.Click += PassStatusIcon_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.InactiveCaption;
            txtPass.BorderColor = Color.MediumSlateBlue;
            txtPass.BorderFocusColor = Color.HotPink;
            txtPass.BorderRadius = 0;
            txtPass.BorderSize = 2;
            txtPass.Location = new Point(194, 237);
            txtPass.MaxLenght = 32767;
            txtPass.Modified = false;
            txtPass.Multiline = false;
            txtPass.Name = "txtPass";
            txtPass.Padding = new Padding(10, 7, 10, 7);
            txtPass.PasswordChar = false;
            txtPass.Size = new Size(172, 30);
            txtPass.TabIndex = 2;
            txtPass.Texts = "";
            txtPass.UnderlineStyle = true;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.BorderColor = Color.MediumSlateBlue;
            txtId.BorderFocusColor = Color.HotPink;
            txtId.BorderRadius = 0;
            txtId.BorderSize = 2;
            txtId.Location = new Point(194, 179);
            txtId.MaxLenght = 32767;
            txtId.Modified = false;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(10, 7, 10, 7);
            txtId.PasswordChar = false;
            txtId.Size = new Size(172, 30);
            txtId.TabIndex = 1;
            txtId.Texts = "";
            txtId.UnderlineStyle = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.BackgroundColor = Color.MediumSlateBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 30;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(194, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linklblForgotPass
            // 
            linklblForgotPass.ActiveLinkColor = Color.HotPink;
            linklblForgotPass.AutoSize = true;
            linklblForgotPass.LinkColor = Color.DarkSlateBlue;
            linklblForgotPass.Location = new Point(433, 423);
            linklblForgotPass.Name = "linklblForgotPass";
            linklblForgotPass.Size = new Size(126, 15);
            linklblForgotPass.TabIndex = 4;
            linklblForgotPass.TabStop = true;
            linklblForgotPass.Text = "Olvidó Su Contraseña?";
            linklblForgotPass.LinkClicked += linklblForgotPass_LinkClicked;
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
            // customRoundedForms1
            // 
            customRoundedForms1.CornerRedius = 40;
            customRoundedForms1.TargetControl = this;
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
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExitIco).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox Loading;
        private Panel panelLogo;
        public Panel panelLogin;
        private Label lblIngreseCredenciales;
        private PictureBox ExitIco;
        private PictureBox PassStatusIcon;
        private LinkLabel linklblForgotPass;
        private utilitaries.CustomControls.CustomButton btnLogin;
        private utilitaries.CustomControls.CustomTextBox txtId;
        private utilitaries.CustomControls.CustomTextBox txtPass;
        private Panel panel1;
        private utilitaries.CustomComponents.CustomRoundedForms customRoundedForms1;
    }
}