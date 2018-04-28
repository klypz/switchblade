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

                string s  = Base64Converter.ToBase64(a);

                File.WriteAllText(resultPath + "\\" + filesSplit[filesSplit.Length - 1].Replace('.', '_') + ".txt", s);

                //string base64 = imageResult.ToBase64();
            }
        }
    }
}
