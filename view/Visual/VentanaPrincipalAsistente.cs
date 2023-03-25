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
    public partial class VentanaPrincipalAsistente : Form
    {
        public VentanaPrincipalAsistente()
        {
            InitializeComponent();
            lblNombreUsuarioAsistente.Text = GlobalVariablesCtrl.ObtenerUsuario();
        }

        private void VentanaPrincipalAsistente_Load(object sender, EventArgs e)
        {

        }
    }
}
