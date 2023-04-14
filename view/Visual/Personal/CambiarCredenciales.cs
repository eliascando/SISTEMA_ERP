﻿using control;
using libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Visual.Personal
{
    public partial class CambiarCredenciales : Form
    {
        public static string id_personal = "";
        public CambiarCredenciales()
        {
            InitializeComponent();
            AlertIcon.Visible = false;
            AlertMessage.Visible = false;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            try
            {
                if (Aurora.AreTextBoxEmpty(this))
                {
                    //MessageBox.Show("ERROR!: DEBE LLENAR TODOS LOS CAMPOS");
                    AlertMessage.Visible = true;
                    AlertMessage.Text = "ERROR!: DEBE LLENAR TODOS LOS CAMPOS";
                    await Task.Delay(2000);
                }
                else
                {
                    if (Guardian.AreTextEqual(txtNewPass, txtConfirmNewPass))
                    {
                        if (await personalCtrl.CambiarCredencialesCtrl(lblCedulaPersonal.Text, txtNewPass.Text))
                        {
                            //MessageBox.Show("Credenciales Actualizadas Correctamente!");
                            AlertMessage.Visible = true;
                            AlertMessage.ForeColor = Color.Green;
                            AlertMessage.Text = "Credenciales Actualizadas Correctamente!";
                            btnActualizar.Enabled = false;
                            await Task.Delay(2000);
                            this.Close();
                        }
                        else
                        {
                            //MessageBox.Show("ERROR!: No se pudo actualizar correctamente...");
                            AlertMessage.Visible = true;
                            AlertMessage.Text = "ERROR!: No se pudo actualizar correctamente";
                            btnActualizar.Enabled = false;
                            await Task.Delay(2000);
                            this.Close();
                        }
                    }
                    else
                    {
                        AlertIcon.Visible = true;
                        AlertMessage.Visible = true;
                        await Task.Delay(2000);
                        AlertIcon.Visible = false;
                        AlertMessage.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCION!: " + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}