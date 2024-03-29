﻿using control;

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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }
        public async Task CargarTabla()
        {
            try
            {
                PersonalCtrl personalCtrl = new PersonalCtrl();
                datagridPersonalSinUsuario.DataSource = await personalCtrl.ObtenerPersonalSinUsuarioCtrl();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }          
        }

        private async void btnActualizarLista_Click(object sender, EventArgs e)
        {
            await CargarTabla();
        }
    }
}