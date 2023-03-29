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
    public partial class VentanaPrincipalRRHH : Form
    {
        public VentanaPrincipalRRHH()
        {
            InitializeComponent();
            lblNombreUsuarioRRHH.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPersonal registropersonal = new RegistroPersonal();
            registropersonal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();
            verUsuarios.ShowDialog();
        }

        private void VentanaPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }
    }
}
