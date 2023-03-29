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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private async void RegistroUsuario_prueba_Load(object sender, EventArgs e)
        {
            await CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroDatosUsuario registro = new RegistroDatosUsuario(this);
            if (datagridPersonalSinUsuario.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridPersonalSinUsuario.SelectedRows[0];
                registro.lblIdCedula.Text = selectedRow.Cells[0].Value.ToString();
                registro.blbNombresPersonal.Text = selectedRow.Cells[1].Value.ToString();
                registro.lblApellidosPersonal.Text = selectedRow.Cells[2].Value.ToString();
                registro.lblCargoPersonal.Text = selectedRow.Cells[3].Value.ToString();
                registro.Show();
            }
        }
        public async Task CargarTabla()
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            datagridPersonalSinUsuario.DataSource = await personalCtrl.ObtenerPersonalSinUsuarioCtrl();
        }

        private async void btnActualizarLista_Click(object sender, EventArgs e)
        {
            await CargarTabla();
        }
    }
}
