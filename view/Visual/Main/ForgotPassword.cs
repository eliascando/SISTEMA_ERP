using control;
using libraries;
using model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using view.Visual.Personal;

namespace view.Visual.Main
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            lblSendEmailStatus.Visible = false;
            lblValidateOTP.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEnviarOTP_Click(object sender, EventArgs e)
        {
            string ID = txtId.Text.Trim();
            try
            {
                PersonalCtrl personalCtrl = new PersonalCtrl();
                if (await personalCtrl.SendEmailCtrl(ID))
                {
                    lblSendEmailStatus.Visible = true;
                    lblSendEmailStatus.Text = "Correo enviado exitosamente";
                    lblSendEmailStatus.ForeColor = Color.Green;
                    await Task.Delay(2000);
                    lblSendEmailStatus.Visible = false;
                }
                else
                {
                    lblSendEmailStatus.Visible = true;
                    lblSendEmailStatus.Text = "Error al enviar correo";
                    lblSendEmailStatus.ForeColor = Color.Red;
                    await Task.Delay(2000);
                    lblSendEmailStatus.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCION: " + ex);
            }

        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            if (personalCtrl.ValidarOTPCtrl(Alquimia.Encrypt(txtId.Text), txtOTP.Text))
            {
                CambiarCredenciales cambiarCredenciales = new CambiarCredenciales(txtId.Text);
                cambiarCredenciales.ShowDialog();
                this.Close();
            }
            else
            {
                lblValidateOTP.Visible = true;
                lblValidateOTP.Text = "Clave Incorrecta";
                lblValidateOTP.ForeColor = Color.Red;
                await Task.Delay(2000);
                lblValidateOTP.Visible = false;
            }
        }
    }
}