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
using view.Visual;

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
                VentanaPrincipalGerente gerente = new VentanaPrincipalGerente();
                VentanaPrincipalRRHH rrhh = new VentanaPrincipalRRHH();
                VentanaPrincipalAdminBodega bodega = new VentanaPrincipalAdminBodega();
                VentanaPrincipalAdminCaja caja = new VentanaPrincipalAdminCaja();
                VentanaPrincipalAsistente asistente = new VentanaPrincipalAsistente();

                MessageBox.Show("Acceso Exitoso!, Bienvenido " + GlobalVariablesCtrl.ObtenerUsuario());
                int id = GlobalVariablesCtrl.ObtenerIdRol();
                if (id == 1)
                {
                    gerente.ShowDialog();
                }
                else if (id == 2)
                {
                    rrhh.ShowDialog();
                }
                else if (id == 3)
                {
                    bodega.ShowDialog();
                }
                else if (id == 4)
                {
                    caja.ShowDialog();
                }
                else if (id == 5)
                {
                    asistente.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("ERROR! Credenciales incorrectas");
            }
        }

        private void InicioSesion_prueba_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
