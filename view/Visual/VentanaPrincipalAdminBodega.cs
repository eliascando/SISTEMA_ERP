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
    public partial class VentanaPrincipalAdminBodega : Form
    {
        Login loginForm;
        public VentanaPrincipalAdminBodega(Login loginForm)
        {
            InitializeComponent();
            lblNombreUsuarioAdminB.Text = GlobalVariablesCtrl.ObtenerUsuario();
            this.FormClosing += VentanaPrincipal_FormClosing;
            this.loginForm = loginForm;
        }

        private void VentanaPrincipalAdminBodega_Load(object sender, EventArgs e)
        {

        }
        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
            loginForm.Dispose();
            Environment.Exit(0);
        }
    }
}
