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
    public class InterestTests
    {
        double principal = 2398.57;
        int time = 30;
        float rate = 1.7f / 100;

        [TestMethod]
        [TestCategory("Interest")]
        public void SimpleInterestTest()
        {
            double amount = SimpleInterest.GetAmount(principal, rate, time);
            double interest = SimpleInterest.GetInterest(principal, rate, time);

            Assert.AreEqual(principal, SimpleInterest.GetPrincipal(amount, rate, time));
            Assert.AreEqual(time, SimpleInterest.GetTime(interest, principal, rate));
            Assert.AreEqual(rate, SimpleInterest.GetRate(interest, principal, time));
        }

        [TestMethod]
        [TestCategory("Interest")]
        public void CompoundInterestTest()
        {
            double amount = CompoundInterest.GetAmount(principal, rate, time);
            double interest = CompoundInterest.GetInterest(principal, rate, time);

            Assert.AreEqual(principal, CompoundInterest.GetPrincipal(amount, rate, time));
            Assert.AreEqual(time, CompoundInterest.GetTime(amount, principal, rate));
            Assert.AreEqual(rate, CompoundInterest.GetRate(amount, principal, time));
        }

        [TestMethod]
        [TestCategory("Discount")]
        public void SimpleDiscountTest()
        {
            double amount = SimpleDiscount.GetPresentValue(principal, rate, time);
            double discount = SimpleDiscount.GetDiscount(principal, rate, time);

            Assert.AreEqual(principal, SimpleDiscount.GetFutureValue(amount, rate, time));
            Assert.AreEqual(time, SimpleDiscount.GetTime(discount, principal, rate));
            Assert.AreEqual(rate, SimpleDiscount.GetRate(discount, principal, time));


            double amountRational = SimpleDiscount.GetPresentValueRational(principal, rate, time);
            double discountRational = SimpleDiscount.GetDiscountRational(principal, rate, time);

            Assert.AreEqual(principal, SimpleDiscount.GetFutureValueRational(amountRational, rate, time));
            Assert.AreEqual(time, SimpleDiscount.GetTimeRational(principal, amountRational, rate));
            Assert.AreEqual(rate, SimpleDiscount.GetRateRational(principal, amountRational, time));
        }

        [TestMethod]
        [TestCategory("Discount")]
        public void CompoundDiscountTest()
        {
            double presentValue = CompoundDiscount.GetPresentValue(principal, rate, time);
            double discount = CompoundDiscount.GetDiscount(principal, rate, time);

            Assert.AreEqual(principal, CompoundDiscount.GetFutureValue(presentValue, rate, time));
            Assert.AreEqual(time, CompoundDiscount.GetTime(principal, presentValue, rate));
            Assert.AreEqual(rate, CompoundDiscount.GetRate(principal, presentValue, time));


            double presentValueRational = CompoundDiscount.GetPresentValueRational(principal, rate, time);
            double discountRational = CompoundDiscount.GetDiscountRational(principal, rate, time);

            Assert.AreEqual(principal, CompoundDiscount.GetFutureValueRational(presentValueRational, rate, time));
            Assert.AreEqual(time, CompoundDiscount.GetTimeRational(principal, presentValueRational, rate));
            Assert.AreEqual(rate, CompoundDiscount.GetRateRational(principal, presentValueRational, time));
        }
    }
}