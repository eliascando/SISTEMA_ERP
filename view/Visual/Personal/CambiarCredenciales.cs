using control;
using libraries;
using utilitaries.CustomForms;
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
                    Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "warning", "Atención!", "Debe llenar todos los campos");
                    alert.Show();
                }
                else
                {
                    if (Guardian.AreTextEqual(txtNewPass, txtConfirmNewPass))
                    {
                        if (await personalCtrl.CambiarCredencialesCtrl(id_personal, txtNewPass.Text))
                        {
                            await actividadesCtrl.RegistroModificacionUsuarioCtrl(id_personal, id_user_responsable, autorizacion_metodo_cambio);
                            Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "success", "Exito!", "Credenciales Actualizadas Correctamente");
                            alert.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "Error!", "No se pudo actualizar correctamente");
                            alert.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "Error!", "Las contraseñas deben coincidir");
                        alert.Show();
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