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
    public class DiscountTests
    {
        double principal = 35000;
        float rate = 1.6f / 100;
        int time = 4;

        string msgErro = "Erro no cálculo [{0}] no teste [{1}]";

        [TestMethod]
        [TestCategory("Discount")]
        public void CompoundDiscountRationalTest()
        {
            double futureValue = 0;

            futureValue = CompoundDiscount.GetFutureValueRational(principal, rate, time);

            Assert.AreEqual(rate, CompoundDiscount.GetRateRational(futureValue, principal, time));
            Assert.AreEqual(time, CompoundDiscount.GetTimeRational(futureValue, principal, rate));
            Assert.AreEqual(principal, CompoundDiscount.GetPresentValueRational(futureValue, rate, time));
        }

        [TestMethod]
        [TestCategory("Discount")]
        public void CompoundDiscountTest()
        {
            double futureValue = 0;

            futureValue = CompoundDiscount.GetFutureValue(principal, rate, time);

            Assert.AreEqual(rate, CompoundDiscount.GetRate(futureValue, principal, time));
            Assert.AreEqual(time, CompoundDiscount.GetTime(futureValue, principal, rate));
            Assert.AreEqual(principal, CompoundDiscount.GetPresentValue(futureValue, rate, time));
        }
    }
}