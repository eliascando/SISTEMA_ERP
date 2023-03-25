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
            Registropersonal_prueba registropersonal = new Registropersonal_prueba();
            registropersonal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios_prueba verUsuarios = new VerUsuarios_prueba();
            verUsuarios.ShowDialog();
        }

        private void VentanaPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }
    }
}
