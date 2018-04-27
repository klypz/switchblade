using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Utility
{
    public static class Base64Converter
    {
        public static string ToBase64(string input)
        {
            byte[] output = Encoding.Default.GetBytes(input);

            return Convert.ToBase64String(output);
        }

        public static string ToBase64(Stream input)
        {
            using (MemoryStream output = new MemoryStream())
            {
                byte[] buffer = new byte[16 * 1024];
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, read);
                }
                byte[] converter = output.ToArray();

                return Convert.ToBase64String(converter);
            }

        }
    }
}
