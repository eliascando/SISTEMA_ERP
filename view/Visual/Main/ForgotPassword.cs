using control;
using libraries;
using model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            btnValidar.Enabled = false;
            Loading.Visible = false;
            Guardian.ValidateIdInput(txtId);
            Guardian.ValidateIntegerInput(txtOTP);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEnviarOTP_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            try
            {
                if (String.IsNullOrEmpty(txtId.Text))
                {
                    lblSendEmailStatus.Visible = true;
                    lblSendEmailStatus.Text = "Debe ingresar su ID";
                    lblSendEmailStatus.ForeColor = Color.Red;
                    await Task.Delay(2000);
                    lblSendEmailStatus.Visible = false;
                }
                else if (txtId.Text.Length < 10)
                {
                    lblSendEmailStatus.Visible = true;
                    lblSendEmailStatus.Text = "Debe ingresar un ID válido";
                    lblSendEmailStatus.ForeColor = Color.Red;
                    await Task.Delay(2000);
                    lblSendEmailStatus.Visible = false;
                }
                else
                {
                    btnEnviarOTP.Visible = false;
                    Loading.Visible = true;

                    var enviarCorreoTask = personalCtrl.SendEmailCtrl(txtId.Text);
                    var esperarTask = Task.Delay(3000);

                    await Task.WhenAll(enviarCorreoTask, esperarTask);

                    if (enviarCorreoTask.Result)
                    {
                        Loading.Visible = false;
                        btnEnviarOTP.Visible = true;
                        lblSendEmailStatus.Visible = true;
                        lblSendEmailStatus.Text = "Correo enviado exitosamente";
                        lblSendEmailStatus.ForeColor = Color.Green;
                        await Task.Delay(2000);
                        lblSendEmailStatus.Visible = false;
                        btnValidar.Enabled = true;
                    }
                    else
                    {
                        Loading.Visible = false;
                        btnEnviarOTP.Visible = true;
                        lblSendEmailStatus.Visible = true;
                        lblSendEmailStatus.Text = "Error al enviar correo";
                        lblSendEmailStatus.ForeColor = Color.Red;
                        await Task.Delay(2000);
                        lblSendEmailStatus.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Loading.Visible = false;
                btnEnviarOTP.Visible = true;
                lblSendEmailStatus.Visible = true;
                lblSendEmailStatus.Text = "Error al enviar correo";
                lblSendEmailStatus.ForeColor = Color.Red;
                await Task.Delay(2000);
                lblSendEmailStatus.Visible = false;
            }
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            if (personalCtrl.ValidarOTPCtrl(Alquimia.Encrypt(txtId.Text), txtOTP.Text))
            {
                CambiarCredenciales cambiarCredenciales = new CambiarCredenciales(txtId.Text, txtId.Text, "Cambio de contraseña por validación de clave OTP");
                cambiarCredenciales.ShowDialog();
                GlobalVariablesCtrl.AsignarCurrentCounter(0);
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