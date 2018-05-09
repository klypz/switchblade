using Klypz.Switchblade.Base64;
using Klypz.Switchblade.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.SwitchbladeTests.Utility
{
    [TestClass]
    public class Base64ConverterTests
    {
        [TestMethod]
        public void ConvertTudo()
        {
            string sourcePath = "..\\..\\filestest\\input";
            string resultPath = "..\\..\\filestest\\output";


            string[] files = Directory.GetFiles(sourcePath);
            string[] deleteFiles = Directory.GetFiles(resultPath, "*.txt");

            deleteFiles.ToList().ForEach(f => File.Delete(f));

            foreach (var item in files)
            {
                string[] filesSplit = item.Split('\\');
                var a = File.OpenRead(item);

                string s = Base64Converter.ToBase64String(a);

                var t = FinderMimeType.GetMimeType(Convert.FromBase64String(s));
                var obj = Base64Converter.FromBase64String(s, out IMimeType mime);

                File.WriteAllText(resultPath + "\\" + filesSplit[filesSplit.Length - 1].Replace('.', '_') + ".txt", s);

                if (obj.GetType() == typeof(MemoryStream))
                {
                    MemoryStream memory = (MemoryStream)obj;

                    using (FileStream fileStream = new FileStream(resultPath + "\\" + filesSplit[filesSplit.Length - 1].Replace('.', '_') + $".{mime.Extension}", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 4096, FileOptions.None))
                    {
                        fileStream.Write(memory.ToArray(), 0, memory.ToArray().Length);
                    }
                }
                //string base64 = imageResult.ToBase64();
            }
        }
    }
}
