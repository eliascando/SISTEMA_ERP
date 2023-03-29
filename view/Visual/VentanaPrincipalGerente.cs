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
    public partial class VentanaPrincipalGerente : Form
    {
        public VentanaPrincipalGerente()
        {
            InitializeComponent();
            lblNombreUsuario.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPersonal registropersonal = new RegistroPersonal();
            registropersonal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();
            verUsuarios.ShowDialog();
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
