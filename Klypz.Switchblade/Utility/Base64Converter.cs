using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Utility
{
    public static partial class Base64Converter
    {
        public static string ToBase64(string input)
        {
            byte[] bResult = Encoding.UTF8.GetBytes(input);
            string result = Convert.ToBase64String(bResult);

            return result;
        }

        public static string ToBase64(Stream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            Char[] outArray = new Char[(int)(stream.Length * 1.34)];
            stream.Read(inArray, 0, (int)stream.Length);
            return Convert.ToBase64String(inArray);
            //Convert.ToBase64CharArray(inArray, 0, inArray.Length, outArray, 0);
            //return new MemoryStream(Encoding.UTF8.GetBytes(outArray));
        }

        public static string ToBase64(FileStream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            Char[] outArray = new Char[(int)(stream.Length * 1.34)];
            stream.Read(inArray, 0, (int)stream.Length);
            return Convert.ToBase64String(inArray);
        }

        public static string ToBase64(Image input, ImageFormat format = null)
        {
            string base64String = null;

            if (format == null)
            {
                format = GetImageFormat(input.RawFormat);
            }

            using (MemoryStream m = new MemoryStream())
            {
                input.Save(m, format);
                byte[] imageBytes = m.ToArray();

                base64String = Convert.ToBase64String(imageBytes);
            }
            return base64String;
        }

        public static object FromBase64(string input)
        {
            return "";
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

        private static AttachmentType DetectingBase64Mime(string input)
        {
            string prefix = input.Substring(0, 5);

            switch (prefix)
            {
                case "IVBOR":
                case "/9J/4":
                    return AttachmentType.Image;
                case "AAAAF":
                    return AttachmentType.Video;
                case "JVBER":
                    return AttachmentType.PDF;
                default:
                    return AttachmentType.Unknown;
            }
        }
    }

    public enum AttachmentType
    {
        Unknown = -1,
        Image = 100,
        Video = 200,
        PDF = 300
    }
}
