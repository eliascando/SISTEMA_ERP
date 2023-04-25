namespace utilitaries.CustomForms
{
    partial class AlertBox
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
            components = new System.ComponentModel.Container();
            PicAlertBox = new PictureBox();
            LblTitleAlertBox = new Label();
            LblTextAlertBox = new Label();
            LinAlertBox = new Panel();
            timerAnimation = new System.Windows.Forms.Timer(components);
            roundedForm = new CustomComponents.CustomRoundedForms();
            ((System.ComponentModel.ISupportInitialize)PicAlertBox).BeginInit();
            SuspendLayout();
            // 
            // PicAlertBox
            // 
            PicAlertBox.Location = new Point(23, 14);
            PicAlertBox.Name = "PicAlertBox";
            PicAlertBox.Size = new Size(50, 50);
            PicAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicAlertBox.TabIndex = 0;
            PicAlertBox.TabStop = false;
            // 
            // LblTitleAlertBox
            // 
            LblTitleAlertBox.AutoSize = true;
            LblTitleAlertBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitleAlertBox.Location = new Point(80, 16);
            LblTitleAlertBox.Name = "LblTitleAlertBox";
            LblTitleAlertBox.Size = new Size(134, 25);
            LblTitleAlertBox.TabIndex = 1;
            LblTitleAlertBox.Text = "TitleAlertBox";
            // 
            // LblTextAlertBox
            // 
            LblTextAlertBox.AutoSize = true;
            LblTextAlertBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTextAlertBox.Location = new Point(82, 41);
            LblTextAlertBox.Name = "LblTextAlertBox";
            LblTextAlertBox.Size = new Size(108, 21);
            LblTextAlertBox.TabIndex = 2;
            LblTextAlertBox.Text = "TextAlertBox";
            // 
            // LinAlertBox
            // 
            LinAlertBox.BackColor = Color.Black;
            LinAlertBox.Location = new Point(0, 73);
            LinAlertBox.Name = "LinAlertBox";
            LinAlertBox.Size = new Size(1, 6);
            LinAlertBox.TabIndex = 3;
            // 
            // timerAnimation
            // 
            timerAnimation.Interval = 10;
            timerAnimation.Tick += timerAnimation_Tick;
            // 
            // roundedForm
            // 
            roundedForm.CornerRedius = 20;
            roundedForm.TargetControl = this;
            // 
            // AlertBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(500, 80);
            Controls.Add(LinAlertBox);
            Controls.Add(LblTextAlertBox);
            Controls.Add(LblTitleAlertBox);
            Controls.Add(PicAlertBox);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "AlertBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlertBox";
            Load += AlertBox_Load;
            ((System.ComponentModel.ISupportInitialize)PicAlertBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicAlertBox;
        private Label LblTitleAlertBox;
        private Label LblTextAlertBox;
        private Panel LinAlertBox;
        private System.Windows.Forms.Timer timerAnimation;
        private CustomComponents.CustomRoundedForms roundedForm;
    }
}