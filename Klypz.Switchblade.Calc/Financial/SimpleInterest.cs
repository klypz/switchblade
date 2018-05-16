using System;
using System.Collections.Generic;
using System.Linq;


namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// Cálculos de juros simples
    /// </summary>
    public static class SimpleInterest
    {
        /// <summary>
        /// Obtém o valor do Juros
        /// </summary>
        /// <param name="principalValue">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Valor do Juros</returns>
        public static double GetInterest(double principalValue, float rate, int time = 1)
        {
            return principalValue * Convert.ToDouble(rate) * time;
        }

        /// <summary>
        /// Obtém o montante Futuro
        /// </summary>
        /// <param name="principalValue">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Valor Futuro (Montante)</returns>
        public static double GetAmount(double principalValue, float rate, int time = 1)
        {
            return principalValue * (1 + (rate * time));
        }

        /// <summary>
        /// Obtém o valor principal a partir do juros
        /// </summary>
        /// <param name="amount">Valor Futuro</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Obtém o valor principalValue</returns>
        public static double GetPrincipal(double amount, float rate, int time = 1)
        {
            return amount / (1 + (Convert.ToDouble(rate) * time));
        }

        /// <summary>
        /// Obtém Taxa de Juros
        /// </summary>
        /// <param name="interest">Juros (Valor)</param>
        /// <param name="principalValue">Valor Principal</param>
        /// <param name="time">Número de repetições</param>
        /// <returns>Taxa de Juros</returns>
        public static float GetRate(double interest, double principalValue, int time = 1)
        {
            return Convert.ToSingle(interest / (principalValue * time));
        }

        /// <summary>
        /// Obtém o número de repetições
        /// </summary>
        /// <param name="interest">Juros (Valor)</param>
        /// <param name="principalValue">Valor Principal</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <returns>Número de Repetições</returns>
        public static int GetTime(double interest, double principalValue, float rate)
        {
            return Convert.ToInt32(interest / (principalValue * rate));
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
            Func<float, float> returnTo = delegate (float convertDay)
            {
                return convertDay * (int)(ratePeriodTo);
            };

            return returnTo(input / (int)ratePeriodFrom);
        }

        /// <summary>
        /// Rateio proporcional de juros por dia de atraso
        /// </summary>
        /// <typeparam name="T">Tipo de objeto para identificação do registro. (Id, Isn, Guid...)</typeparam>
        /// <param name="invoices">Faturas em atraso</param>
        /// <param name="interest">Juros a ser rateado entre as faturas em atraso</param>
        public static void ApportionmentOfInterest<T>(IEnumerable<Invoice<T>> invoices, double interest, int precision = 2) where T : struct
        {
            double factorReduce = 0.0001;

            if (invoices == null)
            {
                throw new ArgumentNullException(nameof(invoices));
            }

            IEnumerable<Invoice<T>> lateInvoices = invoices.Where(p => p.DaysOfDelay > 0);

            double totalFactor = lateInvoices.Sum(s => s.DaysOfDelay * s.PrincipalValue * factorReduce); ;

            foreach (var item in lateInvoices)
            {
                double itemFactor = item.DaysOfDelay * item.PrincipalValue * factorReduce;
                item.Interest = (itemFactor / totalFactor) * interest;
            }
        }
    }
}
