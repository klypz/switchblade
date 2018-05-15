using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Calc.Financial
{
    public static class SimpleDiscount
    {
        #region Desconto Simples Racional
        public static double GetPresentValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / (1 + Convert.ToDouble(rate) * time);
        }

        public static double GetFutureValueRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * (1 + rate * time);
        }

        public static double GetDicountValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueRational(futureValue, rate, time);
        }

        public static float GetRateRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(((futureValue / presentValue) - 1) / time);
        }

        public static int GetTimeRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(((futureValue / presentValue) - 1) / rate);
        }
        #endregion Desconto Simples Racional

        #region Desconto Simples Comercial
        public static double GetPresentValue(double futureValue, float rate, int time = 1)
        {
            return futureValue * (1 - (Convert.ToDouble(rate) * time));
        }

        public static double GetFutureValue(double presentValue, float rate, int time = 1)
        {
            return presentValue / (1 - rate * time);
        }

        public static double GetDicountValue(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValue(futureValue, rate, time);
        }

        public static float GetRate(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle((1-(presentValue/futureValue))/time);
        }

        public static int GetTime(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32((1-(presentValue/futureValue))/rate);
        }
        #endregion Desconto Simples Comercial
    }
}
