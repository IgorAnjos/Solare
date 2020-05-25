using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Solare.Models
{
    public sealed class DES
    {
        public static string Encrypt(string text, byte[] key, byte[] iv)
        {
            string r = null;
            MemoryStream m = new MemoryStream();
            CryptoStream c = new CryptoStream(
                m, (new DESCryptoServiceProvider()).CreateEncryptor(key, iv), CryptoStreamMode.Write);
            byte[] b = (new UnicodeEncoding()).GetBytes(text);
            try
            {
                c.Write(b, 0, b.Length);
                c.FlushFinalBlock();
                r = Convert.ToBase64String(m.ToArray());
            }
            catch { }
            return r;
        }

        public static string Decrypt(string base64Text, byte[] key, byte[] iv)
        {
            string r = null;
            MemoryStream i = new MemoryStream(Convert.FromBase64String(base64Text));
            CryptoStream c = new CryptoStream(
                i, (new DESCryptoServiceProvider()).CreateDecryptor(key, iv), CryptoStreamMode.Read);
            byte[] b = new byte[i.Length];
            try
            {
                int l = c.Read(b, 0, b.Length);
                r = (new UnicodeEncoding()).GetString(b, 0, l);
            }
            catch { }
            return r;
        }

        public static string GetRandomPassword(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ.-!@#$%^&*()".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i--;
            }
            return password;
        }

    }
}
