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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            gridUsuarios = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            btnActualizar = new Button();
            panelUsuarios = new Panel();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            panelUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AllowUserToResizeColumns = false;
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkSalmon;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.DarkSalmon;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            gridUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            gridUsuarios.EnableHeadersVisualStyles = false;
            gridUsuarios.Location = new Point(22, 73);
            gridUsuarios.MultiSelect = false;
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 192, 192);
            gridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.ScrollBars = ScrollBars.None;
            gridUsuarios.Size = new Size(684, 371);
            gridUsuarios.TabIndex = 1;
            gridUsuarios.CellClick += gridUsuarios_CellClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(552, 479);
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
            btnActualizar.Location = new Point(642, 479);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(btnActualizar);
            panelUsuarios.Controls.Add(button1);
            panelUsuarios.Controls.Add(btnCerrar);
            panelUsuarios.Controls.Add(gridUsuarios);
            panelUsuarios.Controls.Add(label1);
            panelUsuarios.Dock = DockStyle.Fill;
            panelUsuarios.Location = new Point(0, 0);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(729, 514);
            panelUsuarios.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.Location = new Point(15, 479);
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
            Controls.Add(panelUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerUsuarios";
            Load += VerUsuarios_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridUsuarios;
        private Button button1;
        private Label label1;
        private Button btnActualizar;
        private Panel panelUsuarios;
        private Button btnCerrar;
    }
}