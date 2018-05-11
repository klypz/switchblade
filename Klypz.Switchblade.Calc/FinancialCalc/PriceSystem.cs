using System;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class SystemPrice
    {
        public static double GetMonthlyInstallments(double principal, float rate, int time)
        {
            //principal = monthlyInstallment * (Math.Pow(1 - rate, -time) / rate);
            //1/principal = 1/(monthlyInstallment * (Math.Pow(1 - rate, -time) / rate));
            //monthlyInstallment = principal/(Math.Pow(1 - rate, -time) / rate))
            return principal / (Math.Pow(1 - rate, -time) / rate);
        }

        public static double GetPresentValue(double monthlyInstallment, float rate, int time)
        {
            return monthlyInstallment * (Math.Pow(1 - rate, -time) / rate);
        }

        //public static double GetTime(double monthlyInstallment, double principal, float rate)
        //{
        //    return
        //}
    }
}
