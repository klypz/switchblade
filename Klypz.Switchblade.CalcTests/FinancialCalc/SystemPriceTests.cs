using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Calc.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc.Financial.Tests
{
    [TestClass()]
    public class SystemPriceTests
    {
        [TestMethod()]
        public void GetMonthlyInstallmentsTest()
        {
            double d = 1420;
            float t = 1.5f / 100;
            int n = 6;

            double vf = SystemPrice.GetMonthlyInstallments(d, t, n);

            double test  = SystemPrice.GetPresentValue(vf, t, n);
            Assert.Fail();
        }
    }
}