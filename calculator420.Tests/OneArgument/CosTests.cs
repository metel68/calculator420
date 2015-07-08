using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class CosTests
    {
        [TestCase(1, 0.5403, 0.0001)]
        [TestCase(-6, 0.9602, 0.0001)]
        [TestCase(0, 1, 0.0001)]
        [TestCase(-2.5, -0.8011, 0.0001)]
        [TestCase(10, -0.8390, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Cos();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}