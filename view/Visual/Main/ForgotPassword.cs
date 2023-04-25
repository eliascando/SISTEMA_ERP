using control;
using libraries;
using utilitaries;
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
using utilitaries.CustomForms;

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
            Guardian.ValidateIdInputCustom(txtId);
            Guardian.ValidateIntegerInputCustom(txtOTP);
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            try
            {
                if (String.IsNullOrEmpty(txtId.Texts))
                {
                    Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(),"warning","Atencion!","Debe ingresar su ID" );
                    alert.Show();
                }
                else if (txtId.Texts.Length < 10)
                {
                    Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "warning", "Atencion!", "Debe ingresar un ID válido");
                    alert.Show();
                }
                else
                {
                    btnEnviar.Visible = false;
                    Loading.Visible = true;

                    var enviarCorreoTask = personalCtrl.SendEmailCtrl(txtId.Texts);
                    var esperarTask = Task.Delay(3000);

                    await Task.WhenAll(enviarCorreoTask, esperarTask);

                    if (enviarCorreoTask.Result)
                    {
                        Loading.Visible = false;
                        btnEnviar.Visible = true;
                        Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "success", "Enviado!", "Correo enviado exitosamente");
                        alert.Show();
                        btnValidar.Enabled = true;
                    }
                    else
                    {
                        Loading.Visible = false;
                        btnEnviar.Visible = true;
                        Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "No enviado!", "Hubo un error al enviar el correo");
                        alert.Show();
                        lblSendEmailStatus.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Loading.Visible = false;
                btnEnviar.Visible = true;
                Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "No enviado!", "Hubo un error al enviar el correo");
                alert.Show();
            }
        }

        private async void btnValidar_Click_1(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            if (personalCtrl.ValidarOTPCtrl(Alquimia.Encrypt(txtId.Texts), txtOTP.Texts))
            {
                CambiarCredenciales cambiarCredenciales = new CambiarCredenciales(txtId.Texts, txtId.Texts, "Cambio de contraseña por validación de clave OTP");
                cambiarCredenciales.ShowDialog();
                GlobalVariablesCtrl.AsignarCurrentCounter(0);
                this.Close();
            }
            else
            {
                Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "Error!", "Clave Incorrecta");
                alert.Show();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}