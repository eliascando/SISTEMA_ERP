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
    public partial class VentanaPrincipalAdminBodega : Form
    {
        public VentanaPrincipalAdminBodega()
        {
            InitializeComponent();
            lblNombreUsuarioAdminB.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void VentanaPrincipalAdminBodega_Load(object sender, EventArgs e)
        {

        }
    }
}
