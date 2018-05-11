using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class CompoundInterest
    {
        public static double GetInterestValue(double principal, float rate, int time = 1)
        {
            return GetFutureAmount(principal, rate, time) - principal;
        }

        public static double GetFutureAmount(double principal, float rate, int time = 1)
        {
            return principal * Math.Pow(1.0 + Convert.ToDouble(rate), time);
        }

        public static double GetPrincipal(double futureAmount, float rate, int time = 1)
        {
            return futureAmount / Math.Pow(1.0 + Convert.ToDouble(rate), time);
        }

        public static float GetRate(double futureAmount, double principal, int time = 1)
        {
            return Convert.ToSingle(Math.Pow(futureAmount / principal, 1.0 / time) - 1);
            //return Convert.ToSingle(Math.Log(futureAmount / principal) / time);
        }

        public static int GetTime(double futureAmount, double principal, float rate)
        {
            return Convert.ToInt32(Math.Log(futureAmount / principal) / rate);
        }

        public static float GetEquivalentRate(float input, RatePeriod ratePeriodFrom, RatePeriod ratePeriodTo)
        {
            double pow = Convert.ToDouble((int)ratePeriodTo > (int)ratePeriodFrom ? ((int)ratePeriodTo / (int)ratePeriodFrom) : ((int)ratePeriodFrom / (int)ratePeriodTo));

            if ((int)ratePeriodTo > (int)ratePeriodFrom)
            {
                return Convert.ToSingle(Math.Pow(1.0 + Convert.ToDouble(input), pow) - 1);
            }
            else
            {
                return Convert.ToSingle(Math.Pow(1.0 + Convert.ToDouble(input), 1 / pow) - 1);
            }
        }
    }
}
