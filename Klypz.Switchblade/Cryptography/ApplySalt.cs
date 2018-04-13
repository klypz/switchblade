using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Cryptography
{
    public class ApplySalt
    {
        private string input = "", salt = "";

        public ApplySalt(string input, string salt)
        {
            this.input = input;
            this.salt = salt;
        }

        /// <summary>
        /// Método para increntar a segurança de inversã de criptograda
        /// </summary>
        /// <param name="hashType">Padrão de criptografia utilizada</param>
        /// <param name="iterations">Número de vezes que a iteração utiliza a chave</param>
        /// <param name="keySize">Tamanho da chave</param>
        /// <returns>Retorna uma combinação entre duas strings</returns>
        public string Get(HashStringType hashType = HashStringType.SHA1, int iterations = 10, int keySize = 64)
        {
            byte[] bSalt = Encoding.Default.GetBytes(salt);
            byte[] bInput = Encoding.Default.GetBytes(input);
            string hashName = hashType.ToString();


            PasswordDeriveBytes deriveBytes = new PasswordDeriveBytes(bInput, bSalt, hashName, iterations);

            var b = deriveBytes.GetBytes(keySize);
            return Convert.ToBase64String(b);
        }
    }
}
