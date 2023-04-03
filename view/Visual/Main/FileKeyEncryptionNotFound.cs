using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraries;
using view.Properties;

namespace view.Visual.Main
{
    public partial class FileKeyEncryptionNotFound : Form
    {
        bool isShowKey = false;
        public FileKeyEncryptionNotFound()
        {
            InitializeComponent();
            Aurora.HidePassword(txtKeyEncryption);
        }

        private void PassStatusIcon_Click(object sender, EventArgs e)
        {
            if (isShowKey == false)
            {
                Aurora.ShowPassword(txtKeyEncryption);
                PassStatusIcon.Image = Resources.show_pass;
                isShowKey = true;
            }
            else
            {
                Aurora.HidePassword(txtKeyEncryption);
                PassStatusIcon.Image = Resources.hide_pass;
                isShowKey = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rootFolder = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(rootFolder, "encryptionKey.txt");
            if (Aurora.AreTextBoxEmpty(this))
            {
                MessageBox.Show("ERROR!: Ingrese la llave de cifrado");
            }
            else
            {
                File.WriteAllText(filePath, Alquimia.Encrypt(txtKeyEncryption.Text.Trim()));
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Llave de cifrado guardada con éxito");
                    this.Close();
                }
            }
        }
    }
}