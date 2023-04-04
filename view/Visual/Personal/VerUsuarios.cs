using control;
using libraries;
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
    public partial class VerUsuarios : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();

        public VerUsuarios()
        {
            InitializeComponent();
        }

        private async void VerUsuarios_prueba_Load(object sender, EventArgs e)
        {
            await CargarTabla();
        }
        public async Task CargarTabla()
        {
            try
            {
                gridUsuarios.DataSource = await personalCtrl.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VerDatosUsuario DatosForm = new VerDatosUsuario(this);
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
                    DatosForm.lblFechaIngreso.Text = Alquimia.DateToString((DateTime)combinedData["Fecha_ingreso"]);
                    DatosForm.picFotoUsuario.Image = Image.FromStream(new MemoryStream((byte[])combinedData["Imagen"]));
                    DatosForm.lblUsuario.Text = (string)combinedData["Usuario"];
                    DatosForm.lblEdad.Text = Alquimia.GetAge((DateTime)combinedData["Fecha_nacimiento"]).ToString();

                    loadWindow(DatosForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarDatosPersonal UpdateForm = new ActualizarDatosPersonal(this);
                if (gridUsuarios.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> combinedData = new Dictionary<string, object>();
                    DataGridViewRow selectedRow = gridUsuarios.SelectedRows[0];
                    combinedData = await personalCtrl.ObtenerDatosUsuariosCtrl(selectedRow.Cells[0].Value.ToString());
                    UpdateForm.lblCedula.Text = (string)combinedData["Id_personal"];
                    UpdateForm.lblNombresPersonal.Text = (string)combinedData["Nombre_personal"];
                    UpdateForm.lblApellidosPersonal.Text = (string)combinedData["Apellido_personal"];
                    UpdateForm.lblCargoPersonal.Text = (string)combinedData["Cargo"];
                    UpdateForm.txtCorreoU.Text = (string)combinedData["Correo"];
                    UpdateForm.txtTelefonoU.Text = (string)combinedData["Telefono"];
                    UpdateForm.txtDireccionU.Text = (string)combinedData["Direccion"];
                    UpdateForm.picFotoPersonal.Image = Image.FromStream(new MemoryStream((byte[])combinedData["Imagen"]));

                    loadWindow(UpdateForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }
        private Form activeForm = null;
        private void loadWindow(Form Window)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = Window;
            Window.TopLevel = false;
            Window.FormBorderStyle = FormBorderStyle.None;
            Window.Dock = DockStyle.Fill;
            panelUsuarios.Controls.Add(Window);
            panelUsuarios.Tag = Window;
            Window.BringToFront();
            Window.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}