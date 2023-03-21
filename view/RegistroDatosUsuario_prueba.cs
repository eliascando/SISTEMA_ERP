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

namespace view
{
    public partial class RegistroDatosUsuario_prueba : Form
    {
        private RegistroUsuario_prueba registroForm;
        private byte[] imageData;
        public RegistroDatosUsuario_prueba(RegistroUsuario_prueba registroForm)
        {
            InitializeComponent();
            this.registroForm = registroForm;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UsuarioCtrl usuarioCtrl = new UsuarioCtrl();
            if (await usuarioCtrl.RegistrarUsuarioCrl(lblIdCedula.Text, lblCargoPersonal.Text, blbNombresPersonal.Text, lblApellidosPersonal.Text, imageData, txtUsuario.Text, txtPassword.Text))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroDatosUsuario_prueba_Load(object sender, EventArgs e)
        {

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
