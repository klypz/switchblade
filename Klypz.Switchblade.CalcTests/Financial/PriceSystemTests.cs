using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Klypz.Switchblade.Calc.Financial.Tests
{
    [TestClass()]
    public class PriceSystemTests
    {
        double presentValue = 4500.50;
        float rate = 1.4f / 100;
        int time = 38;

        [TestMethod]
        [TestCategory("PriceSystem")]
        public void PriceCalcTest()
        {
            double installment = PriceSystem.GetInstallments(presentValue, rate, time);

            Assert.AreEqual(presentValue, Math.Round(PriceSystem.GetPresentValue(installment, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 3), Math.Round(PriceSystem.GetRate(presentValue, installment, time),3));
        }

        [TestMethod]
        [TestCategory("PriceSystem")]
        public void PriceTableTest()
        {
            PriceSystemTable priceSystemTable = new PriceSystemTable(presentValue, rate, time, 2);
            var lst = priceSystemTable.ToList();
            Assert.AreEqual(0, lst.Last().Balance);
        }
    }
}