using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc.Financial
{
    public static partial class CompoundDiscount
    {
        #region Desconto Composto Racional
        public static double GetPresentValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        public static double GetFutureValueRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        public static double GetDicountValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueRational(futureValue, rate, time);
        }

        public static float GetRateRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(Math.Pow(futureValue / presentValue, 1.0 / time) - 1);
        }

        public static int GetTimeRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log((futureValue / presentValue), (1 + rate)));
        }
        #endregion Desconto Composto Racional

        #region Desconto Composto Comercial
        public static double GetPresentValue(double futureValue, float rate, int time = 1)
        {
            return futureValue * Math.Pow(1 - Convert.ToDouble(rate), time);
        }

        public static double GetFutureValue(double presentValue, float rate, int time = 1)
        {
            return presentValue / Math.Pow(1 - Convert.ToDouble(rate), time);
        }

        public static double GetDicountValue(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValue(futureValue, rate, time);
        }

        public static float GetRate(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(-(Math.Pow(presentValue / futureValue, 1.0 / time) - 1));
        }

        public static int GetTime(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log(presentValue / futureValue, 1 - rate));
        }
        #endregion Desconto Composto Comercial
    }
}
