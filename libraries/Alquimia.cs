using Org.BouncyCastle.Crypto.Digests;
using System.Reflection;
using System.Text;

namespace libraries
{
    /// <summary>
    /// Alquimia es la librería dedicada al manejo de datos de diversas formas, 
    /// tal como una magia o ciencia de transformación de datos
    /// </summary>
    public class Alquimia
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
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
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
        public static Dictionary<string, object> CombineObjects(params object[] objects)
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
    }
}