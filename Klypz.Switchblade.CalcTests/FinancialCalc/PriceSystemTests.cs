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
    public class PriceSystemTests
    {
        [TestMethod()]
        public void GetMonthlyInstallmentsTest()
        {
            double d = 35000;
            float t = 3.4f / 100;
            int n = 260;

            var tx = PriceSystem.GetRate(35000, 998.60, 48);
            //PriceSystemTable priceTable = new PriceSystemTable(35000, tx, 48);
            //var a = priceTable.ToList();
            double vf = Math.Round(PriceSystem.GetInstallments(d, t, n), 2);

            double test  = PriceSystem.GetPresentValue(vf, t, n);

            var i = Math.Round(PriceSystem.GetRate(d, vf, n)*100,2);

            i = Math.Round(PriceSystem.GetRate(29000, 738.3, 60)*100,2);

            //var l = SAC.GetInstallmentsX(d / n, (n - 1 + 1) * t * (d / n));
            //Assert.Fail();
        }
    }
}