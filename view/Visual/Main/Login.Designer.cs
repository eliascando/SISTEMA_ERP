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
            button1 = new Button();
            Loading = new PictureBox();
            AlertId = new PictureBox();
            AlertPass = new PictureBox();
            lblMensaje = new Label();
            panel1 = new Panel();
            lblPanelSucces2 = new Label();
            lblPanelSucces1 = new Label();
            picturePanelSucces = new PictureBox();
            panelLogin = new Panel();
            lblPanelFail2 = new Label();
            lblPanelFail1 = new Label();
            picturePanelFail = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlertId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlertPass).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePanelSucces).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePanelFail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(534, 98);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 143);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 201);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtId
            // 
            txtId.Location = new Point(519, 162);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(519, 219);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(173, 23);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(539, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 400);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Loading
            // 
            Loading.Image = Properties.Resources.ajax_loader;
            Loading.Location = new Point(565, 250);
            Loading.Name = "Loading";
            Loading.Size = new Size(78, 76);
            Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            Loading.TabIndex = 7;
            Loading.TabStop = false;
            // 
            // AlertId
            // 
            AlertId.Image = Properties.Resources.alert;
            AlertId.InitialImage = Properties.Resources.alert;
            AlertId.Location = new Point(698, 162);
            AlertId.Name = "AlertId";
            AlertId.Size = new Size(24, 23);
            AlertId.SizeMode = PictureBoxSizeMode.StretchImage;
            AlertId.TabIndex = 8;
            AlertId.TabStop = false;
            // 
            // AlertPass
            // 
            AlertPass.Image = Properties.Resources.alert;
            AlertPass.Location = new Point(698, 219);
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
            lblMensaje.Location = new Point(497, 260);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(234, 15);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Debe ingresar todos los campos!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 452);
            panel1.TabIndex = 12;
            // 
            // lblPanelSucces2
            // 
            lblPanelSucces2.AutoSize = true;
            lblPanelSucces2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelSucces2.Location = new Point(73, 320);
            lblPanelSucces2.Name = "lblPanelSucces2";
            lblPanelSucces2.Size = new Size(181, 19);
            lblPanelSucces2.TabIndex = 5;
            lblPanelSucces2.Text = "MensajeBienvenida";
            // 
            // lblPanelSucces1
            // 
            lblPanelSucces1.AutoSize = true;
            lblPanelSucces1.Location = new Point(138, 288);
            lblPanelSucces1.Name = "lblPanelSucces1";
            lblPanelSucces1.Size = new Size(77, 15);
            lblPanelSucces1.TabIndex = 4;
            lblPanelSucces1.Text = "Inicio Exitoso";
            // 
            // picturePanelSucces
            // 
            picturePanelSucces.Image = Properties.Resources.success2;
            picturePanelSucces.Location = new Point(101, 100);
            picturePanelSucces.Name = "picturePanelSucces";
            picturePanelSucces.Size = new Size(171, 169);
            picturePanelSucces.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePanelSucces.TabIndex = 3;
            picturePanelSucces.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblPanelSucces2);
            panelLogin.Controls.Add(lblPanelFail2);
            panelLogin.Controls.Add(lblPanelSucces1);
            panelLogin.Controls.Add(lblPanelFail1);
            panelLogin.Controls.Add(picturePanelSucces);
            panelLogin.Controls.Add(picturePanelFail);
            panelLogin.Location = new Point(427, -1);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(373, 452);
            panelLogin.TabIndex = 13;
            // 
            // lblPanelFail2
            // 
            lblPanelFail2.AutoSize = true;
            lblPanelFail2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelFail2.Location = new Point(73, 320);
            lblPanelFail2.Name = "lblPanelFail2";
            lblPanelFail2.Size = new Size(229, 19);
            lblPanelFail2.TabIndex = 8;
            lblPanelFail2.Text = "Credenciales Incorrectas";
            // 
            // lblPanelFail1
            // 
            lblPanelFail1.AutoSize = true;
            lblPanelFail1.Location = new Point(166, 288);
            lblPanelFail1.Name = "lblPanelFail1";
            lblPanelFail1.Size = new Size(35, 15);
            lblPanelFail1.TabIndex = 7;
            lblPanelFail1.Text = "Error!";
            // 
            // picturePanelFail
            // 
            picturePanelFail.Image = Properties.Resources.failure;
            picturePanelFail.Location = new Point(101, 100);
            picturePanelFail.Name = "picturePanelFail";
            picturePanelFail.Size = new Size(171, 169);
            picturePanelFail.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePanelFail.TabIndex = 6;
            picturePanelFail.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            Controls.Add(Loading);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lblMensaje);
            Controls.Add(AlertPass);
            Controls.Add(label3);
            Controls.Add(AlertId);
            Controls.Add(btnLogin);
            Controls.Add(txtId);
            Controls.Add(txtPass);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlertId).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlertPass).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePanelSucces).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePanelFail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtPass;
        private Button btnLogin;
        private Button button1;
        private PictureBox Loading;
        private PictureBox AlertId;
        private PictureBox AlertPass;
        private Label lblMensaje;
        private Panel panel1;
        private Panel panelLogin;
        public Label lblPanelFail2;
        private Label lblPanelFail1;
        private PictureBox picturePanelFail;
        public Label lblPanelSucces2;
        private Label lblPanelSucces1;
        private PictureBox picturePanelSucces;
    }
}