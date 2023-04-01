using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;

namespace aurora
{
    public class Aurora
    {
        /// <summary>
        /// Recibe una entrada de tipo string, generalmente una contraseña para encriptarla con SHA3
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns>El hash de la entrada</returns>
        public static string Encrypt(string entrada)
        {
            Sha3Digest sha3 = new Sha3Digest(256);
            byte[] inputBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hash = new byte[sha3.GetDigestSize()];
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            sha3.DoFinal(hash, 0);
            return Convert.ToBase64String(hash);
        }
 
        /// <summary>
        /// Calcula la edad a partir de una fecha de tipo datetime y la devuelve como entero
        /// </summary>
        /// <param name="fechaNacimiento"></param>
        /// <returns>La edad de un sujeto </returns>
        public static int GetAge(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if(fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        /// <summary>
        /// Combina los datos de N número de objetos con sus atributos, utilizando un diccionario de datos
        /// </summary>
        /// <param name="objects"></param>
        /// <returns>Los objetos combinados</returns>
        public static Dictionary<string, object>CombineObjects(params object[] objects)
        {
            Dictionary<string, object> combinedData = new Dictionary<string, object>();
            
            foreach (object obj in objects)
            {
                PropertyInfo[] properties = obj.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    combinedData[property.Name] = property.GetValue(obj);
                }
            }

            return combinedData;
        }
 
        /// <summary>
        /// Convierte una fecha de tipo datetime a una cadena de string
        /// </summary>
        /// <param name="date"></param>
        /// <returns>La fecha en formato string</returns>
        public static string DateToString(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Recibe como parametro un formulario y comprueba si los text box estan vacios o no devolviendo un bool
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Si los TextBox están vacíos</returns>
        public static bool AreTextBoxEmpty(Form form)
        {
            bool isEmpty = false;
            foreach(Control control in form.Controls)
            {
                if(control is TextBox textBox)
                {
                    if(string.IsNullOrEmpty(textBox.Text))
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }
            return isEmpty;
        }

        /// <summary>
        /// Recibe como parametro un formulario y comprueba si los text box han sido modificado o no, devolviendo un bool
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Si los TextBox han sido modificados</returns>
        public static bool AreTextBoxModified(Form form)
        {
            bool isModified = false;
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Modified == true)
                    {
                        //Los textBox han sido modificados
                        isModified = true;
                    }
                }
            }
            return isModified;
        }

        /// <summary>
        /// Reestablece todos los controles del formulario
        /// </summary>
        /// <param name="form"></param>
        /// <returns>El formulario limpio</returns>
        public static void ClearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                if(control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                if(control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Recibe un email y verifica que tenga el formato válido
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Si el correo es válido</returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                var valido = new System.Net.Mail.MailAddress(email);
                return valido.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static string DecryptConnectionString(string connectionString)
        {
            string encryptionKey = "elin";
            connectionString = connectionString.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(connectionString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    connectionString = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return connectionString;
        }

    }
}