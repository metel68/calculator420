using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    
        public class ArccosTests
    {
        [TestCase(1, 0, 0.1)]
        [TestCase(0, 1.5707, 0.0001)]
        [TestCase(0.5, 1.0471, 0.0001)]
        [TestCase(-1, 3.1415, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Arccos();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void ArcTestsNegative()
        {
            var calculator = new Arccos();
            var result = calculator.Calculate(-6);
        }
    }
}
