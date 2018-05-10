using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc
{
    public static partial class FinancialCalc
    {
        #region Desconto Composto Racional
        public static double GetPresentValueByCompoundDiscountRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        public static double GetFutureValueByCompoundDiscountRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        public static double GetDicountValueByCompoundDiscountRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueByCompoundDiscountRational(futureValue, rate, time);
        }

        public static float GetRateByCompoundDiscountRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(Math.Pow(futureValue / presentValue, 1.0 / time) - 1);
        }

        public static int GetTimeByCompoundDiscountRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log((futureValue / presentValue), (1 + rate)));
        }
        #endregion Desconto Composto Racional

        #region Desconto Composto Comercial
        public static double GetPresentValueByCompoundDiscount(double futureValue, float rate, int time = 1)
        {
            return futureValue * Math.Pow(1 - Convert.ToDouble(rate), time);
        }

        public static double GetFutureValueByCompoundDiscount(double presentValue, float rate, int time = 1)
        {
            return presentValue / Math.Pow(1 - Convert.ToDouble(rate), time);
        }

        public static double GetDicountValueByCompoundDiscount(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueByCompoundDiscount(futureValue, rate, time);
        }

        public static float GetRateByCompoundDiscount(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(-(Math.Pow(presentValue / futureValue, 1.0 / time) - 1));
        }

        public static int GetTimeByCompoundDiscount(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log(presentValue / futureValue, 1 - rate));
        }
        #endregion Desconto Composto Comercial
    }
}
