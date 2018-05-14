namespace Klypz.Switchblade.Calc.Financial
{
    internal class PriceSystemDetail
    {
        public PriceSystemDetail(int position, double currentBalance, double interest, double amortisation)
        {
            Position = position;
            CurrentBalance = currentBalance;
            Amortisation = amortisation;
            Interest = interest;
        }

        public int Position { get; set; }
        public double CurrentBalance { get; set; }
        public double Amortisation { get; set; }
        public double Interest { get; set; }
        public double Balance { get { return CurrentBalance - Amortisation; } }


    }
}
