using libraries;
using control;

namespace view.Visual
{
    public partial class RegistroPersonal : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        private byte[] imageData;

        public RegistroPersonal()
        {
            InitializeComponent();
            Guardian.ValidateTextInput(txtApellidos, txtNombres);
            Guardian.ValidateIdInput(txtCedula);
            Guardian.ValidateDecimalInput(txtSalario);
            Guardian.ValidateIntegerInput(txtTelefono);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Aurora.AreTextBoxEmpty(this))
                {
                    MessageBox.Show("ERROR!: Debe llenar todos los campos");
                }
                else
                {
                    if (!Guardian.IsValidEmail(txtCorreo))
                    {
                        MessageBox.Show("ERROR!: Formato Correo Inválido : nombre@dominio.com");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Estás seguro de que desea registrar nuevo personal?", "Confirmación", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            string sexoE = rbtnSexoM.Checked ? rbtnSexoM.Text : rbtnSexoM.Text;

                            if (await personalCtrl.RegistrarPersonalCtrl(txtCedula.Text, txtNombres.Text, txtApellidos.Text, cmbCargo.Text, imageData, dateNacimiento.Value, sexoE, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, dateIngreso.Value, txtSalario.Text))
                            {
                                MessageBox.Show("Registro Exitoso!");
                            }
                            else
                            {
                                MessageBox.Show("Error en Registro!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private async void RegistroPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCargo.DataSource = await personalCtrl.ObtenerRolesCtrl();
                cmbCargo.DisplayMember = "Nombre_rol";
                cmbCargo.ValueMember = "Id_rol";
                cmbCargo.SelectedValue = -1;
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                picFotoPersonal.Image = Image.FromFile(path);

                imageData = File.ReadAllBytes(path);
            }
        }
    }
}