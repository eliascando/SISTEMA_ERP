using libraries;
using utilitaries;
using control;
using view.Visual.Main;
using view.Properties;
using System.Security.Cryptography;
using System.Text;
using utilitaries.CustomForms;

namespace view.Visual
{
    public partial class Login : Form
    {
        PersonalCtrl personalCtrl = new PersonalCtrl();
        bool isShowPass = false;
        private string well_come;
        public Login()
        {
            InitializeComponent();
            Loading.Visible = false;
            Guardian.ValidateIdInputCustom(txtId);
            Aurora.HidePasswordCustom(txtPass);
            ValidateFileEncryption();
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
            Form dialogo = new DialogBox(this,"Confirmación", "Está seguro que desea Salir?");
            dialogo.ShowDialog();
            if (dialogo.DialogResult.Equals(DialogResult.OK))
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
                Aurora.ShowPasswordCustom(txtPass);
                PassStatusIcon.Image = Resources.show_pass;
                isShowPass = true;
            }
            else
            {
                Aurora.HidePasswordCustom(txtPass);
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
            GlobalVariablesCtrl.AsignarParentForm(this);
            Form forgotPass = new ForgotPassword();
            loadState(forgotPass);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            RegistroActividadesCtrl registroActividades = new RegistroActividadesCtrl();
            try
            {
                if (Aurora.AreTextBoxPanelEmptyCustom(panelLogin))
                {
                    Form alert = new AlertBox(this, "warning", "Atención!", "Debe ingresar todos los campos");
                    alert.Show();
                }
                else if (txtId.Texts.Length < 10)
                {
                    Form alert = new AlertBox(this, "warning", "Atencion!", "Debe ingresar un ID válido");
                    alert.Show();
                }
                else
                {
                    btnLogin.Visible = false;
                    Loading.Visible = true;

                    var validarCredencialesTask = personalCtrl.ValidarCredenciales(txtId.Texts, txtPass.Texts);
                    var esperarTask = Task.Delay(1500);

                    await Task.WhenAll(validarCredencialesTask, esperarTask);

                    if (validarCredencialesTask.Result)
                    {
                        AsignarGenero();
                        Aurora.ClearPanel(panelLogin);
                        btnLogin.Visible = true;
                        Loading.Visible = false;
                        await registroActividades.RegistroInicioSesionCtrl(txtId.Texts, "Acceso Exitoso");
                        Form alert = new AlertBox(this, "success", "Acceso Exitoso!", well_come + " " + GlobalVariablesCtrl.ObtenerUsuario());
                        alert.ShowDialog();

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
                            GlobalVariablesCtrl.AsignarParentForm(ventana);
                            this.Hide();
                            ventana.Show();
                        }
                    }
                    else
                    {
                        if (GlobalVariablesCtrl.ObtenerIdUsuarioValidator() == txtId.Texts)
                        {
                            await registroActividades.RegistroInicioSesionCtrl(txtId.Texts, "Acceso Fallido");
                            GlobalVariablesCtrl.AsignarIdUsuarioValidator("");
                        }
                        Form alert = new AlertBox(this, "error", "Acceso Fallido!", "Credenciales Incorrectas");
                        alert.Show();
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
        private void AsignarGenero()
        {
            string welcome = GlobalVariablesCtrl.ObtenerSexo();
            if (String.IsNullOrEmpty(welcome))
            {
                well_come = "Bienvenid@";
            }
            else if (welcome == "Femenino")
            {
                well_come = "Bienvenida";
            }
            else if (welcome == "Masculino")
            {
                well_come = "Bienvenido";
            }
        }
    }
}