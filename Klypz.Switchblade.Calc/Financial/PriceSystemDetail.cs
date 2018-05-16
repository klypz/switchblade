using System;
namespace Klypz.Switchblade.Calc.Financial
{
    public class PriceSystemDetail
    {
        public PriceSystemDetail(int position, double currentBalance, double interest, double amortisation, int precision = 2)
        {
            Position = position;
            CurrentBalance = currentBalance;
            Amortisation = amortisation;
            Interest = interest;
            Precision = precision;
        }

        public int Position { get; internal set; }
        public double CurrentBalance { get; internal set; }
        public double Amortisation { get; internal set; }
        public double Interest { get; internal set; }
        public int Precision { get; internal set; }
        public double Balance { get { return Math.Round(CurrentBalance - Amortisation, Precision); } }
    }
}
