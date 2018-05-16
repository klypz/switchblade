using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// Desconto Simples
    /// </summary>
    public static class SimpleDiscount
    {
        #region Desconto Simples Racional
        /// <summary>
        /// <para>Desconto Simples Racional</para>
        /// <para>Obtém o Valor Presente (Valor Atual)</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Presente [Desconto Simples Racional]</returns>
        public static double GetPresentValueRational(double futureValue, float rate, int time = 1)
        {
            return futureValue / (1 + Convert.ToDouble(rate) * time);
        }

        /// <summary>
        /// <para>Desconto Simples Racional</para>
        /// <para>Obtém o Valor Futuro (Valor Nominal) (Valor sem desconto)</para>
        /// </summary>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Futuro [Desconto Simples Racional]</returns>
        public static double GetFutureValueRational(double presentValue, float rate, int time = 1)
        {
            return presentValue * (1 + rate * time);
        }

        /// <summary>
        /// <para>Desconto Simples Racional</para>
        /// <para>Obtém o Valor do Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor do Desconto [Desconto Simples Racional]</returns>
        public static double GetDiscountRational(double futureValue, float rate, int time = 1)
        {
            return (futureValue * rate * time) / (1 + rate * time);
        }

        /// <summary>
        /// <para>Desconto Simples Racional</para>
        /// <para>Obtém a Taxa de Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Taxa de Desconto [Desconto Simples Racional]</returns>
        public static float GetRateRational(double futureValue, double presentValue, int time = 1)
        {
            return Convert.ToSingle(((futureValue / presentValue) - 1) / time);
        }

        /// <summary>
        /// <para>Desconto Simples Racional</para>
        /// <para>Obtém o Número de Períodos, "n"</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <returns>Número de períodos do desconto [Desconto Simples Racional]</returns>
        public static int GetTimeRational(double futureValue, double presentValue, float rate)
        {
            return Convert.ToInt32(((futureValue / presentValue) - 1) / rate);
        }
        #endregion Desconto Simples Racional

        #region Desconto Simples Comercial
        /// <summary>
        /// <para>Desconto Simples</para>
        /// <para>Obtém o Valor Presente (Valor Atual)</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Presente [Desconto Simples]</returns>
        public static double GetPresentValue(double futureValue, float rate, int time = 1)
        {
            return futureValue * (1 - (Convert.ToDouble(rate) * time));
        }

        /// <summary>
        /// <para>Desconto Simples</para>
        /// <para>Obtém o Valor Futuro (Valor Nominal) (Valor sem desconto)</para>
        /// </summary>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor Futuro [Desconto Simples]</returns>
        public static double GetFutureValue(double presentValue, float rate, int time = 1)
        {
            return presentValue / (1 - rate * time);
        }

        /// <summary>
        /// <para>Desconto Simples</para>
        /// <para>Obtém o Valor do Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Valor do Desconto [Desconto Simples]</returns>
        public static double GetDiscount(double futureValue, float rate, int time = 1)
        {
            return futureValue - GetPresentValue(futureValue, rate, time);
        }

        /// <summary>
        /// <para>Desconto Simples</para>
        /// <para>Obtém a Taxa de Desconto</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="time">Número de períodos do desconto. "n"</param>
        /// <returns>Taxa de Desconto [Desconto Simples]</returns>
        public static float GetRate(double discount, double futureValue, int time = 1)
        {
            return Convert.ToSingle(discount / (futureValue * time));
        }

        /// <summary>
        /// <para>Desconto Simples</para>
        /// <para>Obtém o Número de Períodos, "n"</para>
        /// </summary>
        /// <param name="futureValue">Valor Futuro (Valor Nominal) (Valor sem desconto)</param>
        /// <param name="presentValue">Valor Presente (Valor com Desconto)</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <returns>Número de períodos do desconto [Desconto Simples]</returns>
        public static int GetTime(double discount, double futureValue, float rate)
        {
            return Convert.ToInt32(discount / (futureValue * rate));
        }
        #endregion Desconto Simples Comercial
    }
}
