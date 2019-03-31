using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinanceCalculator.Tests2
{
    [TestFixture]
    public class InterestRateTests
    {
        private static InterestRate calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new InterestRate();
        }

        [TestCase(-100, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        [TestCase(1, 0.01)]
        [TestCase(999, 9.99)]
        [TestCase(1000, 15)]
        [TestCase(4999, 74.98)]
        [TestCase(5000, 100)]
        [TestCase(9999, 199.98)]
        [TestCase(10000, 250)]
        [TestCase(49999, 1249.98)]
        [TestCase(50000, 1500)]
        [TestCase(100000, 3000)]
        public void Balance_Returns_Correct_Interest(double inputBalance, double expectedInterest)
        {
            double result = calculator.Calculate(inputBalance);
            Assert.That(result, Is.EqualTo(expectedInterest));
        }
    }
}
