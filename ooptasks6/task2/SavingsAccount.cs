using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class SavingsAccount : Account
    {
        public double InterestRateInPrecentage { get; set; }
        public double CalcInterests() { return (InterestRateInPrecentage / 100) * Balance * 2; }
        public SavingsAccount(double _rate, double _balance) : base(_balance) {

            InterestRateInPrecentage = _rate;
        }
        public override double GetBalance()
        {
            return Balance+CalcInterests();
        }

    }
}
