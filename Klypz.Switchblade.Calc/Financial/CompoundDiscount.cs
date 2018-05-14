using System;

namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// Desconto composto
    /// </summary>
    public static partial class CompoundDiscount
    {
        #region Desconto Composto Racional
        /// <summary>
        /// <para>Calcula o [VP] do [Desconto Composto Racional]</para>
        /// <para>[VP] é o valor atualizado com o desconto aplicado</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor sem desconto)</param>
        /// <param name="rate">Taxa em %. Para um juros de 1% defina o rate como 1.0/100.</param>
        /// <param name="time">Número de Repetições. "n"</param>
        /// <returns>Valor Presente</returns>
        public static double GetPresentValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// <para>Calcula [VF] do [Desconto Composto Racional]</para>
        /// <para>[VF] é o valor bruto. Sem a aplicação de desconto</para>
        /// </summary>
        /// <param name="presentValue">Valor Presente</param>
        /// <param name="rate">Valor Futuro (Valor sem desconto)
        /// <param name="time">Número de Repetições. "n"</param>
        /// <returns>Valor Futuro</returns>
        public static double GetFutureValueRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * Math.Pow(1 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// <para>Calcula o [D] (Valor de Desconto)</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor sem desconto)</param>
        /// <param name="rate">Taxa de Juros em %. Para um juros de 1% defina o rate como 1.0/100.</param>
        /// <param name="time">Número de Repetições. "n"</param>
        /// <returns>Valor Presente</returns>
        /// <returns>Valor do Desconto</returns>
        public static double GetDicountValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValueRational(futureValue, rate, time);
        }

        /// <summary>
        /// Calcula a taxa aplicada
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor sem desconto)</param>
        /// <param name="presentValue"></param>
        /// <param name="time"></param>
        /// <returns></returns>
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
