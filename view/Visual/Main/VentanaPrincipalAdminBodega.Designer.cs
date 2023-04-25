namespace view.Visual
{
    partial class VentanaPrincipalAdminBodega
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
            lblHora = new Label();
            lblFecha = new Label();
            lblNombreUsuario = new Label();
            panelMenu = new Panel();
            btnAyuda = new Button();
            panelAlmacenMenu = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnAlmacen = new Button();
            btnLogout = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            horayfecha = new System.Windows.Forms.Timer(components);
            panelContenedor.SuspendLayout();
            panelInfo.SuspendLayout();
            panelMenu.SuspendLayout();
            panelAlmacenMenu.SuspendLayout();
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
            panelInfo.Controls.Add(lblHora);
            panelInfo.Controls.Add(lblFecha);
            panelInfo.Controls.Add(lblNombreUsuario);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(229, 519);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(729, 48);
            panelInfo.TabIndex = 15;
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
            panelMenu.Controls.Add(panelAlmacenMenu);
            panelMenu.Controls.Add(btnAlmacen);
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
            btnAyuda.Location = new Point(0, 377);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(10, 0, 0, 0);
            btnAyuda.Size = new Size(229, 40);
            btnAyuda.TabIndex = 14;
            btnAyuda.Text = "Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // panelAlmacenMenu
            // 
            panelAlmacenMenu.BackColor = Color.MediumSlateBlue;
            panelAlmacenMenu.Controls.Add(button8);
            panelAlmacenMenu.Controls.Add(button7);
            panelAlmacenMenu.Controls.Add(button6);
            panelAlmacenMenu.Controls.Add(button5);
            panelAlmacenMenu.Controls.Add(button4);
            panelAlmacenMenu.Dock = DockStyle.Top;
            panelAlmacenMenu.Location = new Point(0, 164);
            panelAlmacenMenu.Name = "panelAlmacenMenu";
            panelAlmacenMenu.Size = new Size(229, 213);
            panelAlmacenMenu.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = Color.MediumSlateBlue;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(0, 160);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(229, 40);
            button8.TabIndex = 4;
            button8.Text = "button8";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumSlateBlue;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(0, 120);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(229, 40);
            button7.TabIndex = 3;
            button7.Text = "button7";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumSlateBlue;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(0, 80);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(229, 40);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(0, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(229, 40);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(229, 40);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnAlmacen
            // 
            btnAlmacen.BackColor = Color.DarkSlateBlue;
            btnAlmacen.Dock = DockStyle.Top;
            btnAlmacen.FlatAppearance.BorderSize = 0;
            btnAlmacen.FlatStyle = FlatStyle.Flat;
            btnAlmacen.ForeColor = SystemColors.Control;
            btnAlmacen.Location = new Point(0, 124);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Padding = new Padding(10, 0, 0, 0);
            btnAlmacen.Size = new Size(229, 40);
            btnAlmacen.TabIndex = 10;
            btnAlmacen.Text = "Almacén";
            btnAlmacen.TextAlign = ContentAlignment.MiddleLeft;
            btnAlmacen.UseVisualStyleBackColor = false;
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
            // VentanaPrincipalAdminBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 567);
            Controls.Add(panelContenedor);
            Controls.Add(panelInfo);
            Controls.Add(panelMenu);
            Name = "VentanaPrincipalAdminBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPrincipalAdminBodega";
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelAlmacenMenu.ResumeLayout(false);
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
        private Panel panelAlmacenMenu;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnAlmacen;
        private Button btnLogout;
        private Panel panelLogo;
        private Label label1;
        private System.Windows.Forms.Timer horayfecha;
    }
}