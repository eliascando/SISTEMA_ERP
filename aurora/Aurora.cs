using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;

namespace aurora
{
    public class Aurora
    {
        //Encrypt recibe una entrada de tipo string, generalmente una contraseña para encriptarla con SHA3 y obtener el string de la entrada enciptado
        public static string Encrypt(string entrada)
        {
            Sha3Digest sha3 = new Sha3Digest(256);
            byte[] inputBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hash = new byte[sha3.GetDigestSize()];
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            sha3.DoFinal(hash, 0);
            return Convert.ToBase64String(hash);
        }

        //GetAge obtiene la edad a partir de una fecha de tipo datetime
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

        //CombineObjects combina los datos de N número de objetos con sus atributos, utilizando un diccionario de datos
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

        //DateToString convierte una fecha de tipo datetime a una cadena de string
        public static string DateToString(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
        
        //AreTextBoxEmpty recibe como parametro un formulario y comprueba si los text box estan vacios o no devolviendo un bool
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

        //AreTextBoxModified recibe como parametro un formulario y comprueba si los text box han sido modificado o no, devolviendo un bool
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

        //IsValidEmail recibe un string y verifica que el correo tenga un formato valido
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
    }
}