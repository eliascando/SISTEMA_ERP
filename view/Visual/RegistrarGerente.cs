using control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Visual
{
    public partial class RegistrarGerente : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        private byte[] imageData;
        public RegistrarGerente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string sexoE = "";
            if (rbtnSexoM.Checked)
            {
                sexoE = rbtnSexoM.Text;
            }
            if (rbtnSexoF.Checked)
            {
                sexoE = rbtnSexoF.Text;
            }

            if (await personalCtrl.RegistrarGerenteCtrl(txtCedula.Text, txtNombres.Text, txtApellidos.Text, dateNacimiento.Value, sexoE, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, dateIngreso.Value, txtSalario.Text, imageData, txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("Registro Exitoso!");
            }
            else
            {
                MessageBox.Show("Error en Registro!");
            }

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
