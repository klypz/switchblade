using System;
using System.Collections;
using System.Collections.Generic;
namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// <para>Tabela Price</para>
    /// <para>Os valores residuais serão abatidas no juros da ultima parcela</para>
    /// </summary>
    public class PriceSystemTable : IEnumerable<PriceSystemDetail>, IEnumerator<PriceSystemDetail>
    {
        /// <summary>
        /// Valor Principal (Valor Financiado)
        /// </summary>
        public double Principal { get; private set; }
        /// <summary>
        /// Taxa de Juros
        /// </summary>
        public float Rate { get; private set; }
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int Time { get; private set; }
        /// <summary>
        /// Número de casas decimais
        /// </summary>
        public int Precision { get; private set; }
        /// <summary>
        /// Valor da Parcela
        /// </summary>
        public double Installment { get; private set; }

        private int index = -1;

        private PriceSystemDetail[] result = null;

        public PriceSystemDetail Current => result[index];

        object IEnumerator.Current => result[index];

        /// <param name="principal">Valor Principal (Valor Financiado)</param>
        /// <param name="rate">Taxa de Juros</param>
        /// <param name="time">Quantidade de parcelas</param>
        /// <param name="precision">Número de casa decimais</param>
        public PriceSystemTable(double principal, float rate, int time, int precision = 2)
        {
            Principal = principal;
            Rate = rate;
            Time = time;
            Precision = precision;
            Installment = Math.Round(PriceSystem.GetInstallments(principal, rate, time), precision);

            result = new PriceSystemDetail[Time];
            Reset();
        }

        public IEnumerator<PriceSystemDetail> GetEnumerator()
        {
            if (result[Time - 1] == null)
            {
                for (int i = 0; i < Time; i++)
                {
                    double crrBal = i == 0 ? Principal : result[i - 1].Balance;
                    double interest = Math.Round(crrBal * Rate, Precision);

                    result[i] = new PriceSystemDetail(i + 1, crrBal, interest, Math.Round(Math.Abs(Installment - interest), Precision));

                    if (i == Time - 1 && result[i].Balance != 0)
                    {
                        interest -= result[i].Balance;
                        result[i].Interest = interest;
                        result[i].Amortisation = Math.Round(Math.Abs(Installment - interest), Precision);
                    }
                }
            }

            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (index == Time)
                return false;
            else
                index++;

            return index < Time;

        }

        public void Reset()
        {
            index = -1;
        }
    }
}
