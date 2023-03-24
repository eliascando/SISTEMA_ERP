using control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using view.Visual;

namespace view
{
    public partial class VentanaPrincipal_prueba : Form
    {
        public VentanaPrincipal_prueba()
        {
            InitializeComponent();
            if (GlobalVariablesCtrl.ObtenerIdRol() > 2)
            {
                button1.Visible = false;
                button2.Visible = false;
            }
            if (GlobalVariablesCtrl.ObtenerIdRol() == 2)
            {
                button2.Visible=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registropersonal_prueba registropersonal = new Registropersonal_prueba();
            registropersonal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuario_prueba registroUsuario = new RegistroUsuario_prueba();
            registroUsuario.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios_prueba verUsuarios = new VerUsuarios_prueba();
            verUsuarios.ShowDialog();
        }
    }
}
