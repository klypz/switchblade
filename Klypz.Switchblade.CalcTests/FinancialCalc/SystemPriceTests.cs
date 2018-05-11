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
            double d = 95000;
            float t = 3.4f / 100;
            int n = 260;

            double vf = Math.Round(SystemPrice.GetMonthlyInstallments(d, t, n), 2);

            double test  = SystemPrice.GetPresentValue(vf, t, n);

            var i = Math.Round(SystemPrice.GetRate(d, vf, n)*100,2);

            i = Math.Round(SystemPrice.GetRate(29000, 738.3, 60)*100,2);

            var l = SAC.GetInstallmentsX(d / n, (n - 1 + 1) * t * (d / n));
            Assert.Fail();
        }
    }
}