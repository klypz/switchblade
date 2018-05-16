using Klypz.Switchblade.Calc.Financial;

namespace Klypz.Switchblade.Calc
{
    /// <summary>
    /// Fatura utilizada no cálculo de rateio de juros por atraso
    /// </summary>
    /// <typeparam name="T">Tipo de objeto para identificação do registro. (Id, Isn, Guid...)</typeparam>
    public class Invoice<T> where T : struct
    {
        /// <summary>
        /// Identificação do registro
        /// </summary>
        public T Id { get; private set; }

        /// <summary>
        /// Dias que o pagamento está atrasado
        /// </summary>
        public int DaysOfDelay { get; private set; }

        /// <summary>
        /// Valor Principal do documento
        /// </summary>
        public double PrincipalValue { get; private set; }

        /// <summary>
        /// Valor do Juros (disponibilizado após Cálculo)
        /// </summary>
        public double? Interest { get; internal set; }

        /// <summary>
        /// Valor Principal + Valor do Juros
        /// </summary>
        public double Amount
        {
            get
            {
                return PrincipalValue + (Interest ?? 0);
            }
        }
        /// <summary>
        /// Taxa de juros ao dia
        /// </summary>
        public float Rate
        {
            get
            {
                return Interest.HasValue ? SimpleInterest.GetRate(Interest.Value, PrincipalValue, DaysOfDelay) : 0;
            }
        }

        public Invoice(T id, int daysOfDelay, double principalValue)
        {
            Id = id;
            DaysOfDelay = daysOfDelay;
            PrincipalValue = principalValue;
        }
    }
}
