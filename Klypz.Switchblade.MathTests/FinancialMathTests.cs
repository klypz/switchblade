using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Math.Tests
{
    [TestClass()]
    public class FinancialMathTests
    {
        [TestMethod()]
        public void GetInterestTest()
        {
            var j = FinancialMath.GetInterest(340, 300, 4);
            Assert.Fail();
        }
    }
}