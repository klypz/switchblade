using System;
using System.Collections;
using System.Collections.Generic;
namespace Klypz.Switchblade.Calc.Financial
{
    public class PriceSystemTable : IEnumerable<PriceSystemDetail>, IEnumerator<PriceSystemDetail>
    {
        public double Principal { get; set; }
        public float Rate { get; set; }
        public int Time { get; set; }
        public int Precision { get; set; }
        public double Installment { get; set; }

        private int index = -1;

        private PriceSystemDetail[] result = null;

        public PriceSystemDetail Current => result[index];

        object IEnumerator.Current => result[index];

        public PriceSystemTable(double principal, float rate, int time, int precision = 2)
        {
            Principal = principal;
            Rate = rate;
            Time = time;
            Precision = precision;
            Installment = PriceSystem.GetInstallments(principal, rate, time, precision);

            result = new PriceSystemDetail[Time];
            Reset();
        }

        public IEnumerator<PriceSystemDetail> GetEnumerator()
        {
            if (result[Time - 1] == null)
            {
                for (int i = 0; i < Time; i++)
                {
                    double crrBal = i == 0 ? Principal : result[i - 1].Balance;
                    double interest = Math.Round(crrBal * Rate, 2);

                    result[i] = new PriceSystemDetail(i + 1, crrBal, interest, Math.Round(Math.Abs(Installment - interest), 2, MidpointRounding.AwayFromZero));
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
            if (index == Time)
                return false;
            else
                index++;

            return index < Time;

        }

        public void Reset()
        {
            index = -1;
        }
    }
}
