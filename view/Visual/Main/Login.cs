using libraries;
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
using view.Visual.Main;

namespace view.Visual
{
    public partial class Login : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        public Login()
        {
            InitializeComponent();
            Loading.Visible = false;
            AlertId.Visible = false;
            AlertPass.Visible = false;
            lblMensaje.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            try
            {
                if (Aurora.AreTextBoxPanelEmpty(panelLogin))
                {
                    if (String.IsNullOrEmpty(txtId.Text))
                    {
                        AlertId.Visible = true;
                    }
                    if (String.IsNullOrEmpty(txtPass.Text))
                    {
                        AlertPass.Visible = true;
                    }
                    lblMensaje.Visible = true;
                    await Task.Delay(3000);
                    lblMensaje.Visible = false;
                }
                else
                {
                    btnLogin.Visible = false;
                    Loading.Visible = true;

                    var validarCredencialesTask = personalCtrl.ValidarCredenciales(txtId.Text, txtPass.Text);
                    var esperarTask = Task.Delay(1500);

                    await Task.WhenAll(validarCredencialesTask, esperarTask);

                    if (validarCredencialesTask.Result)
                    {
                        Form success = new LoginSuccess();
                        loadState(success);
                        await Task.Delay(2000);
                        closeState(success);

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
                            this.Hide();
                            ventana.Show();
                        }
                        Aurora.ClearPanel(panelLogin);
                        btnLogin.Visible = true;
                        Loading.Visible = false;
                    }
                    else
                    {
                        Form fail = new LoginFail();
                        loadState(fail);
                        await Task.Delay(2000);
                        closeState(fail);
                        btnLogin.Visible = true;
                        Loading.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desa Salir?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
                Environment.Exit(0);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            AlertId.Visible = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            AlertPass.Visible = false;
        }
        private Form activeForm = null;
        private void loadState(Form panelEstadoLogin)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = panelEstadoLogin;
            panelEstadoLogin.TopLevel = false;
            panelEstadoLogin.FormBorderStyle = FormBorderStyle.None;
            panelEstadoLogin.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(panelEstadoLogin);
            panelLogin.Tag = panelEstadoLogin;
            panelEstadoLogin.BringToFront();
            panelEstadoLogin.Show();
        }
        private void closeState(Form panelEstadoLogin)
        {
            panelEstadoLogin.Close();
        }
    }
}
