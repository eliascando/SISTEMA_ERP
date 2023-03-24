using control;
using aurora;
using Microsoft.Win32;
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
    public partial class VerUsuarios_prueba : Form
    {
        
        public VerUsuarios_prueba()
        {
            InitializeComponent();
        }

        private async void VerUsuarios_prueba_Load(object sender, EventArgs e)
        {
            await CargarTabla();
        }
        public async Task CargarTabla()
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            gridUsuarios.DataSource = await personalCtrl.ObtenerUsuarios();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            VerDatosUsuario_prueba verDatos = new VerDatosUsuario_prueba(this);
            if (gridUsuarios.SelectedRows.Count > 0)
            {
                //List<object> data = new List<object>();
                //DataGridViewRow selectedRow = gridUsuarios.SelectedRows[0];
                //PersonalCtrl verData = new PersonalCtrl();
                //string id = selectedRow.Cells[0].Value.ToString();
                //data = await verData.ObtenerDatosUsuarios(id);
                //data.
                //verDatos.lblNombreUsuario.Text = data.Columns[0].ToString() + data.Columns[1].ToString();
                //verDatos.lblCargo.Text = data.Columns[2].ToString();
                //verDatos.lblEdad.Text = Aurora.Edad(data.Columns[3].ToString()).ToString() + " años";
                //verDatos.lblTelefono.Text = data.Columns[4].ToString();
                //verDatos.lblCorreo.Text = data.Columns[5].ToString();
                //verDatos.lblFechaIngreso.Text = data.Columns[6].ToString();
                //verDatos.lblUsuario.Text = data.Columns[8].ToString();
                ////byte[] imagen = byte[]. data.Columns[7];
                ////using (MemoryStream ms = new MemoryStream(imagen))
                ////{

                ////}

                //verDatos.ShowDialog();

                ////registro.Show();
            }
        }
    }
}
