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
    }
}