using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class SinTests
    {
        [TestCase(1, 0.8414, 0.0001)]
        [TestCase(-6, 0.2794, 0.0001)]
        [TestCase(0, 0, 0.0001)]
        [TestCase(-2.5, -0.5984, 0.0001)]
        [TestCase(10, -0.5440, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Sin();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}