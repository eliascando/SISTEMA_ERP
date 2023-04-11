using control;
using libraries;
using view.Properties;

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
                    if (combinedData.ContainsKey("Imagen") && combinedData["Imagen"] != null)
                    {
                        DatosForm.picFotoUsuario.Image = Image.FromStream(new MemoryStream((byte[])combinedData["Imagen"]));
                    }
                    else
                    {
                        DatosForm.picFotoUsuario.Image = Resources.default_user_picture;
                    }
                    DatosForm.lblUsuario.Text = (string)combinedData["Usuario"];
                    DatosForm.lblEdad.Text = Alquimia.GetAge((DateTime)combinedData["Fecha_nacimiento"]).ToString();

                    Aurora.LoadFormInPanel(DatosForm, panelUsuarios, ref activeForm);
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
                    if (combinedData.ContainsKey("Imagen") && combinedData["Imagen"] != null)
                    {
                        UpdateForm.picFotoPersonal.Image = Image.FromStream(new MemoryStream((byte[])combinedData["Imagen"]));
                    }
                    else
                    {
                        UpdateForm.picFotoPersonal.Image = Resources.default_user_picture;
                        UpdateForm.btnChangeImagen.Text = "Añadir";
                    }
                    

                    Aurora.LoadFormInPanel(UpdateForm, panelUsuarios, ref activeForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }
        private Form activeForm = null;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridUsuarios.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}