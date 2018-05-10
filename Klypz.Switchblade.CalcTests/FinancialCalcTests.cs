using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc.Tests
{
    [TestClass()]
    public class FinancialCalcTests
    {
        [TestMethod()]
        public void GetEquivalentRateTest()
        {
            var t = FinancialCalc.GetEquivalentRateSimple(1m / 100, RatePeriod.PerMonth, RatePeriod.PerDay);
            var a = FinancialCalc.GetEquivalentRateSimple(t, RatePeriod.PerDay, RatePeriod.PerYear);
            var m = FinancialCalc.GetEquivalentRateSimple(t, RatePeriod.PerDay, RatePeriod.PerMonth);
            Assert.Fail();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ApportionmentOfInterestTest()
        {
            List<Invoice<int>> comp = new List<Invoice<int>>
            {
                new Invoice<int>(1, 4, 300),
                new Invoice<int>(1, 3, 100),
                new Invoice<int>(1, 2, 200),
                new Invoice<int>(1, 1, 400)
            };

            FinancialCalc.ApportionmentOfInterestForDaysOfDelay(comp, 100.0);

            var a = comp.Sum(p => p.Amount);


        }

        [TestMethod()]
        public void SimpleDiscountRationalTest()
        {
            double fv = 1223.88;
            double pv = 0;
            float rate = 12f / 100f;
            int time = 21;

            pv = FinancialCalc.GetPresentValueBySimpleDiscountRational(fv, rate, time);

            Assert.AreEqual(Math.Round(fv, 2), Math.Round(FinancialCalc.GetFutureValueBySimpleDiscountRational(pv, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 2), Math.Round(FinancialCalc.GetRateBySimpleDiscountRational(fv, pv, time), 2));
            Assert.AreEqual(time, FinancialCalc.GetTimeBySimpleDiscountRational(fv, pv, rate));
            Assert.AreEqual(fv - pv, FinancialCalc.GetDicountValueBySimpleDiscountRational(fv, rate, time));

        }

        [TestMethod()]
        public void SimpleDiscountTest()
        {
            double fv = 1223.88;
            double pv = 0;
            float rate = 12f / 100f;
            int time = 4;

            pv = FinancialCalc.GetPresentValueBySimpleDiscount(fv, rate, time);

            Assert.AreEqual(Math.Round(fv, 2), Math.Round(FinancialCalc.GetFutureValueBySimpleDiscount(pv, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 2), Math.Round(FinancialCalc.GetRateBySimpleDiscount(fv, pv, time), 2));
            Assert.AreEqual(time, FinancialCalc.GetTimeBySimpleDiscount(fv, pv, rate));
            Assert.AreEqual(fv - pv, FinancialCalc.GetDicountValueBySimpleDiscount(fv, rate, time));

        }

        [TestMethod()]
        public void CompoundInterestTest()
        {
            double p = 35000;
            double fa = 0;
            float rate = 1.36f / 100f;
            int time = 48;

            fa = FinancialCalc.GetFutureAmountByCompoundInterest(p, rate, time);

            Assert.AreEqual(Math.Round(p, 2), Math.Round(FinancialCalc.GetPrincipalByCompoundInterest(fa, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 2), Math.Round(FinancialCalc.GetRateByCompoundInterest(fa, p, time), 2));
            Assert.AreEqual(time, FinancialCalc.GetTimeByCompoundInterest(fa, p, rate));
            Assert.AreEqual(Math.Round(fa - p, 2), Math.Round(FinancialCalc.GetInterestValueByCompoundInterest(p, rate, time), 2));

        }

        [TestMethod()]
        public void CompoundDiscountRationalTest()
        {
            double fv = 1223.88;
            double pv = 0;
            float rate = 12f / 100f;
            int time = 21;

            pv = FinancialCalc.GetPresentValueByCompoundDiscountRational(fv, rate, time);

            Assert.AreEqual(Math.Round(fv, 2), Math.Round(FinancialCalc.GetFutureValueByCompoundDiscountRational(pv, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 2), Math.Round(FinancialCalc.GetRateByCompoundDiscountRational(fv, pv, time), 2));
            Assert.AreEqual(time, FinancialCalc.GetTimeByCompoundDiscountRational(fv, pv, rate));
            Assert.AreEqual(fv - pv, FinancialCalc.GetDicountValueByCompoundDiscountRational(fv, rate, time));

        }

        [TestMethod()]
        public void CompoundDiscountTest()
        {
            double fv = 1223.88;
            double pv = 0;
            float rate = 12f / 100f;
            int time = 21;

            pv = FinancialCalc.GetPresentValueByCompoundDiscount(fv, rate, time);

            Assert.AreEqual(Math.Round(fv, 2), Math.Round(FinancialCalc.GetFutureValueByCompoundDiscount(pv, rate, time), 2));
            Assert.AreEqual(Math.Round(rate, 2), Math.Round(FinancialCalc.GetRateByCompoundDiscount(fv, pv, time), 2));
            Assert.AreEqual(time, FinancialCalc.GetTimeByCompoundDiscount(fv, pv, rate));
            Assert.AreEqual(fv - pv, FinancialCalc.GetDicountValueByCompoundDiscount(fv, rate, time));

        }

        [TestMethod()]
        public void GetEquivalentRateCompoundTest()
        {
            var t = FinancialCalc.GetEquivalentRateCompound(1f / 100, RatePeriod.PerMonth, RatePeriod.PerYear);
            var a = FinancialCalc.GetEquivalentRateCompound(t, RatePeriod.PerYear, RatePeriod.PerMonth);
            var m = FinancialCalc.GetEquivalentRateCompound(t, RatePeriod.PerYear, RatePeriod.PerHalfMonth);
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMonthlyInstallmentsBySystemPriceTest()
        {
            var parcelas = FinancialCalc.GetMonthlyInstallmentsBySystemPrice(35000, 1.986f/100, 48);
        }
    }
}