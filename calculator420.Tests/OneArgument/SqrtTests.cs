using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class SqrtTests
    {
        [TestCase(9, 3, 0.1)]
        [TestCase(0, 0, 0.1)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Sqrt();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void SqrtTestsNegative()
        {
            var calculator = new Sqrt();
            var result = calculator.Calculate(-3);
        }
    }
}
