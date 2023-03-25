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
using model.Entities;

namespace view.Visual
{
    public partial class VerUsuarios_prueba : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();

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
            gridUsuarios.DataSource = await personalCtrl.ObtenerUsuarios();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            VerDatosUsuario_prueba DatosForm = new VerDatosUsuario_prueba(this);
            if (gridUsuarios.SelectedRows.Count > 0)
            {
                Dictionary<string, object> combinedData = new Dictionary<string, object>();
                DataGridViewRow selectedRow = gridUsuarios.SelectedRows[0];
                combinedData = await personalCtrl.ObtenerDatosUsuariosCtrl(selectedRow.Cells[0].Value.ToString());
                DatosForm.lblID.Text = (string)combinedData["Id_personal"];
                DatosForm.lblNombreUsuario.Text = (string)combinedData["Nombre_personal"] + " " + (string)combinedData["Apellido_personal"];
                DatosForm.lblCargo.Text = (string)combinedData["Cargo"];
                DatosForm.lblCorreo.Text = (string)combinedData["Correo"];
                DatosForm.lblTelefono.Text = (string)combinedData["Telefono"];
                DatosForm.lblFechaIngreso.Text = Aurora.DateToString((DateTime)combinedData["Fecha_ingreso"]);
                DatosForm.picFotoUsuario.Image = Image.FromStream(new MemoryStream((byte[])combinedData["Imagen"]));
                DatosForm.lblUsuario.Text = (string)combinedData["Usuario"];
                DatosForm.lblEdad.Text = Aurora.GetAge((DateTime)combinedData["Fecha_nacimiento"]).ToString();

                DatosForm.ShowDialog();
            }
        }
    }
}