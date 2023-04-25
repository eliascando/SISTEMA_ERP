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
            components = new System.ComponentModel.Container();
            panelContenedor = new Panel();
            label2 = new Label();
            panelInfo = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            lblNombreUsuario = new Label();
            panelMenu = new Panel();
            btnAyuda = new Button();
            panelRRHHMenu = new Panel();
            btnVerUsuarios = new Button();
            btnRegistrarPersonal = new Button();
            btnRegistrarGerente = new Button();
            btnLogout = new Button();
            btnRRHH = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            horayfecha = new System.Windows.Forms.Timer(components);
            panelContenedor.SuspendLayout();
            panelInfo.SuspendLayout();
            panelMenu.SuspendLayout();
            panelRRHHMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(label2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(229, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(729, 519);
            panelContenedor.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(267, 216);
            label2.Name = "label2";
            label2.Size = new Size(189, 79);
            label2.TabIndex = 1;
            label2.Text = "LoGo";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.SteelBlue;
            panelInfo.Controls.Add(lblFecha);
            panelInfo.Controls.Add(lblHora);
            panelInfo.Controls.Add(lblNombreUsuario);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(229, 519);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(729, 48);
            panelInfo.TabIndex = 15;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.Control;
            lblFecha.Location = new Point(3, 25);
            lblFecha.Margin = new Padding(0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 19);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.Control;
            lblHora.Location = new Point(3, 3);
            lblHora.Margin = new Padding(0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(62, 25);
            lblHora.TabIndex = 4;
            lblHora.Text = "Hora";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = SystemColors.Control;
            lblNombreUsuario.Location = new Point(534, 14);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(192, 25);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "NombresUsuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(btnAyuda);
            panelMenu.Controls.Add(panelRRHHMenu);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnRRHH);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 567);
            panelMenu.TabIndex = 14;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.DarkSlateBlue;
            btnAyuda.Dock = DockStyle.Top;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.ForeColor = SystemColors.Control;
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
            panelRRHHMenu.BackColor = Color.MediumSlateBlue;
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
            btnVerUsuarios.BackColor = Color.MediumSlateBlue;
            btnVerUsuarios.Dock = DockStyle.Top;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.ForeColor = SystemColors.Control;
            btnVerUsuarios.Location = new Point(0, 80);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Padding = new Padding(35, 0, 0, 0);
            btnVerUsuarios.Size = new Size(229, 40);
            btnVerUsuarios.TabIndex = 2;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnVerUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPersonal
            // 
            btnRegistrarPersonal.BackColor = Color.MediumSlateBlue;
            btnRegistrarPersonal.Dock = DockStyle.Top;
            btnRegistrarPersonal.FlatAppearance.BorderSize = 0;
            btnRegistrarPersonal.FlatStyle = FlatStyle.Flat;
            btnRegistrarPersonal.ForeColor = SystemColors.Control;
            btnRegistrarPersonal.Location = new Point(0, 40);
            btnRegistrarPersonal.Name = "btnRegistrarPersonal";
            btnRegistrarPersonal.Padding = new Padding(35, 0, 0, 0);
            btnRegistrarPersonal.Size = new Size(229, 40);
            btnRegistrarPersonal.TabIndex = 1;
            btnRegistrarPersonal.Text = "Registrar Personal";
            btnRegistrarPersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPersonal.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarGerente
            // 
            btnRegistrarGerente.BackColor = Color.MediumSlateBlue;
            btnRegistrarGerente.Dock = DockStyle.Top;
            btnRegistrarGerente.FlatAppearance.BorderSize = 0;
            btnRegistrarGerente.FlatStyle = FlatStyle.Flat;
            btnRegistrarGerente.ForeColor = SystemColors.Control;
            btnRegistrarGerente.Location = new Point(0, 0);
            btnRegistrarGerente.Name = "btnRegistrarGerente";
            btnRegistrarGerente.Padding = new Padding(35, 0, 0, 0);
            btnRegistrarGerente.Size = new Size(229, 40);
            btnRegistrarGerente.TabIndex = 0;
            btnRegistrarGerente.Text = "Registrar Gerente";
            btnRegistrarGerente.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarGerente.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkOrchid;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 519);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 48);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRRHH
            // 
            btnRRHH.BackColor = Color.DarkSlateBlue;
            btnRRHH.Dock = DockStyle.Top;
            btnRRHH.FlatAppearance.BorderSize = 0;
            btnRRHH.FlatStyle = FlatStyle.Flat;
            btnRRHH.ForeColor = SystemColors.Control;
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
            panelLogo.BackColor = Color.LightSteelBlue;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 124);
            panelLogo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(203, 79);
            label1.TabIndex = 0;
            label1.Text = "LoGo";
            // 
            // horayfecha
            // 
            horayfecha.Enabled = true;
            horayfecha.Tick += horayfecha_Tick;
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
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelRRHHMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Label label2;
        private Panel panelInfo;
        private Label lblFecha;
        private Label lblHora;
        private Label lblNombreUsuario;
        private Panel panelMenu;
        private Button btnAyuda;
        private Panel panelRRHHMenu;
        private Button btnVerUsuarios;
        private Button btnRegistrarPersonal;
        private Button btnRegistrarGerente;
        private Button btnLogout;
        private Button btnRRHH;
        private Panel panelLogo;
        private Label label1;
        private System.Windows.Forms.Timer horayfecha;
    }
}