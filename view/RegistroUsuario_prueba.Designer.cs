namespace view
{
    partial class RegistroUsuario_prueba
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
            datagridPersonalSinUsuario = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            btnActualizarLista = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridPersonalSinUsuario).BeginInit();
            SuspendLayout();
            // 
            // datagridPersonalSinUsuario
            // 
            datagridPersonalSinUsuario.AllowUserToAddRows = false;
            datagridPersonalSinUsuario.AllowUserToDeleteRows = false;
            datagridPersonalSinUsuario.AllowUserToResizeColumns = false;
            datagridPersonalSinUsuario.AllowUserToResizeRows = false;
            datagridPersonalSinUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridPersonalSinUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridPersonalSinUsuario.Location = new Point(18, 75);
            datagridPersonalSinUsuario.MultiSelect = false;
            datagridPersonalSinUsuario.Name = "datagridPersonalSinUsuario";
            datagridPersonalSinUsuario.ReadOnly = true;
            datagridPersonalSinUsuario.RowTemplate.Height = 25;
            datagridPersonalSinUsuario.Size = new Size(422, 225);
            datagridPersonalSinUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 34);
            label1.Name = "label1";
            label1.Size = new Size(267, 23);
            label1.TabIndex = 1;
            label1.Text = "Registrar Usuario Nuevo";
            // 
            // button1
            // 
            button1.Location = new Point(333, 327);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 2;
            button1.Text = "Añadir Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.Location = new Point(170, 327);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(116, 23);
            btnActualizarLista.TabIndex = 3;
            btnActualizarLista.Text = "Actualizar Lista";
            btnActualizarLista.UseVisualStyleBackColor = true;
            btnActualizarLista.Click += btnActualizarLista_Click;
            // 
            // RegistroUsuario_prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 374);
            Controls.Add(btnActualizarLista);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(datagridPersonalSinUsuario);
            Name = "RegistroUsuario_prueba";
            Text = "RegistroUsuario_prueba";
            Load += RegistroUsuario_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)datagridPersonalSinUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridPersonalSinUsuario;
        private Label label1;
        private Button button1;
        private Button btnActualizarLista;
    }
}