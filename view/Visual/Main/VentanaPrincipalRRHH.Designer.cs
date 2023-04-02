namespace view.Visual
{
    partial class VentanaPrincipalRRHH
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
            button1 = new Button();
            button3 = new Button();
            btnLogout = new Button();
            panelMenu = new Panel();
            btnAyuda = new Button();
            panelRRHHMenu = new Panel();
            btnVerUsuarios = new Button();
            btnRegistrarPersonal = new Button();
            btnRegistrarGerente = new Button();
            button2 = new Button();
            btnRRHH = new Button();
            panelLogo = new Panel();
            lblNombreUsuario = new Label();
            panelInfo = new Panel();
            lblNombreUsuarioRRHH = new Label();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            panelRRHHMenu.SuspendLayout();
            panelInfo.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(185, 122);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 1;
            button1.Text = "Registrar Nuevo Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(185, 179);
            button3.Name = "button3";
            button3.Size = new Size(169, 40);
            button3.TabIndex = 4;
            button3.Text = "Ver Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(209, 246);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 36);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.SandyBrown;
            panelMenu.Controls.Add(btnAyuda);
            panelMenu.Controls.Add(panelRRHHMenu);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnRRHH);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 567);
            panelMenu.TabIndex = 9;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.Bisque;
            btnAyuda.Dock = DockStyle.Top;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Location = new Point(0, 287);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(10, 0, 0, 0);
            btnAyuda.Size = new Size(229, 40);
            btnAyuda.TabIndex = 14;
            btnAyuda.Text = "Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // panelRRHHMenu
            // 
            panelRRHHMenu.BackColor = Color.PeachPuff;
            panelRRHHMenu.Controls.Add(btnVerUsuarios);
            panelRRHHMenu.Controls.Add(btnRegistrarPersonal);
            panelRRHHMenu.Controls.Add(btnRegistrarGerente);
            panelRRHHMenu.Dock = DockStyle.Top;
            panelRRHHMenu.Location = new Point(0, 162);
            panelRRHHMenu.Name = "panelRRHHMenu";
            panelRRHHMenu.Size = new Size(229, 125);
            panelRRHHMenu.TabIndex = 9;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Dock = DockStyle.Top;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.Location = new Point(0, 80);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Padding = new Padding(35, 0, 0, 0);
            btnVerUsuarios.Size = new Size(229, 40);
            btnVerUsuarios.TabIndex = 2;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnVerUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPersonal
            // 
            btnRegistrarPersonal.Dock = DockStyle.Top;
            btnRegistrarPersonal.FlatAppearance.BorderSize = 0;
            btnRegistrarPersonal.FlatStyle = FlatStyle.Flat;
            btnRegistrarPersonal.Location = new Point(0, 40);
            btnRegistrarPersonal.Name = "btnRegistrarPersonal";
            btnRegistrarPersonal.Padding = new Padding(35, 0, 0, 0);
            btnRegistrarPersonal.Size = new Size(229, 40);
            btnRegistrarPersonal.TabIndex = 1;
            btnRegistrarPersonal.Text = "Registrar Personal";
            btnRegistrarPersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarGerente
            // 
            btnRegistrarGerente.Dock = DockStyle.Top;
            btnRegistrarGerente.FlatAppearance.BorderSize = 0;
            btnRegistrarGerente.FlatStyle = FlatStyle.Flat;
            btnRegistrarGerente.Location = new Point(0, 0);
            btnRegistrarGerente.Name = "btnRegistrarGerente";
            btnRegistrarGerente.Padding = new Padding(35, 0, 0, 0);
            btnRegistrarGerente.Size = new Size(229, 40);
            btnRegistrarGerente.TabIndex = 0;
            btnRegistrarGerente.Text = "Registrar Gerente";
            btnRegistrarGerente.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarGerente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 519);
            button2.Name = "button2";
            button2.Size = new Size(229, 48);
            button2.TabIndex = 7;
            button2.Text = "Cerrar Sesión";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnRRHH
            // 
            btnRRHH.BackColor = Color.Bisque;
            btnRRHH.Dock = DockStyle.Top;
            btnRRHH.FlatAppearance.BorderSize = 0;
            btnRRHH.FlatAppearance.MouseOverBackColor = Color.Bisque;
            btnRRHH.FlatStyle = FlatStyle.Flat;
            btnRRHH.Location = new Point(0, 124);
            btnRRHH.Name = "btnRRHH";
            btnRRHH.Padding = new Padding(10, 0, 0, 0);
            btnRRHH.Size = new Size(229, 38);
            btnRRHH.TabIndex = 8;
            btnRRHH.Text = "Recursos Humanos";
            btnRRHH.TextAlign = ContentAlignment.MiddleLeft;
            btnRRHH.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Beige;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 124);
            panelLogo.TabIndex = 8;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(1063, -28);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(192, 25);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "NombresUsuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.LightGray;
            panelInfo.Controls.Add(lblNombreUsuarioRRHH);
            panelInfo.Controls.Add(lblNombreUsuario);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(229, 514);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(729, 53);
            panelInfo.TabIndex = 10;
            // 
            // lblNombreUsuarioRRHH
            // 
            lblNombreUsuarioRRHH.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNombreUsuarioRRHH.AutoSize = true;
            lblNombreUsuarioRRHH.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioRRHH.Location = new Point(525, 19);
            lblNombreUsuarioRRHH.Name = "lblNombreUsuarioRRHH";
            lblNombreUsuarioRRHH.Size = new Size(192, 25);
            lblNombreUsuarioRRHH.TabIndex = 4;
            lblNombreUsuarioRRHH.Text = "NombresUsuario";
            lblNombreUsuarioRRHH.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(button3);
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(btnLogout);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(229, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(729, 514);
            panelContenedor.TabIndex = 11;
            // 
            // VentanaPrincipalRRHH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 567);
            Controls.Add(panelContenedor);
            Controls.Add(panelInfo);
            Controls.Add(panelMenu);
            Name = "VentanaPrincipalRRHH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalRRHH";
            Load += VentanaPrincipalRRHH_Load;
            panelMenu.ResumeLayout(false);
            panelRRHHMenu.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button btnLogout;
        private Panel panelMenu;
        private Button btnAyuda;
        private Panel panelRRHHMenu;
        private Button btnVerUsuarios;
        private Button btnRegistrarPersonal;
        private Button btnRegistrarGerente;
        private Button button2;
        private Button btnRRHH;
        private Panel panelLogo;
        private Label lblNombreUsuario;
        private Panel panelInfo;
        private Label lblNombreUsuarioRRHH;
        private Panel panelContenedor;
    }
}