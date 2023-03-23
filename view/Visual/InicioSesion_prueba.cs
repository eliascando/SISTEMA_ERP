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

namespace view
{
    public partial class InicioSesion_prueba : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        public InicioSesion_prueba()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (await personalCtrl.ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                VentanaPrincipal_prueba ventanaPrincipal = new VentanaPrincipal_prueba();
                MessageBox.Show("Acceso Exitoso!, Bienvenido " + GlobalVariablesCtrl.ObtenerUsuario());
                ventanaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR! Credenciales incorrectas");
            }
        }

        private void InicioSesion_prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
