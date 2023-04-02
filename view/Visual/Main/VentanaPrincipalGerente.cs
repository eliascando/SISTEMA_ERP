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
using view.Visual;

namespace view
{
    public partial class VentanaPrincipalGerente : Form
    {
        Login loginForm;
        public VentanaPrincipalGerente(Login loginForm)
        {
            InitializeComponent();
            lblNombreUsuario.Text = GlobalVariablesCtrl.ObtenerUsuario();
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

        private void customizeDesign()
        {
            panelRRHHMenu.Visible = false;
            panelAlmacenMenu.Visible = false;
            panelVentasMenu.Visible = false;
            //..
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

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRRHHMenu);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAlmacenMenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasMenu);
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            Form registrarPersonal = new RegistroPersonal();
            loadWindow(registrarPersonal);
        }
        private Form activeForm = null;
        private void loadWindow(Form Window)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = Window;
            Window.TopLevel = false;
            Window.FormBorderStyle = FormBorderStyle.None;
            Window.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(Window);
            panelContenedor.Tag = Window;
            Window.BringToFront();
            Window.Show();
        }
        private void closeWindow(Form Window)
        {
            Window.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Form registrarUsuario = new RegistroUsuario();
            loadWindow(registrarUsuario);
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            Form verUsuarios = new VerUsuarios();
            loadWindow(verUsuarios);
        }

        private void button14_Click(object sender, EventArgs e)
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
