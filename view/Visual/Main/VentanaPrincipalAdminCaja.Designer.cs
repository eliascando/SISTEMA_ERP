namespace view.Visual
{
    partial class VentanaPrincipalAdminCaja
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
            panelVentasMenu = new Panel();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            btnVentas = new Button();
            btnLogout = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            horayfecha = new System.Windows.Forms.Timer(components);
            panelContenedor.SuspendLayout();
            panelInfo.SuspendLayout();
            panelMenu.SuspendLayout();
            panelVentasMenu.SuspendLayout();
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
            panelMenu.Controls.Add(panelVentasMenu);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnLogout);
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
            btnAyuda.Location = new Point(0, 375);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(10, 0, 0, 0);
            btnAyuda.Size = new Size(229, 40);
            btnAyuda.TabIndex = 14;
            btnAyuda.Text = "Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // panelVentasMenu
            // 
            panelVentasMenu.BackColor = Color.MediumSlateBlue;
            panelVentasMenu.Controls.Add(button13);
            panelVentasMenu.Controls.Add(button12);
            panelVentasMenu.Controls.Add(button11);
            panelVentasMenu.Controls.Add(button10);
            panelVentasMenu.Controls.Add(button9);
            panelVentasMenu.Dock = DockStyle.Top;
            panelVentasMenu.Location = new Point(0, 164);
            panelVentasMenu.Name = "panelVentasMenu";
            panelVentasMenu.Size = new Size(229, 211);
            panelVentasMenu.TabIndex = 13;
            // 
            // button13
            // 
            button13.BackColor = Color.MediumSlateBlue;
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = SystemColors.Control;
            button13.Location = new Point(0, 160);
            button13.Name = "button13";
            button13.Padding = new Padding(35, 0, 0, 0);
            button13.Size = new Size(229, 40);
            button13.TabIndex = 4;
            button13.Text = "button13";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumSlateBlue;
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(0, 120);
            button12.Name = "button12";
            button12.Padding = new Padding(35, 0, 0, 0);
            button12.Size = new Size(229, 40);
            button12.TabIndex = 3;
            button12.Text = "button12";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.MediumSlateBlue;
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(0, 80);
            button11.Name = "button11";
            button11.Padding = new Padding(35, 0, 0, 0);
            button11.Size = new Size(229, 40);
            button11.TabIndex = 2;
            button11.Text = "button11";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.MediumSlateBlue;
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(0, 40);
            button10.Name = "button10";
            button10.Padding = new Padding(35, 0, 0, 0);
            button10.Size = new Size(229, 40);
            button10.TabIndex = 1;
            button10.Text = "button10";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.MediumSlateBlue;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(229, 40);
            button9.TabIndex = 0;
            button9.Text = "button9";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.DarkSlateBlue;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = SystemColors.Control;
            btnVentas.Location = new Point(0, 124);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(229, 40);
            btnVentas.TabIndex = 12;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
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
            // VentanaPrincipalAdminCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 567);
            Controls.Add(panelContenedor);
            Controls.Add(panelInfo);
            Controls.Add(panelMenu);
            Name = "VentanaPrincipalAdminCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalAdminCaja";
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelVentasMenu.ResumeLayout(false);
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
        private Button btnLogout;
        private Panel panelLogo;
        private Label label1;
        private Panel panelVentasMenu;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button btnVentas;
        private System.Windows.Forms.Timer horayfecha;
    }
}