using control;
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
using view.Properties;

namespace view.Visual.Personal
{
    public partial class CambiarCredenciales : Form
    {
        public static string id_personal = "";
        public static string id_user_responsable = "";
        public static string autorizacion_metodo_cambio = "";
        bool isShowPass = false;
        public CambiarCredenciales(string id, string id_responsable, string autorizacion_cambio)
        {
            InitializeComponent();
            AlertIcon.Visible = false;
            AlertMessage.Visible = false;
            id_personal = id;
            id_user_responsable = id_responsable;
            autorizacion_metodo_cambio = autorizacion_cambio;
            lblCedulaPersonal.Text = id;
            Aurora.HidePassword(txtNewPass, txtConfirmNewPass);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            RegistroActividadesCtrl actividadesCtrl = new RegistroActividadesCtrl();
            try
            {
                if (Aurora.AreTextBoxEmpty(this))
                {
                    AlertMessage.Visible = true;
                    AlertMessage.TextAlign = ContentAlignment.MiddleCenter;
                    AlertMessage.Text = "ERROR!: DEBE LLENAR TODOS LOS CAMPOS";
                    await Task.Delay(2000);
                }
                else
                {
                    if (Guardian.AreTextEqual(txtNewPass, txtConfirmNewPass))
                    {
                        if (await personalCtrl.CambiarCredencialesCtrl(id_personal, txtNewPass.Text))
                        {
                            await actividadesCtrl.RegistroModificacionUsuarioCtrl(id_personal,id_user_responsable,autorizacion_metodo_cambio);
                            AlertMessage.Visible = true;
                            AlertMessage.ForeColor = Color.Green;
                            AlertMessage.TextAlign = ContentAlignment.MiddleCenter;
                            AlertMessage.Text = "Credenciales Actualizadas Correctamente!";
                            btnActualizar.Enabled = false;
                            await Task.Delay(2000);
                            this.Close();
                        }
                        else
                        {
                            AlertMessage.Visible = true;
                            AlertMessage.TextAlign = ContentAlignment.MiddleCenter;
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

        private void PassStatusIcon_Click(object sender, EventArgs e)
        {
            if (isShowPass == false)
            {
                Aurora.ShowPassword(txtNewPass, txtConfirmNewPass);
                PassStatusIcon.Image = Resources.show_pass;
                isShowPass = true;
            }
            else
            {
                Aurora.HidePassword(txtNewPass, txtConfirmNewPass);
                PassStatusIcon.Image = Resources.hide_pass;
                isShowPass = false;
            }
        }
    }
}