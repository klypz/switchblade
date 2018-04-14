using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Klypz.Switchblade.Basic
{
    public static class StringExtension
    {
        /// <summary>
        /// <para>Remove acentuação, espaços, caracteres especiais e converte tudo para minúsculo</para>
        /// </summary>
        /// <param name="self">String a ser transformada</param>
        /// <returns>Texto no formato de "alias"</returns>
        public static string ToAlias(this string self)
        {
            Regex reg = new Regex(@"[^A-Za-z0-9_\-]+");
            string result = self;
            result = result.Replace(' ', '-');
            result = result.NoAccents();
            result = result.ToLower();
            result = reg.Replace(result, "");

            return result;
        }

        /// <summary>
        /// Remove acentos de uma string
        /// </summary>
        /// <param name="self">String a ser tratada</param>
        /// <returns>Texto sem acentuação</returns>
        public static string NoAccents(this string self)
        {
            var normalizedString = self.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// <para>Converte um texto em Base64, modificando alguns aspectos</para>
        /// <para>Remove "=", substitui "/" por "_", substitui "+" por "-"</para>
        /// <para>Codificação de texto UTF-8</para>
        /// </summary>
        /// <param name="self">Texto a ser convertido</param>
        /// <returns>Base64 reduzida</returns>
        public static string ToBase64Reduced(this string self)
        {
            byte[] bResult = Encoding.UTF8.GetBytes(self);
            string result = Convert.ToBase64String(bResult);
            result.Replace("=", "").Replace("/", "_").Replace("+", "-");

            return result;
        }

        /// <summary>
        /// <para>Converte em texto uma string Base64 Reduzida</para>
        /// </summary>
        /// <param name="self">String Base 64 Reduzida</param>
        /// <returns>Texto extraído da Base64</returns>
        public static string FromBase64Reduced(this string self)
        {
            return self.Replace("_", "/").Replace("-", "+") + (new string('=', self.Length % 4));
        }
    }
}
