using libraries;
using control;
using view.Visual.Main;
using view.Properties;
using System.Security.Cryptography;
using System.Text;

namespace view.Visual
{
    public partial class Login : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        bool isShowPass = false;
        public Login()
        {
            InitializeComponent();
            Loading.Visible = false;
            AlertId.Visible = false;
            AlertPass.Visible = false;
            lblMensaje.Visible = false;
            Guardian.ValidateIdInput(txtId);
            Aurora.HidePassword(txtPass);
            ValidateFileEncryption();
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
                if (ex is CryptographicException)
                {
                    btnLogin.Enabled = false;
                }
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex);
                btnLogin.Visible = true;
                Loading.Visible = false;
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
        private void ExitIco_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desa Salir?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
                Environment.Exit(0);
            }
        }
        private void PassStatusIcon_Click(object sender, EventArgs e)
        {
            if (isShowPass == false)
            {
                Aurora.ShowPassword(txtPass);
                PassStatusIcon.Image = Resources.show_pass;
                isShowPass = true;
            }
            else
            {
                Aurora.HidePassword(txtPass);
                PassStatusIcon.Image = Resources.hide_pass;
                isShowPass = false;
            }

        }
        private void ValidateFileEncryption()
        {
            string rootFolder = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(rootFolder, "encryptionKey.bin");
            if (!File.Exists(filePath))
            {
                Form fileKey = new FileKeyEncryptionNotFound();
                loadState(fileKey);
            }
            else
            {
                string keyEncryptBase64;
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                    {
                        keyEncryptBase64 = reader.ReadString();
                    }
                }
                byte[] keyEncryptBytes = Convert.FromBase64String(keyEncryptBase64);
                string keyEncrypt = Encoding.UTF8.GetString(keyEncryptBytes);
                GlobalVariablesCtrl.AsignarKeyEncryption(keyEncrypt);
            }
        }

        private void linklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form forgotPass = new ForgotPassword();
            loadState(forgotPass);
        }
    }
}