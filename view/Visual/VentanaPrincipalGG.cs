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
        }

        private void btnAgregarGerente_Click(object sender, EventArgs e)
        {
            RegistrarGerente registrarGerente = new RegistrarGerente();
            registrarGerente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios_prueba verUsuarios_Prueba = new VerUsuarios_prueba();
            verUsuarios_Prueba.ShowDialog();
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            Registropersonal_prueba registropersonal = new Registropersonal_prueba();
            registropersonal.ShowDialog();
        }
    }
}
