using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Base64;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klypz.Switchblade.Extensions;
using System.IO;
using Klypz.Switchblade.Utility;

namespace Klypz.Switchblade.Base64.Tests
{
    [TestClass()]
    public class FinderMimeTypeTests
    {
        [TestMethod()]
        public void IsStringTest()
        {
            var a = "renato".ToBase64();
            string sourcePath = "..\\..\\filestest\\input";
            var a2 = File.OpenRead($"{sourcePath}\\SQLQuery1.sql");
            string s = Base64Converter.ToBase64String(a2);

            var t = FinderMimeType.IsString(Convert.FromBase64String(a));
            t = FinderMimeType.IsString(Convert.FromBase64String(s));
        }
    }
}