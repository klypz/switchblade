using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Calc.Financial
{
    private static class SAC
    {
        public static double GetAmortization(double debt, int time)
        {
            return debt / time;
        }

        public static double GetInstallmentsX(double amortization, double interest)
        {
            return amortization + interest;
        }

        public static double GetInterest(double amortization, float rate, int index, int time)
        {
            return (time - index + 1) * rate * amortization;
        }
    }
}
