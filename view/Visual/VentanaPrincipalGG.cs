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

namespace view.Visual
{
    public partial class VentanaPrincipalGG : Form
    {
        public VentanaPrincipalGG()
        {
            InitializeComponent();
            lblNombreUsuario.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarGerente registrarGerente = new RegistrarGerente();
            registrarGerente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios_prueba verUsuarios = new VerUsuarios_prueba();
            verUsuarios.ShowDialog();
        }
    }
}
