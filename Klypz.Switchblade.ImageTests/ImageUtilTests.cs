using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Klypz.Switchblade.Image.Tests
{
    [TestClass()]
    public class ImageUtilTests
    {
        [TestMethod()]
        public void ToSquareTest()
        {
            string sourcePath = "..\\..\\ImgTest\\Source";
            string resultPath = "..\\..\\ImgTest\\Result";


            string[] files = Directory.GetFiles(sourcePath, "*.jpg");
            string[] deleteFiles = Directory.GetFiles(resultPath, "*.jpg");

            deleteFiles.ToList().ForEach(f => File.Delete(f));



            foreach (var item in files)
            {
                string[] filesSplit = item.Split('\\');


                System.Drawing.Image image = System.Drawing.Image.FromFile(item);
                var imageResult = image.ResizeScalarByWidth(300);
                imageResult.Save(resultPath + "\\" + filesSplit[filesSplit.Length - 1]);
                imageResult = image.ResizeScalarByHeight(300);
                imageResult.Save(resultPath + "\\v_" + filesSplit[filesSplit.Length - 1]);
                imageResult = image.ToSquare(300);
                imageResult.Save(resultPath + "\\sq_" + filesSplit[filesSplit.Length - 1]);

                string base64 = imageResult.ToBase64();
            }
        }
    }
}