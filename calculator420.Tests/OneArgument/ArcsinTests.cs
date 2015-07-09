using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
        public class ArcsinTests
    {
        [TestCase(1, 1.5707, 0.0001)]
        [TestCase(0, 0, 0.1)]
        [TestCase(0.5, 0.5235, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Arcsin();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void ArcTestsNegative()
        {
            var calculator = new Arcsin();
            var result = calculator.Calculate(-6);
        }
    }
}
