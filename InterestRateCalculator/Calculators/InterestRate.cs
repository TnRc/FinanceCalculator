using InterestRateCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator.Calculators
{
    public class InterestRate : IInterestRate
    {
        public void Run()
        {
            Console.WriteLine("Provide a balance:");
            var input = Console.ReadLine();
            double result = Calculate(double.Parse(input));
            Console.WriteLine($"Your interest total will amount to: {result}");
        }

        public double Calculate(double balance)
        {
            if (balance > 0 && balance < 1000)
                return balance * 0.01;

            if (balance >= 1000 && balance < 5000)
                return balance * 0.015;

            if (balance >= 5000 && balance < 10000)
                return balance * 0.02;

            if (balance >= 10000 && balance < 50000)
                return balance * 0.025;

            if (balance > 50000)
                return balance * 0.03;

            // If no brackets are met then it must be less than or equal to zero
            return 0;
        }
    }
}
