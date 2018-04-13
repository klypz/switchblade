using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Klypz.Switchblade.Cryptography
{
    /// <summary>
    /// Algorítmo simétrico para criptografar uma string
    /// </summary>
    public class SymmetricEncrypt
    {
        private string secret = "";
        /// <param name="secret">Chave para criptografar ou descriptografar uma string</param>
        public SymmetricEncrypt(string secret)
        {
            this.secret = secret;
        }

        private void MountSecret(out byte[] rSecret, out byte[] r2Secret)
        {
            HashString hashSecret = new HashString(secret);
            byte[] bSecret = Encoding.Default.GetBytes(hashSecret.GetHashString(HashStringType.MD5));
            HashString hashSecret2 = new HashString(Convert.ToBase64String(bSecret));
            byte[] bSecret2 = Encoding.Default.GetBytes(hashSecret2.GetHashString(HashStringType.MD5));

            rSecret = bSecret;
            r2Secret = bSecret2;
        }

        private byte[] WriterStream(byte[] content, ICryptoTransform encryptor)
        {
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(content, 0, content.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();

            return cipherTextBytes;
        }

        /// <summary>
        /// Criptografar uma string
        /// </summary>
        /// <param name="input">Texto a ser criptografado</param>
        /// <returns>Texto criptografado com base em uma chave</returns>
        public string Encrypt(string input)
        {
            byte[] bText = Encoding.Default.GetBytes(input);
            MountSecret(out byte[] bSecret, out byte[] bSecret2);
            RijndaelManaged symmetricKey = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                BlockSize = bSecret.Length * 8
            };
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(bSecret2, bSecret);
            byte[] cipherTextBytes = WriterStream(bText, encryptor);
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }

        /// <summary>
        /// Descriptografa uma string
        /// </summary>
        /// <param name="textEncrypted">Texto criptografado</param>
        /// <returns>Texto descriptografado com base em uma chave</returns>
        public string Decrypt(string textEncrypted)
        {
            byte[] bText = Convert.FromBase64String(textEncrypted);
            MountSecret(out byte[] bSecret, out byte[] bSecret2);
            RijndaelManaged symmetricKey = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                BlockSize = bSecret.Length * 8
            };
            ICryptoTransform encryptor = symmetricKey.CreateDecryptor(bSecret2, bSecret);
            byte[] cipherTextBytes = WriterStream(bText, encryptor);
            string cipherText = Encoding.Default.GetString(cipherTextBytes);

            return cipherText;
        }
    }
}
