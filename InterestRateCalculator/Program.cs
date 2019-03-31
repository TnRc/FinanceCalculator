using InterestRateCalculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Financial Calculator");
            Console.WriteLine("Please select a calculator:");
            Console.WriteLine("1. Calculate Interest Rates");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    InterestRate interestRate = new InterestRate();
                    interestRate.Run();
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
