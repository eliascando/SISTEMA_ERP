using libraries;
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
            try
            {
                if (Aurora.AreTextBoxEmpty(this))
                {
                    MessageBox.Show("ERROR!: Debe llenar todos los campos");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que desea registrar nuevo gerente?", "Confirmación", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        string sexoE = rbtnSexoM.Checked ? rbtnSexoM.Text : rbtnSexoM.Text;

                        if (await personalCtrl.RegistrarGerenteCtrl(txtCedula.Text, txtNombres.Text, txtApellidos.Text, dateNacimiento.Value, sexoE, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, dateIngreso.Value, txtSalario.Text, imageData, txtUsuario.Text, txtPassword.Text))
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
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
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
