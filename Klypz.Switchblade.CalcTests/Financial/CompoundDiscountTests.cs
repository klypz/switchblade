using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Klypz.Switchblade.Calc.Financial.Tests
{
    [TestClass()]
    public class CompoundDiscountTests
    {
        double pv = 35000;
        float i = 1.6f / 100;
        int time = 4;

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [TestCategory("Discount")]
        public void CompoundDiscountRationalTest()
        {
            double fv = CompoundDiscount.GetFutureValueRational(pv, i, time);
            double d = CompoundDiscount.GetDicountValueRational(fv, i, time);

            TestContext.WriteLine("----- Desconto Composto Racional -----");
            TestContext.WriteLine($"Onde: PV = {pv} | i = {Math.Round(i*100,4)}% | n = {time} -> FV = {Math.Round(fv, 2)} | D = {Math.Round(d,2)}");

            Assert.AreEqual(i, CompoundDiscount.GetRateRational(fv, pv, time));
            Assert.AreEqual(time, CompoundDiscount.GetTimeRational(fv, pv, i));
            Assert.AreEqual(pv, CompoundDiscount.GetPresentValueRational(fv, i, time));
        }

        [TestMethod]
        [TestCategory("Discount")]
        public void CompoundDiscountTest()
        {
            double fv = CompoundDiscount.GetFutureValue(pv, i, time);
            double d = CompoundDiscount.GetDicountValue(fv, i, time);

            TestContext.WriteLine("----- Desconto Composto Comercial -----");
            TestContext.WriteLine($"Onde: PV = {pv} | i = {Math.Round(i*100,4)}% | n = {time} -> FV = {Math.Round(fv, 2)} | D = {Math.Round(d,2)}");

            Assert.AreEqual(i, CompoundDiscount.GetRate(fv, pv, time));
            Assert.AreEqual(time, CompoundDiscount.GetTime(fv, pv, i));
            Assert.AreEqual(pv, CompoundDiscount.GetPresentValue(fv, i, time));
        }
    }
}