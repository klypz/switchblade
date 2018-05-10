using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc
{
    public static partial class FinancialCalc
    {
        public static double GetMonthlyInstallmentsBySystemPrice(double principal, float rate, int time)
        {
            return principal * ((Math.Pow(1 + rate, time) * rate) / (Math.Pow(1 + rate, time) - 1));
        }
    }
}
