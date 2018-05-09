﻿using System;

namespace Klypz.Switchblade.Calc
{
    /// <summary>
    /// Fórmulas para cálculos financeiro
    /// </summary>
    public static class FinancialCalc
    {
        /// <summary>
        /// <para>Obtém o montante através da aplicação de juros simples</para>
        /// <para>M = P*[1+(i*n)]</para>
        /// </summary>
        /// <param name="principal">Valor principal</param>
        /// <param name="rate">Taxa de juros</param>
        /// <param name="time">Número de períodos</param>
        /// <returns>Montante através de Juros Simples</returns>
        public static double GetAmountBySimpleInterest(double principal, decimal rate, int time = 1)
        {
            return principal * (1 + (Convert.ToDouble(rate) * time));
        }

        /// <summary>
        /// <para>Obtém o valor principal através do montante</para>
        /// <para>P = M/[1+(i*n)]</para>
        /// </summary>
        /// <param name="amount">Montante</param>
        /// <param name="rate">Taxa de juros</param>
        /// <param name="time">Número de períodos</param>
        /// <returns>Valor principal</returns>
        public static double GetPrincipalBySimpleInterest(double amount, decimal rate, int time = 1)
        {
            return amount / (1 + (Convert.ToDouble(rate) * time));
        }

        /// <summary>
        /// <para>Obtém o Valor do juros através do Juros Simples</para>
        /// <para>J = P * i * n</para>
        /// </summary>
        /// <param name="principal">Valor Principal</param>
        /// <param name="rate">Taxa de juros</param>
        /// <param name="time">Número de períodos</param>
        /// <returns>Valor do Juros</returns>
        public static double GetInterestAmountBySimpleInterest(double principal, decimal rate, int time = 1)
        {
            return principal * Convert.ToDouble(rate) * time;
        }

        /// <summary>
        /// <para>Obtém a taxa de juros através do valor do juros e principal</para>
        /// <para>J/(P*n)</para>
        /// </summary>
        /// <param name="interestAmount">Valor do juros</param>
        /// <param name="principal">Valor Principal</param>
        /// <param name="time">Número de períodos</param>
        /// <returns></returns>
        public static decimal GetInterestRateBySimpleInterest(double interestAmount, double principal, int time = 1)
        {
            return Convert.ToDecimal(interestAmount / (principal * time));
        }

        /// <summary>
        /// <para>Converte o período da taxa de juros</para>
        /// <para>10% a.m. = 120% a.a. = 0,333% a.d.</para>
        /// </summary>
        /// <param name="input">Taxa de juros</param>
        /// <param name="ratePeriodFrom">Período de entrada (input)</param>
        /// <param name="ratePeriodTo">Período de saída</param>
        /// <returns>Taxa de juros convertida para o período de saída</returns>
        public static decimal GetEquivalentRateSimple(decimal input, RatePeriod ratePeriodFrom, RatePeriod ratePeriodTo)
        {
            Func<decimal, decimal> returnTo = delegate (decimal convertDay)
            {
                return convertDay * (int)(ratePeriodTo);
            };

            return returnTo(input / (int)ratePeriodFrom);
        }

        /// <summary>
        /// <para>Obtém o valor a ser pago aplicando o desconto (método racional)</para>
        /// <para>VP = VF/[1+(i*n)]</para>
        /// </summary>
        /// <param name="listPrice">Preço Final</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de período</param>
        /// <returns>Valor Presente, valor com desconto aplicado</returns>
        public static double GetAmountByDiscountSimpleRational(double listPrice, decimal rate, int time = 1)
        {
            return listPrice / (1 + (Convert.ToDouble(rate) * time));
        }

        /// <summary>
        /// <para>Obtém o valor a ser pago aplicando o desconto (método simples ou comercial)</para>
        /// <para>VP = VF * [1-(i*n)]</para>
        /// </summary>
        /// <param name="listPrice">Preço Final</param>
        /// <param name="rate">Taxa de desconto</param>
        /// <param name="time">Número de período</param>
        /// <returns>Valor Presente, valor com desconto aplicado</returns>
        public static double GetAmountByDiscountSimple(double listPrice, decimal rate, int time = 1)
        {
            return listPrice * (1 - (Convert.ToDouble(rate) * time));
        }
    }
}
