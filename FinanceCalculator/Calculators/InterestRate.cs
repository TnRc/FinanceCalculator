using FinanceCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator.Calculators
{
    public class InterestRate : IInterestRate
    {
        public void Run()
        {
            // Setup parameters required
            Console.WriteLine("Provide a balance:");
            var input = Console.ReadLine();

            double balance = 0;
            double result = 0;
            if (double.TryParse(input, out balance))
            {
                result = Calculate(balance);
                Console.WriteLine($"Your interest total will amount to: {result.ToString()}");
            }
            else
            {
                Console.WriteLine($"You did not enter a valid balance (double expected).");
            }

        }

        public double Calculate(double balance)
        {
            double interest = 0;

            // 0 < balance < 1000 : interest = 1% of balance
            if (balance > 0 && balance < 1000)
                interest = balance * 0.01;

            // 1,000 <= balance < 5,000 : interest = 1.5% of balance
            else if (balance >= 1000 && balance < 5000)
                interest = balance * 0.015;

            // 5,000 <= balance < 10,000 : interest = 2% of balance
            else if (balance >= 5000 && balance < 10000)
                interest = balance * 0.02;

            // 10,000 <= balance < 50,000 : interest = 2.5% of balance
            else if (balance >= 10000 && balance < 50000)
                interest = balance * 0.025;

            // balance >= 50,000 : interest = 3% of balance
            else if (balance >= 50000)
                interest = balance * 0.03;

            // If no brackets are met then it must be less than or equal to zero
            return Math.Round(interest, 2, MidpointRounding.ToEven);
        }
    }
}
