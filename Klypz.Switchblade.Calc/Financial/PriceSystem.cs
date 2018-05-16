using System;
using System.Linq;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class PriceSystem
    {
        public static double GetInstallments(double principal, float rate, int time)
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
                result = Convert.ToSingle(Math.Round(result + 0.000001, 6));
                vTest = GetInstallments(principal, result, time);
            }

            return result - 0.000001f;
        }

        public static double GetInterest(double principal, float rate, int time)
        {
            return GetInstallments(principal, rate, time) * time - principal;
        }

        public static double GetAmount(double principal, float rate, int time)
        {
            return GetInstallments(principal, rate, time) * time;
        }

        public static double GetCurrentBalance(double principal, float rate, int time, int timeCurrent)
        {
            double installment = GetInstallments(principal, rate, time);
            double balance = principal;

            Func<double, float, double, double> funcTimeAcc = delegate (double p, float t, double inst)
            {
                return Math.Abs(inst - (p * t));
            };

            for (int i = 0; i < timeCurrent; i++)
            {
                balance -= funcTimeAcc(balance, rate, installment);
            }

            return balance;
        }

        public static double GetAccumulatedAmortisation(double principal, float rate, int time, int timeCurrent)
        {
            return principal - GetCurrentBalance(principal, rate, time, timeCurrent);
        }
    }
}
