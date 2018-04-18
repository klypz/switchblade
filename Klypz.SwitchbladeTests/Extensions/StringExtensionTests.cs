using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Extensions.Tests
{
    [TestClass()]
    public class StringExtensionTests
    {
        [TestMethod()]
        public void ToBase64ReducedTest()
        {
            string codigo = "Ro!7uf50)po:P*UF78_)iW";

            var b64 = codigo.ToBase64();
            //Um8hN3VmNTApcG86UCpVRjc4XylpVw==
            var b64Reduce = codigo.ToBase64Reduced();
            //Um8hN3VmNTApcG86UCpVRjc4XylpVw
            var b64Reverse = b64Reduce.FromBase64Reduced();
            //Um8hN3VmNTApcG86UCpVRjc4XylpVw==
        }
    }
}