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
    public partial class AlertBox : Form
    {
        /// <summary>
        /// Formulario Modificado que acepta como parámetros el formulario padre para presentar la alerta dentro de este,
        /// el tipo de alerta son 4 (error, information, success, warning)
        /// </summary>
        private string typeAlertBox;
        private Form parent;
        public AlertBox(Form parentForm, string typeAlert, string Title, string Text)
        {
            InitializeComponent();
            this.TitleAlertBox = Title;
            this.TextAlertBox = Text;
            this.TypeAlertBox = typeAlert;
            this.ParentForm = parentForm;
            SetIconAlert(TypeAlertBox);
            SetColors(TypeAlertBox);
        }
        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
            }
        }
        public Color ColorAlertBox
        {
            get { return LinAlertBox.BackColor; }
            set { LinAlertBox.BackColor = LblTextAlertBox.ForeColor = LblTextAlertBox.ForeColor = value; }
        }
        public Form ParentForm
        {
            get { return parent; }
            set { parent = value; }
        }
        public String TypeAlertBox
        {
            get { return typeAlertBox; }
            set { typeAlertBox = value; }
        }
        public string TitleAlertBox
        {
            get { return LblTitleAlertBox.Text; }
            set { LblTitleAlertBox.Text = value; }
        }
        public string TextAlertBox
        {
            get { return LblTextAlertBox.Text; }
            set { LblTextAlertBox.Text = value; }
        }
        public Image IconAlertBox
        {
            get { return PicAlertBox.Image; }
            set { PicAlertBox.Image = value; }
        }
        public void PositionAlertBox(Form parentForm)
        {
            int xPos = parentForm.Left + parentForm.Width - this.Width; // Calcula la posición izquierda de la alerta
            int yPos = parentForm.Top + parentForm.Height - this.Height; // Calcula la posición superior de la alerta

            // Asegura que la alerta se muestre dentro del límite del formulario padre
            if (xPos < parentForm.Left)
            {
                xPos = parentForm.Left;
            }
            if (yPos < parentForm.Top)
            {
                yPos = parentForm.Top;
            }

            this.Location = new Point(xPos - 10, yPos - 10); // Asigna la posición calculada a la alerta, desplazada en 10 pixeles hacia la izquierda y arriba
        }

        public void SetIconAlert(string typeAlert)
        {
            Dictionary<string, Image> IconAlert = new Dictionary<string, Image>()
            {
                {"error", Resources.error },
                {"information", Resources.question },
                {"success", Resources.success},
                {"warning", Resources.warning}
            };
            if (IconAlert.ContainsKey(typeAlert))
            {
                IconAlertBox = (Image)IconAlert[typeAlert];
            }
        }
        public void SetColors(string typeAlert)
        {
            Dictionary<string, Color> BackColors = new Dictionary<string, Color>()
            {
                {"error", Color.LightPink },
                {"information", Color.LightSteelBlue },
                {"success", Color.LightGray },
                {"warning", Color.LightGoldenrodYellow }
            };
            Dictionary<string, Color> Colors = new Dictionary<string, Color>()
            {
                {"error", Color.DarkRed },
                {"information", Color.DodgerBlue },
                {"success", Color.SeaGreen },
                {"warning", Color.Goldenrod }
            };
            if (BackColors.ContainsKey(typeAlert) && Colors.ContainsKey(typeAlert))
            {
                BackColorAlertBox = BackColors[typeAlert];
                ColorAlertBox = Colors[typeAlert];
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            LinAlertBox.Width = LinAlertBox.Width + 2;
            if (LinAlertBox.Width >= 500)
            {
                timerAnimation.Stop();
                this.Close();
            }
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            PositionAlertBox(parent);
            timerAnimation.Start();
        }
    }
}
