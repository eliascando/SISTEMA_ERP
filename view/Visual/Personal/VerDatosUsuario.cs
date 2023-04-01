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
    public partial class VerDatosUsuario : Form
    {
        private VerUsuarios verUsuario_prueba;
        public VerDatosUsuario(VerUsuarios verUsuarios_Prueba)
        {
            InitializeComponent();
            this.verUsuario_prueba = verUsuarios_Prueba;
        }

        private void VerDatosUsuario_prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
