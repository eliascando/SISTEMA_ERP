using libraries;
using control;
using view.Visual.Personal;

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
            try
            {

                if (Aurora.AreTextBoxModified(this) || imageData != null)
                {
                    PersonalCtrl personalCtrl = new PersonalCtrl();
                    if (await personalCtrl.ActualizarDatosUsuarioCtrl(lblCedula.Text, txtTelefonoU.Text, txtCorreoU.Text, txtDireccionU.Text, imageData))
                    {
                        MessageBox.Show("Actualizado Correctamente!");
                        await verUsuario.CargarTabla();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: No se pudo actualizar");
                    }
                }
                else
                {
                    MessageBox.Show("No se han registrado cambios!");
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
            CambiarCredenciales cambiarCredenciales = new CambiarCredenciales(lblCedula.Text);
            cambiarCredenciales.ShowDialog();
        }
    }
}