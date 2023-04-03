namespace view.Visual.Main
{
    partial class FileKeyEncryptionNotFound
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
            pictureBox1 = new PictureBox();
            AlertMessage = new Label();
            label1 = new Label();
            txtKeyEncryption = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            PassStatusIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alert;
            pictureBox1.Location = new Point(220, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AlertMessage
            // 
            AlertMessage.AutoSize = true;
            AlertMessage.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AlertMessage.ForeColor = Color.Red;
            AlertMessage.Location = new Point(115, 173);
            AlertMessage.Name = "AlertMessage";
            AlertMessage.Size = new Size(289, 19);
            AlertMessage.TabIndex = 1;
            AlertMessage.Text = "Llave de cifrado no encontrada!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 245);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese llave de cifrado:";
            // 
            // txtKeyEncryption
            // 
            txtKeyEncryption.Location = new Point(175, 263);
            txtKeyEncryption.Name = "txtKeyEncryption";
            txtKeyEncryption.Size = new Size(178, 23);
            txtKeyEncryption.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 218);
            label2.Name = "label2";
            label2.Size = new Size(241, 25);
            label2.TabIndex = 4;
            label2.Text = "Consulte al administrador";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(214, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // PassStatusIcon
            // 
            PassStatusIcon.BackColor = SystemColors.Window;
            PassStatusIcon.Image = Properties.Resources.hide_pass;
            PassStatusIcon.Location = new Point(327, 265);
            PassStatusIcon.Name = "PassStatusIcon";
            PassStatusIcon.Size = new Size(23, 19);
            PassStatusIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PassStatusIcon.TabIndex = 14;
            PassStatusIcon.TabStop = false;
            PassStatusIcon.Click += PassStatusIcon_Click;
            // 
            // FileKeyEncryptionNotFound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 411);
            Controls.Add(PassStatusIcon);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtKeyEncryption);
            Controls.Add(label1);
            Controls.Add(AlertMessage);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FileKeyEncryptionNotFound";
            Text = "FileKeyEncryptionNotFound";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PassStatusIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AlertMessage;
        private Label label1;
        private TextBox txtKeyEncryption;
        private Label label2;
        private Button btnGuardar;
        private PictureBox PassStatusIcon;
    }
}