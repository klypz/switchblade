using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Math
{
    public static class FinancialMath
    {
        public static decimal GetAmountInterest(InterestType type, decimal captialInitial, decimal interestRate, int period)
        {
            if (type == InterestType.SimpleInterest)
            {
                return captialInitial * (1 + (interestRate * period));
            }
            else
            {
                return captialInitial * Convert.ToDecimal(System.Math.Pow(Convert.ToDouble(1m + interestRate), Convert.ToDouble(period));
            }
        }
    }

    public enum InterestType
    {
        SimpleInterest = 'S',
        CompoundInterest = 'C'
    }

    public enum InterestRateType
    {
        PerYear = 'Y',
        PerMonth = 'M',
        PerDay = 'D'
    }
}
