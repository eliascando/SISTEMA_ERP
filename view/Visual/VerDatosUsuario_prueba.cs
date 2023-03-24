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
    public partial class VerDatosUsuario_prueba : Form
    {
        private VerUsuarios_prueba verUsuario_prueba;
        public VerDatosUsuario_prueba(VerUsuarios_prueba verUsuarios_Prueba)
        {
            InitializeComponent();
            this.verUsuario_prueba = verUsuarios_Prueba;
        }
        private void button1_clik(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerDatosUsuario_prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
