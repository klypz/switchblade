using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class SystemPrice
    {
        public static double GetInstallments(double principal, float rate, int time, int precision = 2)
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

        public static double GetInterest(double principal, float rate, int time, int precision = 2)
        {
            return GetInstallments(principal, rate, time, 2) * time - principal;
        }

        public static double GetAmount(double principal, float rate, int time, int precision = 2)
        {
            return Math.Round(GetInstallments(principal, rate, time)) * time;
        }

        public static double GetCurrentBalance(double principal, float rate, int time, int timeCurrent, int precision = 2)
        {
            double installment = GetInstallments(principal, rate, time, precision);
            double balance = principal;

            Func<double, float, double, double> funcTimeAcc = delegate (double p, float t, double inst)
            {
                return Math.Abs(inst - (p * t));
            };

            for (int i = 0; i < timeCurrent; i++)
            {
                balance -= funcTimeAcc(balance, rate, installment);
            }

            return Math.Round(balance, precision);
        }

        public static double GetAccumulatedAmortisation(double principal, float rate, int time, int timeCurrent, int precision = 2)
        {
            return principal - GetCurrentBalance(principal, rate, time, timeCurrent, precision);
        }
    }

    public class SystemPriceDetail
    {
        public SystemPriceDetail(int position, double currentBalance, double interest, double amortisation)
        {
            Position = position;
            CurrentBalance = currentBalance;
            Amortisation = amortisation;
            Interest = interest;
        }

        public int Position { get; set; }
        public double CurrentBalance { get; set; }
        public double Amortisation { get; set; }
        public double Interest { get; set; }
        public double Balance { get { return CurrentBalance - Amortisation; } }


    }

    public class SystemPriceTable : IEnumerable<SystemPriceDetail>, IEnumerator<SystemPriceDetail>
    {
        public double Principal { get; set; }
        public float Rate { get; set; }
        public int Time { get; set; }
        public int Precision { get; set; }
        public double Installment { get; set; }

        private int index = 0;

        private SystemPriceDetail[] result = null;

        public SystemPriceDetail Current => result[index];

        object IEnumerator.Current => result[index];

        public SystemPriceTable(double principal, float rate, int time, int precision = 2)
        {
            Principal = principal;
            Rate = rate;
            Time = time;
            Precision = precision;
            Installment = SystemPrice.GetInstallments(principal, rate, time, precision);

            index = 0;
            result = new SystemPriceDetail[Time];
        }

        public IEnumerator<SystemPriceDetail> GetEnumerator()
        {
            if (result[Time - 1] == null)
            {
                for (int i = 0; i < Time; i++)
                {
                    double crrBal = i == 0 ? Principal : result[i - 1].Balance;
                    result[i] = new SystemPriceDetail(i + 1, crrBal, crrBal * Rate, Math.Abs(Installment - Installment * Rate));
                }
            }

            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (index == Time - 1)
                return false;
            else
                index++;

            return index == Time - 1;

        }

        public void Reset()
        {
            index = 0;
        }
    }
}
