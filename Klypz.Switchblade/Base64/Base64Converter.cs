﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Base64
{
    public static partial class Base64Converter
    {
        public static string ToBase64String(string input)
        {
            byte[] bResult = Encoding.UTF8.GetBytes(input);
            string result = Convert.ToBase64String(bResult);

            return result;
        }

        public static string ToBase64String(Stream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            Char[] outArray = new Char[(int)(stream.Length * 1.34)];
            stream.Read(inArray, 0, (int)stream.Length);
            return Convert.ToBase64String(inArray);
        }

        public static string ToBase64String(FileStream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            Char[] outArray = new Char[(int)(stream.Length * 1.34)];
            stream.Read(inArray, 0, (int)stream.Length);
            return Convert.ToBase64String(inArray);
        }

        public static object FromBase64String(string input, out IMimeType mime)
        {
            byte[] result = Convert.FromBase64String(input);

            if (FinderMimeType.IsString(result))
            {
                mime = new MimeType("#string#", "", null);
                return Encoding.UTF8.GetString(result);
            }
            else
            {
                var _mime = FinderMimeType.GetMimeType(result);
                MemoryStream m = new MemoryStream(result);
                mime = _mime;
                return m;
            }

        }

        private static ImageFormat GetImageFormat(ImageFormat imageFormat)
        {
            List<Guid> lstFormat = new List<Guid>
            {
                ImageFormat.Emf.Guid,
                ImageFormat.MemoryBmp.Guid
            };

            if (lstFormat.Any(p => p == imageFormat.Guid))
            {
                return ImageFormat.Jpeg;
            }
            else
            {
                var prop = typeof(ImageFormat).GetProperties().ToList().FirstOrDefault(f =>
                   f.PropertyType == typeof(ImageFormat)
                   && ((ImageFormat)f.GetValue(null, null)).Guid == imageFormat.Guid);

                if (prop != null)
                {
                    return ((ImageFormat)prop.GetValue(null, null));
                }
                else
                {
                    return ImageFormat.Jpeg;
                }
            }
        }
    }
}
