using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class AbsTests
    {
        [TestCase(15, 15, 0.1)]
        [TestCase(-6, 6, 0.1)]
        [TestCase(0, 0, 0.1)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Abs();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}