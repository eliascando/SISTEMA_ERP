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
            try
            {

                if (Aurora.AreTextBoxModified(this) || imageData != null)
                {
                    PersonalCtrl personalCtrl = new PersonalCtrl();
                    validarImagen(picFotoPersonal.Image);
                    if (await personalCtrl.ActualizarDatosUsuarioCtrl(lblCedula.Text, txtTelefonoU.Text, txtCorreoU.Text, txtDireccionU.Text, imageData))
                    {
                        await registroActividades.RegistroModificacionUsuarioCtrl(lblCedula.Text, GlobalVariablesCtrl.ObtenerIdUsuarioLogin(), "Actualización de Datos");
                        Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "success", "Actualizado", "Usuario actualizado correctamente");
                        alert.ShowDialog();
                        await verUsuario.CargarTabla();
                        this.Close();
                    }
                    else
                    {
                        Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "error", "Error!", "No se pudo actualizar");
                        alert.ShowDialog();
                    }
                }
                else
                {
                    Form alert = new AlertBox(GlobalVariablesCtrl.ObtenerParentForm(), "warning", "Alerta", "No se han registrado cambios");
                    alert.ShowDialog();
                    this.Close();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}