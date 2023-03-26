using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control;

namespace view
{
    public partial class Registropersonal_prueba : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        public Registropersonal_prueba()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

            if (await personalCtrl.RegistrarPersonalCtrl(txtCedula.Text, txtNombres.Text, txtApellidos.Text, cmbCargo.Text, dateNacimiento.Value, sexoE, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, dateIngreso.Value, txtSalario.Text))
            {
                MessageBox.Show("Registro Exitoso!");
            }
            else
            {
                MessageBox.Show("Error en Registro!");
            }
        }

        private async void Registropersonal_prueba_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = await personalCtrl.ObtenerRolesCtrl();
            cmbCargo.DisplayMember = "Nombre_rol";
            cmbCargo.ValueMember = "Id_rol";
            cmbCargo.SelectedValue = -1;
        }
    }
}
