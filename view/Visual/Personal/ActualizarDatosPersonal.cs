using libraries;
using utilitaries;
using control;
using view.Visual.Personal;
using view.Properties;
using utilitaries.CustomForms;

namespace view.Visual
{
    public partial class ActualizarDatosPersonal : Form
    {
        private VerUsuarios verUsuario;
        private byte[] imageData = null;
        private bool isUserStateChanged;
        private bool isPersonalStateChanged;

        public ActualizarDatosPersonal(VerUsuarios verUsuarios)
        {
            InitializeComponent();
            this.verUsuario = verUsuarios;
        }

        private void btnChangeImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                picFotoPersonal.Image = Image.FromFile(path);

                imageData = File.ReadAllBytes(path);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            RegistroActividadesCtrl registroActividades = new RegistroActividadesCtrl();
            PersonalCtrl personalCtrl = new PersonalCtrl();
            bool cambiosRealizados = false;
            try
            {
                if (Aurora.AreTextBoxModified(this) || imageData != null || EstadoPersonalCambiado())
                {
                    Form dialogo = new DialogBox(GlobalVariablesCtrl.ObtenerParentForm(), "Confirmación", "Desea guardar los cambios?");
                    dialogo.ShowDialog();
                    if (dialogo.DialogResult.Equals(DialogResult.OK))
                    {      
                        validarImagen(picFotoPersonal.Image);
                        if (EstadoPersonalCambiado())
                        {
                            await personalCtrl.CambiarEstadoPersonal(lblCedula.Text, usuarioActivoToogle.Checked, personalActivoToogle.Checked);
                            await registroActividades.RegistroModificacionUsuarioCtrl(lblCedula.Text, GlobalVariablesCtrl.ObtenerIdUsuarioLogin(), MensajeEstadoCambiado());
                            cambiosRealizados = true;
                        }
                        if (await personalCtrl.ActualizarDatosUsuarioCtrl(lblCedula.Text, txtTelefonoU.Text, txtCorreoU.Text, txtDireccionU.Text, imageData))
                        {
                            if (!cambiosRealizados)
                            {
                                await registroActividades.RegistroModificacionUsuarioCtrl(lblCedula.Text, GlobalVariablesCtrl.ObtenerIdUsuarioLogin(), "Actualización de Datos");
                                cambiosRealizados = true;
                            }
                            Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "success", "Actualizado", "Usuario actualizado correctamente");                            
                            await verUsuario.CargarTabla();
                            this.Close();
                            alert.Show();
                        }
                        else
                        {
                            Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "Error!", "No se pudo actualizar");
                            alert.ShowDialog();
                        }
                    }
                }
                else
                {
                    Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "warning", "Alerta", "No se han registrado cambios");                  
                    this.Close();
                    alert.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarCredenciales_Click(object sender, EventArgs e)
        {
            CambiarCredenciales cambiarCredenciales = new CambiarCredenciales(lblCedula.Text, GlobalVariablesCtrl.ObtenerIdUsuarioLogin(), "Cambio de contraseña realizado por Gerente");
            cambiarCredenciales.ShowDialog();
        }
        private void validarImagen(Image imagen)
        {
            if (imagen != Resources.default_user_picture)
            {
                Image foto = picFotoPersonal.Image;
                ImageConverter converter = new ImageConverter();
                imageData = (byte[])converter.ConvertTo(foto, typeof(byte[]));
            }
        }
        private bool EstadoPersonalCambiado()
        {
            bool cambiado;
            if (isPersonalStateChanged != personalActivoToogle.Checked || isUserStateChanged != usuarioActivoToogle.Checked)
            {
                cambiado = true;
            }
            else
            {
                cambiado = false;
            }
            return cambiado;
        }
        private string MensajeEstadoCambiado()
        {
            string mensaje = "Cambio de estado de Personal";

            if ((personalActivoToogle.Checked == isPersonalStateChanged) && usuarioActivoToogle.Checked)
            {
                mensaje = "Activación de Usuario";
            }else if(personalActivoToogle.Checked && (usuarioActivoToogle.Checked == isUserStateChanged))
            {
                mensaje = "Activación de Personal";
            }
            else if (!personalActivoToogle.Checked && !usuarioActivoToogle.Checked)
            {
                mensaje = "Inactivación de Personal";
            }
            else if (personalActivoToogle.Checked && !usuarioActivoToogle.Checked)
            {
                mensaje = "Inactivación de Usuario";
            }
            return mensaje;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalActivoToogle_CheckStateChanged(object sender, EventArgs e)
        {
            if (!personalActivoToogle.Checked)
            {
                usuarioActivoToogle.Checked = false;
            }
        }

        private void usuarioActivoToogle_CheckedChanged(object sender, EventArgs e)
        {
            if (usuarioActivoToogle.Checked)
            {
                personalActivoToogle.Checked = true;
            }
        }

        private void ActualizarDatosPersonal_Load(object sender, EventArgs e)
        {
            isPersonalStateChanged = personalActivoToogle.Checked;
            isUserStateChanged = usuarioActivoToogle.Checked;
        }
    }
}