﻿using control;
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
        Login loginForm;
        public VentanaPrincipalRRHH(Login loginForm)
        {
            InitializeComponent();
            lblNombreUsuarioRRHH.Text = GlobalVariablesCtrl.ObtenerUsuario();
            this.FormClosing += VentanaPrincipal_FormClosing;
            this.loginForm = loginForm;
            customizeDesign();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPersonal registropersonal = new RegistroPersonal();
            registropersonal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();
            verUsuarios.ShowDialog();
        }

        private void VentanaPrincipalRRHH_Load(object sender, EventArgs e)
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
        private void customizeDesign()
        {
            panelRRHHMenu.Visible = false;
            //..
        }
        private void hideSubMenu()
        {
            if (panelRRHHMenu.Visible == true)
            {
                panelRRHHMenu.Visible = false;
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
