namespace view.Visual
{
    partial class LoginFallido
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
            lblBienvenida = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(274, 326);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(229, 19);
            lblBienvenida.TabIndex = 5;
            lblBienvenida.Text = "Credenciales Incorrectas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 294);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Error!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.failure;
            pictureBox1.Location = new Point(302, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginFallido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBienvenida);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFallido";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFallido";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblBienvenida;
        private Label label1;
        private PictureBox pictureBox1;
    }
}