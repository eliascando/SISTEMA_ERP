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
        Login loginForm;
        public VentanaPrincipalAdminCaja(Login loginForm)
        {
            InitializeComponent();
            lblNombreUsuarioAdminC.Text = GlobalVariablesCtrl.ObtenerUsuario();
            this.FormClosing += VentanaPrincipal_FormClosing;
            this.loginForm = loginForm;
        }

        private void VentanaPrincipalAdminCaja_Load(object sender, EventArgs e)
        {

        }
        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
            loginForm.Dispose();
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Cerrar Sesión?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                GlobalVariablesCtrl.AsignarIdRol(0);
                GlobalVariablesCtrl.AsignarUsuario("");
                this.Dispose();
                loginForm.Show();
            }
        }
    }
}
