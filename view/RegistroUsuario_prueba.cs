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
    public partial class RegistroUsuario_prueba : Form
    {
        public RegistroUsuario_prueba()
        {
            InitializeComponent();
        }

        private async void RegistroUsuario_prueba_Load(object sender, EventArgs e)
        {
            await CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datagridPersonalSinUsuario.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridPersonalSinUsuario.SelectedRows[0];
                //string id = selectedRow.Cells[0].Value.ToString();
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
