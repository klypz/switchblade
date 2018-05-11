using System;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class SystemPrice
    {
        public static double GetMonthlyInstallments(double principal, float rate, int time)
        {
            return principal * ((Math.Pow(1 + rate, time) * rate) / (Math.Pow(1 + rate, time) - 1));
        }

        public static double GetPresentValue(double monthlyInstallment, float rate, int time)
        {
            return monthlyInstallment * ((Math.Pow(1 + rate, time) - 1) / (Math.Pow(1 + rate, time) * rate));
        }

        public static float GetRate(double principal, double installment, int time)
        {
            double vTest = 0;
            float result = 0f;

            while ((installment) > vTest)
            {
                result += 0.0001f;
                vTest = GetMonthlyInstallments(principal, result, time);
            }

            return result;
        }
    }


}
