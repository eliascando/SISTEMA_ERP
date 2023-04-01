namespace view.Visual.Main
{
    partial class LoginFail
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
            lblPanelFail2 = new Label();
            lblPanelFail1 = new Label();
            picturePanelFail = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePanelFail).BeginInit();
            SuspendLayout();
            // 
            // lblPanelFail2
            // 
            lblPanelFail2.AutoSize = true;
            lblPanelFail2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelFail2.Location = new Point(161, 286);
            lblPanelFail2.Name = "lblPanelFail2";
            lblPanelFail2.Size = new Size(229, 19);
            lblPanelFail2.TabIndex = 11;
            lblPanelFail2.Text = "Credenciales Incorrectas";
            // 
            // lblPanelFail1
            // 
            lblPanelFail1.AutoSize = true;
            lblPanelFail1.Location = new Point(251, 256);
            lblPanelFail1.Name = "lblPanelFail1";
            lblPanelFail1.Size = new Size(35, 15);
            lblPanelFail1.TabIndex = 10;
            lblPanelFail1.Text = "Error!";
            // 
            // picturePanelFail
            // 
            picturePanelFail.Image = Properties.Resources.failure;
            picturePanelFail.Location = new Point(192, 84);
            picturePanelFail.Name = "picturePanelFail";
            picturePanelFail.Size = new Size(171, 169);
            picturePanelFail.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePanelFail.TabIndex = 9;
            picturePanelFail.TabStop = false;
            // 
            // LoginFail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 411);
            Controls.Add(lblPanelFail2);
            Controls.Add(lblPanelFail1);
            Controls.Add(picturePanelFail);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginFail";
            Text = "LoginFail";
            ((System.ComponentModel.ISupportInitialize)picturePanelFail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblPanelFail2;
        private Label lblPanelFail1;
        private PictureBox picturePanelFail;
    }
}