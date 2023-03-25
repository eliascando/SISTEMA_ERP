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
    public partial class VentanaPrincipalAdminCaja : Form
    {
        public VentanaPrincipalAdminCaja()
        {
            InitializeComponent();
            lblNombreUsuarioAdminC.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void VentanaPrincipalAdminCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
