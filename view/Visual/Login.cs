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
                formEspera.StartPosition = FormStartPosition.CenterScreen;
                formEspera.FormBorderStyle = FormBorderStyle.None;
                formEspera.ShowInTaskbar = false;
                formEspera.TopMost = true;
                formEspera.Show();
                if (await personalCtrl.ValidarCredenciales(txtId.Text, txtPass.Text))
                {
                    formEspera.Close();
                    Dictionary<int, Form> idVentana = new Dictionary<int, Form>()
                    {
                        {1, new VentanaPrincipalGerente() },
                        {2, new VentanaPrincipalRRHH() },
                        {3, new VentanaPrincipalAdminCaja() },
                        {4, new VentanaPrincipalAdminBodega() },
                        {5, new VentanaPrincipalAsistente() },
                        {10, new VentanaPrincipalGG() }
                    };  

                    MessageBox.Show("Acceso Exitoso!, Bienvenido " + GlobalVariablesCtrl.ObtenerUsuario());
                    int id = GlobalVariablesCtrl.ObtenerIdRol();
                    if (idVentana.ContainsKey(id))
                    {
                        Form ventana = idVentana[id];
                        ventana.ShowDialog();
                    }
                }
                else
                {
                    formEspera.Close();
                    MessageBox.Show("ERROR! Credenciales incorrectas");
                }
            }
        }
    }
}
