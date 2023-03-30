using aurora;
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

namespace view.Visual
{
    public partial class Login : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (Aurora.AreTextBoxEmpty(this))
            {
                MessageBox.Show("ERROR!: Debe llenar todos los campos");
            }
            else
            {
                var formEspera = new FormEspera();
                var formSucceful = new LoginExitoso();
                var formFail = new LoginFallido();
                var validarCredencialesTask = personalCtrl.ValidarCredenciales(txtId.Text, txtPass.Text);
                var esperarTask = Task.Delay(1500);

                formEspera.Show();

                await Task.WhenAll(validarCredencialesTask, esperarTask);

                if (validarCredencialesTask.Result)
                {
                    formEspera.Close();
                    formSucceful.Show();
                    formSucceful.lblBienvenida.Text = "Bienvenido " + GlobalVariablesCtrl.ObtenerUsuario();
                    await Task.Delay(2500);
                    formSucceful.Close();
                    Dictionary<int, Form> idVentana = new Dictionary<int, Form>()
                    {
                        {1, new VentanaPrincipalGerente(this) },
                        {2, new VentanaPrincipalRRHH(this) },
                        {3, new VentanaPrincipalAdminCaja(this) },
                        {4, new VentanaPrincipalAdminBodega(this) },
                        {5, new VentanaPrincipalAsistente(this) },
                        {10, new VentanaPrincipalGG(this) }
                    };

                    int id = GlobalVariablesCtrl.ObtenerIdRol();
                    if (idVentana.ContainsKey(id))
                    {
                        Form ventana = idVentana[id];
                        ventana.ShowDialog();
                        this.Hide();
                    }
                    Aurora.ClearForm(this);
                }
                else
                {
                    formEspera.Close();
                    formFail.Show();
                    await Task.Delay(2000);
                    formFail.Close();
                    //MessageBox.Show("ERROR! Credenciales incorrectas");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desa Salir?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //this.Close();
                //this.Dispose();
                //Environment.Exit(0);
                Application.Exit();
            }
        }
    }
}
