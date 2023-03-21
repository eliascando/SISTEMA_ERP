using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
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
    }
}
