using control;

namespace view
{
    public partial class RegistroDatosUsuario : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        private RegistroUsuario registroForm;

        public RegistroDatosUsuario(RegistroUsuario registroForm)
        {
            InitializeComponent();
            this.registroForm = registroForm;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (await personalCtrl.RegistrarUsuarioCtrl(lblIdCedula.Text, lblCargoPersonal.Text, blbNombresPersonal.Text, lblApellidosPersonal.Text, txtUsuario.Text, txtPassword.Text))
                {
                    MessageBox.Show("Usuario Registrado!");
                    this.Close();
                    await registroForm.CargarTabla();
                }
                else
                {
                    MessageBox.Show("ERROR!: No se pudo egistrar usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {

        }
    }
}