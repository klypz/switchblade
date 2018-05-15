using System;

namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// <para>Desconto Composto</para>
    /// </summary>
    public static partial class CompoundDiscount
    {
        #region Desconto Composto Racional
        /// <summary>
        /// <para>Desconto Composto Racional</para>
        /// <para>Obtém o Valor Presente (Valor Atual)</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Presente [Desconto Composto Racional]</returns>
        public static double GetPresentValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// <para>Desconto Composto Racional</para>
        /// <para>Obtém o Valor Futuro (Valor Nominal) (Valor sem desconto)</para>
        /// </summary>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Futuro [Desconto Composto Racional]</returns>
        public static double GetFutureValueRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// <para>Desconto Composto Racional</para>
        /// <para>Obtém o Valor do Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor do Desconto [Desconto Composto Racional]</returns>
        public static double GetDicountValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueRational(futureValue, rate, time);
        }

        /// <summary>
        /// <para>Desconto Composto Racional</para>
        /// <para>Obtém a Taxa de Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Taxa de Desconto [Desconto Composto Racional]</returns>
        public static float GetRateRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(Math.Pow(futureValue / presentValue, 1.0 / time) - 1);
        }

        /// <summary>
        /// <para>Desconto Composto Racional</para>
        /// <para>Obtém o Número de Períodos, "n"</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <returns>Número de períodos do desconto [Desconto Composto Racional]</returns>
        public static int GetTimeRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log((futureValue / presentValue), (1 + rate)));
        }
        #endregion Desconto Composto Racional

        #region Desconto Composto Comercial
        /// <summary>
        /// <para>Desconto Composto</para>
        /// <para>Obtém o Valor Presente (Valor Atual)</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Presente [Desconto Composto]</returns>
        public static double GetPresentValue(double futureValue, float rate, int time = 1)
        {
            return futureValue * Math.Pow(1 - Convert.ToDouble(rate), time);
        }
        /// <summary>
        /// <para>Desconto Composto</para>
        /// <para>Obtém o Valor Futuro (Valor Nominal) (Valor sem desconto)</para>
        /// </summary>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Futuro [Desconto Composto]</returns>
        public static double GetFutureValue(double presentValue, float rate, int time = 1)
        {
            return presentValue / Math.Pow(1 - Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// <para>Desconto Composto</para>
        /// <para>Obtém o Valor do Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor do Desconto [Desconto Composto]</returns>
        public static double GetDicountValue(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValue(futureValue, rate, time);
        }

        /// <summary>
        /// <para>Desconto Composto</para>
        /// <para>Obtém a Taxa de Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Taxa de Desconto [Desconto Composto]</returns>
        public static float GetRate(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(-(Math.Pow(presentValue / futureValue, 1.0 / time) - 1));
        }

        /// <summary>
        /// <para>Desconto Composto</para>
        /// <para>Obtém o Número de Períodos, "n"</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <returns>Número de períodos do desconto [Desconto Composto]</returns>
        public static int GetTime(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(Math.Log(presentValue / futureValue, 1 - rate));
        }
        #endregion Desconto Composto Comercial
    }
}
