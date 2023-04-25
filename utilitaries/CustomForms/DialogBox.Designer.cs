namespace utilitaries.CustomForms
{
    partial class DialogBox
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
            LblTextDialogBox = new Label();
            LblTitleDialogBox = new Label();
            PicDialogBox = new PictureBox();
            customRoundedForms1 = new CustomComponents.CustomRoundedForms();
            btnAceptar = new CustomControls.CustomButton();
            btnCancelar = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)PicDialogBox).BeginInit();
            SuspendLayout();
            // 
            // LblTextDialogBox
            // 
            LblTextDialogBox.AutoSize = true;
            LblTextDialogBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTextDialogBox.Location = new Point(20, 68);
            LblTextDialogBox.Name = "LblTextDialogBox";
            LblTextDialogBox.Size = new Size(120, 21);
            LblTextDialogBox.TabIndex = 5;
            LblTextDialogBox.Text = "TextDialogBox";
            LblTextDialogBox.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblTitleDialogBox
            // 
            LblTitleDialogBox.AutoSize = true;
            LblTitleDialogBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitleDialogBox.Location = new Point(51, 20);
            LblTitleDialogBox.Name = "LblTitleDialogBox";
            LblTitleDialogBox.Size = new Size(153, 25);
            LblTitleDialogBox.TabIndex = 4;
            LblTitleDialogBox.Text = "TitleDialogBox";
            // 
            // PicDialogBox
            // 
            PicDialogBox.Location = new Point(20, 20);
            PicDialogBox.Name = "PicDialogBox";
            PicDialogBox.Size = new Size(25, 25);
            PicDialogBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDialogBox.TabIndex = 3;
            PicDialogBox.TabStop = false;
            // 
            // customRoundedForms1
            // 
            customRoundedForms1.CornerRedius = 25;
            customRoundedForms1.TargetControl = this;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SteelBlue;
            btnAceptar.BackgroundColor = Color.SteelBlue;
            btnAceptar.BorderColor = Color.PaleVioletRed;
            btnAceptar.BorderRadius = 30;
            btnAceptar.BorderSize = 0;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(20, 107);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 40);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextColor = Color.White;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.BackgroundColor = Color.SteelBlue;
            btnCancelar.BorderColor = Color.PaleVioletRed;
            btnCancelar.BorderRadius = 30;
            btnCancelar.BorderSize = 0;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(146, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // DialogBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(292, 158);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(LblTextDialogBox);
            Controls.Add(LblTitleDialogBox);
            Controls.Add(PicDialogBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogBox";
            ((System.ComponentModel.ISupportInitialize)PicDialogBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTextDialogBox;
        private Label LblTitleDialogBox;
        private PictureBox PicDialogBox;
        private CustomComponents.CustomRoundedForms customRoundedForms1;
        private CustomControls.CustomButton btnCancelar;
        private CustomControls.CustomButton btnAceptar;
    }
}