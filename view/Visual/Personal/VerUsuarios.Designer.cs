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
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AllowUserToResizeColumns = false;
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(30, 79);
            gridUsuarios.MultiSelect = false;
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(422, 225);
            gridUsuarios.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(211, 323);
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
            label1.Location = new Point(164, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 33);
            label1.TabIndex = 3;
            label1.Text = "Usuarios";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(377, 323);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 358);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(gridUsuarios);
            Name = "VerUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerUsuarios";
            Load += VerUsuarios_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUsuarios;
        private Button button1;
        private Label label1;
        private Button btnActualizar;
    }
}