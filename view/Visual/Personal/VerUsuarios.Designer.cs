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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panelUsuarios = new Panel();
            gridUsuarios = new DataGridView();
            btnActualizar = new utilitaries.CustomControls.CustomButton();
            btnVerUsuario = new utilitaries.CustomControls.CustomButton();
            btnCerrar = new utilitaries.CustomControls.CustomButton();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 18);
            label1.Name = "label1";
            label1.Size = new Size(141, 33);
            label1.TabIndex = 3;
            label1.Text = "Usuarios";
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(gridUsuarios);
            panelUsuarios.Controls.Add(btnActualizar);
            panelUsuarios.Controls.Add(btnVerUsuario);
            panelUsuarios.Controls.Add(btnCerrar);
            panelUsuarios.Controls.Add(label1);
            panelUsuarios.Dock = DockStyle.Fill;
            panelUsuarios.Location = new Point(0, 0);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(729, 514);
            panelUsuarios.TabIndex = 5;
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AllowUserToResizeColumns = false;
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.BackgroundColor = SystemColors.ControlLight;
            gridUsuarios.BorderStyle = BorderStyle.None;
            gridUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridUsuarios.ColumnHeadersHeight = 30;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkSalmon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            gridUsuarios.EnableHeadersVisualStyles = false;
            gridUsuarios.Location = new Point(31, 63);
            gridUsuarios.MultiSelect = false;
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            gridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.ScrollBars = ScrollBars.None;
            gridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridUsuarios.Size = new Size(663, 393);
            gridUsuarios.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = Color.MediumSlateBlue;
            btnActualizar.BackgroundColor = Color.MediumSlateBlue;
            btnActualizar.BorderColor = Color.PaleVioletRed;
            btnActualizar.BorderRadius = 22;
            btnActualizar.BorderSize = 0;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(604, 472);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextColor = Color.White;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVerUsuario
            // 
            btnVerUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerUsuario.BackColor = Color.MediumSlateBlue;
            btnVerUsuario.BackgroundColor = Color.MediumSlateBlue;
            btnVerUsuario.BorderColor = Color.PaleVioletRed;
            btnVerUsuario.BorderRadius = 22;
            btnVerUsuario.BorderSize = 0;
            btnVerUsuario.FlatAppearance.BorderSize = 0;
            btnVerUsuario.FlatStyle = FlatStyle.Flat;
            btnVerUsuario.ForeColor = Color.White;
            btnVerUsuario.Location = new Point(508, 472);
            btnVerUsuario.Name = "btnVerUsuario";
            btnVerUsuario.Size = new Size(90, 30);
            btnVerUsuario.TabIndex = 8;
            btnVerUsuario.Text = "Ver Usuario";
            btnVerUsuario.TextColor = Color.White;
            btnVerUsuario.UseVisualStyleBackColor = false;
            btnVerUsuario.Click += btnVerUsuario_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.BackColor = Color.MediumSlateBlue;
            btnCerrar.BackgroundColor = Color.MediumSlateBlue;
            btnCerrar.BorderColor = Color.PaleVioletRed;
            btnCerrar.BorderRadius = 22;
            btnCerrar.BorderSize = 0;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(31, 472);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 30);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 514);
            Controls.Add(panelUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerUsuarios";
            Load += VerUsuarios_prueba_Load;
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panelUsuarios;
        private utilitaries.CustomControls.CustomButton btnCerrar;
        private utilitaries.CustomControls.CustomButton btnActualizar;
        private utilitaries.CustomControls.CustomButton btnVerUsuario;
        private DataGridView gridUsuarios;
    }
}