using System;
using System.Security.Cryptography;
using System.Text;

namespace JellalMohamed.Dam.Mp09.Uf01.Pr2.Seguridad.Model.Security
{
    public static class MD5Security
    {
        public static string Encrypt(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

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
