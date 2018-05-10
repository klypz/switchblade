using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc
{
    public static partial class FinancialCalc
    {
        #region Desconto Simples Racional
        public static double GetPresentValueBySimpleDiscountRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / (1 + Convert.ToDouble(rate) * time);
        }

        public static double GetFutureValueBySimpleDiscountRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * (1 + rate * time);
        }

        public static double GetDicountValueBySimpleDiscountRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueBySimpleDiscountRational(futureValue, rate, time);
        }

        public static float GetRateBySimpleDiscountRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(((futureValue / presentValue) - 1) / time);
        }

        public static int GetTimeBySimpleDiscountRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(((futureValue / presentValue) - 1) / rate);
        }
        #endregion Desconto Simples Racional

        #region Desconto Simples Comercial
        public static double GetPresentValueBySimpleDiscount(double futureValue, float rate, int time = 1)
        {
            return futureValue * (1 - (Convert.ToDouble(rate) * time));
        }

        public static double GetFutureValueBySimpleDiscount(double presentValue, float rate, int time = 1)
        {
            return presentValue / (1 - rate * time);
        }

        public static double GetDicountValueBySimpleDiscount(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueBySimpleDiscount(futureValue, rate, time);
        }

        public static float GetRateBySimpleDiscount(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle((1-(presentValue/futureValue))/time);
        }

        public static int GetTimeBySimpleDiscount(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32((1-(presentValue/futureValue))/rate);
        }
        #endregion Desconto Simples Comercial
    }
}
