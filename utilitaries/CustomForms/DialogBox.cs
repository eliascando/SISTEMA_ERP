using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitaries.Properties;

namespace utilitaries.CustomForms
{
    public partial class DialogBox : Form
    {
        private Form parentForm;
        public DialogBox(Form parentForm, string Title, string Text)
        {
            InitializeComponent();
            this.PicDialogBox.Image = Resources.question;
            this.ForeColor = Color.LightSteelBlue;
            this.LblTextDialogBox.ForeColor = Color.DodgerBlue;
            this.LblTitleDialogBox.ForeColor = Color.Black;
            this.LblTitleDialogBox.Text = Title;
            this.LblTextDialogBox.Text = Text;
            this.ParentForm = parentForm;
            PositionAlertBox(ParentForm);
        }

        public Form ParentForm
        {
            get { return parentForm; }
            set { parentForm = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void PositionAlertBox(Form parentForm)
        {
            int xPos = parentForm.Left + (parentForm.Width - this.Width) / 2; // Calcula la posición centrada en x de la alerta
            int yPos = parentForm.Top + (parentForm.Height - this.Height) / 2; // Calcula la posición centrada en y de la alerta

            this.Location = new Point(xPos, yPos); // Asigna la posición calculada a la alerta
        }
    }
}
