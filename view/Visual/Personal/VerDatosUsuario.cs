using control;
using view.Properties;

namespace view.Visual
{
    public partial class VerDatosUsuario : Form
    {
        private VerUsuarios verUsuario_prueba;
        RegistroActividadesCtrl registroActividades = new RegistroActividadesCtrl();
        public VerDatosUsuario(VerUsuarios verUsuarios_Prueba)
        {
            InitializeComponent();
            this.verUsuario_prueba = verUsuarios_Prueba;
            if (lblCargo.Text == "Asistente")
            {
                this.lblVentas.Visible = this.lblVentasMes.Visible = true;
            }
            else
            {
                this.lblVentas.Visible = this.lblVentasMes.Visible = false;
            }
        }
        public async Task CargarTablas()
        {
            try
            {
                dgvInicioSesion.DataSource = await registroActividades.ObtenerLoginsPorUsuarioCtrl(lblID.Text);
                dgvModificaciones.DataSource = await registroActividades.ObtenerModificacionesPorUsuarioCtrl(lblID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
        }

        private async void VerDatosUsuario_Load(object sender, EventArgs e)
        {
            await CargarTablas();
        }

        private void ReloadBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReloadBtn.Image = Resources.noun_reload_release;
        }

        private void ReloadBtn_MouseUp(object sender, MouseEventArgs e)
        {
            ReloadBtn.Image = Resources.noun_reload_hold;
        }

        private async void ReloadBtn_Click(object sender, EventArgs e)
        {
            await CargarTablas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}