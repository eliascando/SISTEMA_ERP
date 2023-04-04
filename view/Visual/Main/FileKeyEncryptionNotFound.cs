using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control;
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
            string filePath = Path.Combine(rootFolder, "encryptionKey.bin");
            if (Aurora.AreTextBoxEmpty(this))
            {
                MessageBox.Show("ERROR!: Ingrese la llave de cifrado");
            }
            else
            {
                GlobalVariablesCtrl.AsignarKeyEncryption(Alquimia.Encrypt(txtKeyEncryption.Text.Trim()));
                byte[] keyEncryptBytes = Encoding.UTF8.GetBytes(Alquimia.Encrypt(txtKeyEncryption.Text.Trim()));
                string keyEncryptBase64 = Convert.ToBase64String(keyEncryptBytes);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(fileStream))
                    {
                        writer.Write(keyEncryptBase64);
                    }
                }
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Llave de cifrado guardada con éxito");
                    this.Close();
                }
            }
        }
    }
}