using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace aurora
{
    public class Aurora
    {
        public static string EncriptarPassword(string password)
        {
            string hashedpassword;
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                hashedpassword = Convert.ToBase64String(hash);
            }
            return hashedpassword;
        }
    }
}
