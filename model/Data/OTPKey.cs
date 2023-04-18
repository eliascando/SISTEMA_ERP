using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace model.Data
{
    public class OTPKey
    {
        public static string GenerateOTP(string secretKey)
        {
            string counterFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "counter.dat");
            int digits = 6;
            long counter = ReadCounterFromFile(counterFilePath); // Leer el contador del archivo
            GlobalVariables.currentCounter = counter;

            byte[] counterBytes = BitConverter.GetBytes(counter);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            byte[] keyBytes = Encoding.ASCII.GetBytes(secretKey);
            byte[] hash;

            using (HMACSHA256 hmac = new HMACSHA256(keyBytes))
            {
                hash = hmac.ComputeHash(counterBytes);
            }

            int offset = hash[hash.Length - 1] & 0x0F;
            int binaryCode = ((hash[offset] & 0x7F) << 24)
                | ((hash[offset + 1] & 0xFF) << 16)
                | ((hash[offset + 2] & 0xFF) << 8)
                | (hash[offset + 3] & 0xFF);

            int oneTimePassword = binaryCode % (int)Math.Pow(10, digits);
            string otp = oneTimePassword.ToString().PadLeft(digits, '0');

            counter++; // Incrementar el contador
            WriteCounterToFile(counter, counterFilePath); // Escribir el contador actualizado en el archivo

            return otp;
        }
        public static bool ValidateOTP(string secretKey, string otp)
        {
            long counter = GlobalVariables.currentCounter;
            int digits = 6;
            byte[] counterBytes = BitConverter.GetBytes(counter);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(counterBytes);
            }

            byte[] keyBytes = Encoding.ASCII.GetBytes(secretKey);
            byte[] hash;

            using (HMACSHA256 hmac = new HMACSHA256(keyBytes))
            {
                hash = hmac.ComputeHash(counterBytes);
            }

            int offset = hash[hash.Length - 1] & 0x0F;
            int binaryCode = ((hash[offset] & 0x7F) << 24)
                | ((hash[offset + 1] & 0xFF) << 16)
                | ((hash[offset + 2] & 0xFF) << 8)
                | (hash[offset + 3] & 0xFF);

            int oneTimePassword = binaryCode % (int)Math.Pow(10, digits);
            string generatedOTP = oneTimePassword.ToString().PadLeft(digits, '0');

            return otp == generatedOTP;
        }

        private static long ReadCounterFromFile(string counterFilePath)
        {
            if (File.Exists(counterFilePath))
            {
                string counterString = File.ReadAllText(counterFilePath);
                if (long.TryParse(counterString, out long counter))
                {
                    return counter;
                }
            }

            return 0; // Valor predeterminado si el archivo no existe o no se puede leer el contador
        }

        private static void WriteCounterToFile(long counter, string counterFilePath)
        {
            File.WriteAllText(counterFilePath, counter.ToString());
        }
    }
}
