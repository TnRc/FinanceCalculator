using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator.Interfaces
{
    public interface IInterestRate
    {
        void Run();
        double Calculate(double balance);
    }
}
