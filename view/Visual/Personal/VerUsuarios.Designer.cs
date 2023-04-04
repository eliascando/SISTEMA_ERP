namespace view.Visual
{
    partial class VerUsuarios
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
            gridUsuarios = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            btnActualizar = new Button();
            panelUsuarios = new Panel();
            panelBotones = new Panel();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            panelUsuarios.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AllowUserToResizeColumns = false;
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.Anchor = AnchorStyles.None;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(31, 73);
            gridUsuarios.MultiSelect = false;
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(665, 346);
            gridUsuarios.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(533, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Ver Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(141, 33);
            label1.TabIndex = 3;
            label1.Text = "Usuarios";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.Location = new Point(629, 28);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(gridUsuarios);
            panelUsuarios.Controls.Add(label1);
            panelUsuarios.Dock = DockStyle.Top;
            panelUsuarios.Location = new Point(0, 0);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(729, 451);
            panelUsuarios.TabIndex = 5;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCerrar);
            panelBotones.Controls.Add(button1);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 451);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(729, 63);
            panelBotones.TabIndex = 6;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(31, 27);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 514);
            Controls.Add(panelBotones);
            Controls.Add(panelUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerUsuarios";
            Load += VerUsuarios_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridUsuarios;
        private Button button1;
        private Label label1;
        private Button btnActualizar;
        private Panel panelUsuarios;
        private Panel panelBotones;
        private Button btnCerrar;
    }
}