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
    }
}