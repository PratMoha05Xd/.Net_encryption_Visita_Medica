using System;
using System.Security.Cryptography;
using System.Text;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Security
{
    public static class SHA256Security
    {
        public static string Encrypt(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
