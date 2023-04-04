using control;

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
            customizeDesign();

        }
        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
            loginForm.Dispose();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void customizeDesign()
        {
            panelAlmacenMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelAlmacenMenu.Visible == true)
            {
                panelAlmacenMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
    }
}