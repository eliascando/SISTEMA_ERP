namespace view.Visual
{
    partial class VerDatosUsuario
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
            tabActividades = new TabControl();
            tabInicioSesion = new TabPage();
            dgvInicioSesion = new DataGridView();
            tabVentas = new TabPage();
            dgvVentas = new DataGridView();
            tabPage1 = new TabPage();
            dgvModificaciones = new DataGridView();
            lblVentasMes = new Label();
            lblVentas = new Label();
            lblID = new Label();
            label7 = new Label();
            lblFechaIngreso = new Label();
            lblEdad = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblUsuario = new Label();
            lblCargo = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNombreUsuario = new Label();
            picFotoUsuario = new PictureBox();
            ReloadBtn = new PictureBox();
            btnSalir = new Button();
            tabActividades.SuspendLayout();
            tabInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInicioSesion).BeginInit();
            tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReloadBtn).BeginInit();
            SuspendLayout();
            // 
            // tabActividades
            // 
            tabActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabActividades.Controls.Add(tabInicioSesion);
            tabActividades.Controls.Add(tabVentas);
            tabActividades.Controls.Add(tabPage1);
            tabActividades.Location = new Point(12, 190);
            tabActividades.Name = "tabActividades";
            tabActividades.SelectedIndex = 0;
            tabActividades.Size = new Size(705, 281);
            tabActividades.TabIndex = 24;
            // 
            // tabInicioSesion
            // 
            tabInicioSesion.Controls.Add(dgvInicioSesion);
            tabInicioSesion.Location = new Point(4, 24);
            tabInicioSesion.Name = "tabInicioSesion";
            tabInicioSesion.Padding = new Padding(3);
            tabInicioSesion.Size = new Size(697, 253);
            tabInicioSesion.TabIndex = 0;
            tabInicioSesion.Text = "Inicios de Sesion";
            tabInicioSesion.UseVisualStyleBackColor = true;
            // 
            // dgvInicioSesion
            // 
            dgvInicioSesion.AllowUserToAddRows = false;
            dgvInicioSesion.AllowUserToDeleteRows = false;
            dgvInicioSesion.AllowUserToResizeColumns = false;
            dgvInicioSesion.AllowUserToResizeRows = false;
            dgvInicioSesion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInicioSesion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInicioSesion.Dock = DockStyle.Fill;
            dgvInicioSesion.Location = new Point(3, 3);
            dgvInicioSesion.MultiSelect = false;
            dgvInicioSesion.Name = "dgvInicioSesion";
            dgvInicioSesion.ReadOnly = true;
            dgvInicioSesion.RowHeadersVisible = false;
            dgvInicioSesion.RowTemplate.Height = 25;
            dgvInicioSesion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInicioSesion.Size = new Size(691, 247);
            dgvInicioSesion.TabIndex = 0;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(dgvVentas);
            tabVentas.Location = new Point(4, 24);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(3);
            tabVentas.Size = new Size(697, 253);
            tabVentas.TabIndex = 1;
            tabVentas.Text = "Registro de Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 3);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(691, 247);
            dgvVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvModificaciones);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(697, 253);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Registro de Modificaciones";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvModificaciones
            // 
            dgvModificaciones.AllowUserToAddRows = false;
            dgvModificaciones.AllowUserToDeleteRows = false;
            dgvModificaciones.AllowUserToResizeColumns = false;
            dgvModificaciones.AllowUserToResizeRows = false;
            dgvModificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModificaciones.Dock = DockStyle.Fill;
            dgvModificaciones.Location = new Point(0, 0);
            dgvModificaciones.Name = "dgvModificaciones";
            dgvModificaciones.ReadOnly = true;
            dgvModificaciones.RowHeadersVisible = false;
            dgvModificaciones.RowTemplate.Height = 25;
            dgvModificaciones.Size = new Size(697, 253);
            dgvModificaciones.TabIndex = 0;
            // 
            // lblVentasMes
            // 
            lblVentasMes.AutoSize = true;
            lblVentasMes.Location = new Point(368, 157);
            lblVentasMes.Name = "lblVentasMes";
            lblVentasMes.Size = new Size(104, 15);
            lblVentasMes.TabIndex = 62;
            lblVentasMes.Text = "TotalVentasdelMes";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Location = new Point(285, 157);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(69, 15);
            lblVentas.TabIndex = 61;
            lblVentas.Text = "Ventas Mes:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(130, 63);
            lblID.Name = "lblID";
            lblID.Size = new Size(57, 15);
            lblID.TabIndex = 60;
            lblID.Text = "IdUsuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 63);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 59;
            label7.Text = "ID:";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(130, 157);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(77, 15);
            lblFechaIngreso.TabIndex = 58;
            lblFechaIngreso.Text = "FechaIngreso";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(368, 93);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(73, 15);
            lblEdad.TabIndex = 57;
            lblEdad.Text = "EdadUsuario";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(368, 125);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(83, 15);
            lblCorreo.TabIndex = 56;
            lblCorreo.Text = "CorreoUsuario";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(130, 125);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(92, 15);
            lblTelefono.TabIndex = 55;
            lblTelefono.Text = "TelefonoUsuario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(130, 93);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 54;
            lblUsuario.Text = "Usuario";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(368, 63);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(79, 15);
            lblCargo.TabIndex = 53;
            lblCargo.Text = "CargoUsuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 157);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 52;
            label6.Text = "Fecha Ingreso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 93);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 51;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 125);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 50;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 125);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 49;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 63);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 48;
            label2.Text = "Cargo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 47;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(47, 18);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(194, 25);
            lblNombreUsuario.TabIndex = 46;
            lblNombreUsuario.Text = "NombreUsuario";
            lblNombreUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // picFotoUsuario
            // 
            picFotoUsuario.Location = new Point(569, 50);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(94, 122);
            picFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoUsuario.TabIndex = 45;
            picFotoUsuario.TabStop = false;
            // 
            // ReloadBtn
            // 
            ReloadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReloadBtn.Image = Properties.Resources.noun_reload_hold;
            ReloadBtn.Location = new Point(685, 474);
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.Size = new Size(28, 28);
            ReloadBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ReloadBtn.TabIndex = 63;
            ReloadBtn.TabStop = false;
            ReloadBtn.Click += ReloadBtn_Click;
            ReloadBtn.MouseDown += ReloadBtn_MouseDown;
            ReloadBtn.MouseUp += ReloadBtn_MouseUp;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.Location = new Point(16, 479);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 64;
            btnSalir.Text = "Atrás";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // VerDatosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 514);
            Controls.Add(btnSalir);
            Controls.Add(ReloadBtn);
            Controls.Add(lblVentasMes);
            Controls.Add(lblVentas);
            Controls.Add(lblID);
            Controls.Add(label7);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblEdad);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblUsuario);
            Controls.Add(lblCargo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreUsuario);
            Controls.Add(picFotoUsuario);
            Controls.Add(tabActividades);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerDatosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerDatosUsuario";
            Load += VerDatosUsuario_Load;
            tabActividades.ResumeLayout(false);
            tabInicioSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInicioSesion).EndInit();
            tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvModificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReloadBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabActividades;
        private TabPage tabInicioSesion;
        private DataGridView dgvInicioSesion;
        private TabPage tabVentas;
        private DataGridView dgvVentas;
        private Label lblVentasMes;
        private Label lblVentas;
        public Label lblID;
        private Label label7;
        public Label lblFechaIngreso;
        public Label lblEdad;
        public Label lblCorreo;
        public Label lblTelefono;
        public Label lblUsuario;
        public Label lblCargo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Label lblNombreUsuario;
        public PictureBox picFotoUsuario;
        private PictureBox ReloadBtn;
        private Button btnSalir;
        private TabPage tabPage1;
        private DataGridView dgvModificaciones;
    }
}