using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Solare.Models
{
    public sealed class DES_Keys
    {
        public static SymmetricAlgorithm _algorithm;

        public static byte[] CryptographyKey
        {
            get
            {
                string salt = string.Empty;

                _algorithm = new DESCryptoServiceProvider();
                _algorithm.Mode = CipherMode.CBC;
                _algorithm.IV = DES_Keys.CryptographyIV;

                // Ajusta o tamanho da chave se necessário e retorna uma chave válida
                if (_algorithm.LegalKeySizes.Length > 0)
                {
                    // Tamanho das chaves em bits
                    int keySize = GetKey.Length * 8;
                    int minSize = _algorithm.LegalKeySizes[0].MinSize;
                    int maxSize = _algorithm.LegalKeySizes[0].MaxSize;
                    int skipSize = _algorithm.LegalKeySizes[0].SkipSize;

                    if (keySize > maxSize)
                    {
                        // Busca o valor máximo da chave
                        GetKey = GetKey.Substring(0, maxSize / 8);
                    }
                    else if (keySize < maxSize)
                    {
                        // Seta um tamanho válido
                        int validSize = (keySize <= minSize) ? minSize : (keySize - keySize % skipSize) + skipSize;
                        if (keySize < validSize)
                        {
                            // Preenche a chave com arterisco para corrigir o tamanho
                            GetKey = GetKey.PadRight(validSize / 8, '*');
                        }
                    }
                }
                PasswordDeriveBytes key = new PasswordDeriveBytes(GetKey, ASCIIEncoding.ASCII.GetBytes(salt));
                return key.GetBytes(GetKey.Length);
            }
        }
        public static byte[] CryptographyIV
        {
            get
            {
                byte[] b = { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };
                return b;
            }
        }

        static string _getkey;
        public static string GetKey
        {
            get
            {
                return _getkey;
            }
            set
            {
                _getkey = value;
            }
        }
    }
}
