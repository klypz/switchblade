namespace Klypz.Switchblade.Calc
{
    public class PriceComposition<T> where T : struct
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
        public double PrincipalAmount { get; private set; }
        /// <summary>
        /// Valor do Juros (disponibilizado após Cálculo)
        /// </summary>
        public double? InterestAmount { get; internal set; }
        /// <summary>
        /// Valor Principal + Valor do Juros
        /// </summary>
        public double Amount
        {
            get
            {
                return PrincipalAmount + (InterestAmount ?? 0);
            }
        }
        /// <summary>
        /// Taxa de juros ao dia
        /// </summary>
        public decimal InterestRate
        {
            get
            {
                return InterestAmount.HasValue ? FinancialCalc.GetInterestRateBySimpleInterest(InterestAmount.Value, PrincipalAmount, DaysOfDelay) : 0;
            }
        }

        public PriceComposition(T id, int daysOfDelay, double principalAmount)
        {
            Id = id;
            DaysOfDelay = daysOfDelay;
            PrincipalAmount = principalAmount;
        }
    }
}
