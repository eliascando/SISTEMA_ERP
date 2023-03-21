using control;
using model;
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
        //private VentanaPrincipal_prueba ventanaPrincipal;
        public InicioSesion_prueba()//(VentanaPrincipal_prueba ventanaPrincipal)
        {
            InitializeComponent();
            //this.ventanaPrincipal = ventanaPrincipal;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            CredencialesAccesoCtrl credenciales = new CredencialesAccesoCtrl();
            if (await credenciales.ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                VentanaPrincipal_prueba ventanaPrincipal = new VentanaPrincipal_prueba();
                MessageBox.Show("Acceso Exitoso!, Bienvenido " + GlobalVariables.usuario);
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
