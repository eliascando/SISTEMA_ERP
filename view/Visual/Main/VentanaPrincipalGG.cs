using control;
using libraries;

namespace view.Visual
{
    public partial class VentanaPrincipalGG : Form
    {
        Login loginForm;
        public VentanaPrincipalGG(Login loginForm)
        {
            InitializeComponent();
            lblNombreUsuario.Text = GlobalVariablesCtrl.ObtenerUsuario().Trim();
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

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRRHHMenu);
        }
        private void customizeDesign()
        {
            panelRRHHMenu.Visible = false;
            panelAlmacenMenu.Visible = false;
            panelVentasMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelRRHHMenu.Visible == true)
            {
                panelRRHHMenu.Visible = false;
            }
            if (panelAlmacenMenu.Visible == true)
            {
                panelAlmacenMenu.Visible = false;
            }
            if (panelVentasMenu.Visible == true)
            {
                panelVentasMenu.Visible = false;
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

        private void btnRegistrarGerente_Click(object sender, EventArgs e)
        {
            Form registrarGerente = new RegistrarGerente();
            Aurora.LoadFormInPanel(registrarGerente, panelContenedor, ref activeForm);
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            Form registrarPersonal = new RegistroPersonal();
            Aurora.LoadFormInPanel(registrarPersonal, panelContenedor, ref activeForm);
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            Form verUsuarios = new VerUsuarios();
            Aurora.LoadFormInPanel(verUsuarios, panelContenedor, ref activeForm);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAlmacenMenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasMenu);
        }

        private Form activeForm = null;
    }
}