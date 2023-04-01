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
    public partial class ActualizarDatosPersonal : Form
    {
        private VerUsuarios verUsuario;
        private byte[] imageData;
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
                if (Aurora.AreTextBoxModified(this))
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
    }
}
