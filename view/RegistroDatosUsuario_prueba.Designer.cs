﻿namespace view
{
    partial class RegistroDatosUsuario_prueba
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(268, 43);
            label1.Name = "label1";
            label1.Size = new Size(248, 33);
            label1.TabIndex = 0;
            label1.Text = "Datos de Usuario";
            // 
            // RegistroDatosUsuario_prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "RegistroDatosUsuario_prueba";
            Text = "RegistroDatosUsuario_prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}