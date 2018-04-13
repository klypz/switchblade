using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Basic.Tests
{
    [TestClass()]
    public class PasswordGeneratorTests
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod()]
        public void NewPasswordTest()
        {
            TestContext.WriteLine(PasswordGenerator.NewPassword(30));
        }
    }
}