namespace view.Visual.Main
{
    partial class LoginSuccess
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
            lblPanelSucces1 = new Label();
            picturePanelSucces = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePanelSucces).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(186, 291);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(181, 19);
            lblBienvenida.TabIndex = 8;
            lblBienvenida.Text = "MensajeBienvenida";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPanelSucces1
            // 
            lblPanelSucces1.AutoSize = true;
            lblPanelSucces1.Location = new Point(235, 256);
            lblPanelSucces1.Name = "lblPanelSucces1";
            lblPanelSucces1.Size = new Size(77, 15);
            lblPanelSucces1.TabIndex = 7;
            lblPanelSucces1.Text = "Inicio Exitoso";
            // 
            // picturePanelSucces
            // 
            picturePanelSucces.Image = Properties.Resources.success2;
            picturePanelSucces.Location = new Point(188, 84);
            picturePanelSucces.Name = "picturePanelSucces";
            picturePanelSucces.Size = new Size(171, 169);
            picturePanelSucces.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePanelSucces.TabIndex = 6;
            picturePanelSucces.TabStop = false;
            // 
            // LoginSuccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 411);
            Controls.Add(lblBienvenida);
            Controls.Add(lblPanelSucces1);
            Controls.Add(picturePanelSucces);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginSuccess";
            Text = "LoginSuccess";
            ((System.ComponentModel.ISupportInitialize)picturePanelSucces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblBienvenida;
        private Label lblPanelSucces1;
        private PictureBox picturePanelSucces;
    }
}