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

        [TestMethod()]
        public void GetAmountByDiscountSimpleRationalTest()
        {

            var a = FinancialCalc.GetAmountByDiscountSimpleRational(100, 10m/100, 2);
            var b = FinancialCalc.GetAmountByDiscountSimple(100, 10m/100, 2);

            Assert.Fail();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ApportionmentOfInterestTest()
        {
            List<PriceComposition<int>> comp = new List<PriceComposition<int>>
            {
                new PriceComposition<int>(1, 4, 300),
                new PriceComposition<int>(1, 3, 100),
                new PriceComposition<int>(1, 2, 200),
                new PriceComposition<int>(1, 1, 400)
            };

            FinancialCalc.ApportionmentOfInterestForDaysOfDelay(comp, 100.0);

            var a = comp.Sum(p => p.Amount);
            

        }
    }
}