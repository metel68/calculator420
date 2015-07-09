using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class RootTests
    {
        [TestCase(1, 7, 1, 0.1)]
        [TestCase(-6, 1, -6, 0.1)]
        [TestCase(0, 2, 0, 0.1)]
        [TestCase(81, 4, 3, 0.1)]
        [TestCase(-32, 5, -2, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Root();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
        [TestCase(200, 0)]
        [TestCase(-10, 4)]
        [ExpectedException(typeof(Exception))]
        public void DivisionTestByZero(double firstArgument, double secondArgument)
        {
            var testingFunction = new Root();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
        }
    }
}
