using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// Cálculos de juros composto
    /// </summary>
    public static partial class CompoundInterest
    {
        /// <summary>
        /// Obtém o valor do Juros
        /// </summary>
        /// <param name="principal">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Valor do Juros</returns>
        public static double GetInterestValue(double principal, float rate, int time = 1)
        {
            return GetFutureAmount(principal, rate, time) - principal;
        }

        /// <summary>
        /// Obtém o montante Futuro
        /// </summary>
        /// <param name="principal">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Valor Futuro (Montante)</returns>
        public static double GetFutureAmount(double principal, float rate, int time = 1)
        {
            return principal * Math.Pow(1.0 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// Obtém o valor principal a partir do juros
        /// </summary>
        /// <param name="futureAmount">Valor Futuro</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Obtém o valor principal</returns>
        public static double GetPrincipal(double futureAmount, float rate, int time = 1)
        {
            return futureAmount / Math.Pow(1.0 + Convert.ToDouble(rate), time);
        }

        /// <summary>
        /// Obtém Taxa de Juros
        /// </summary>
        /// <param name="futureAmount">Valor Futuro</param>
        /// <param name="principal">Valor Principal</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Taxa de Juros</returns>
        public static float GetRate(double futureAmount, double principal, int time = 1)
        {
            return Convert.ToSingle(Math.Pow(futureAmount / principal, 1.0 / time) - 1);
            //return Convert.ToSingle(Math.Log(futureAmount / principal) / time);
        }

        /// <summary>
        /// Obtém o número de repetições
        /// </summary>
        /// <param name="futureAmount">Valor Futuro</param>
        /// <param name="principal">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <returns>Número de Repetições</returns>
        public static int GetTime(double futureAmount, double principal, float rate)
        {
            return Convert.ToInt32(Math.Log(futureAmount / principal) / rate);
        }

        /// <summary>
        /// Equivalências de taxas por período
        /// </summary>
        /// <param name="input">Taxa Informada</param>
        /// <param name="ratePeriodFrom">Define o tipo de entrada</param>
        /// <param name="ratePeriodTo">Define o tipo de saída</param>
        /// <returns></returns>
        public static float GetEquivalentRate(float input, RatePeriod ratePeriodFrom, RatePeriod ratePeriodTo)
        {
            double pow = Convert.ToDouble((int)ratePeriodTo > (int)ratePeriodFrom ? ((int)ratePeriodTo / (int)ratePeriodFrom) : ((int)ratePeriodFrom / (int)ratePeriodTo));

            if ((int)ratePeriodTo > (int)ratePeriodFrom)
            {
                return Convert.ToSingle(Math.Pow(1.0 + Convert.ToDouble(input), pow) - 1);
            }
            else
            {
                return Convert.ToSingle(Math.Pow(1.0 + Convert.ToDouble(input), 1 / pow) - 1);
            }
        }
    }
}
