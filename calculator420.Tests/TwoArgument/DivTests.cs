using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class DivTests
    {
        [TestCase(1, 7, 0.14285, 0.00001)]
        [TestCase(-6, 1, -6, 0.1)]
        [TestCase(0, 2, 0, 0.1)]
        [TestCase(-200, 5, -40, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Div();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
        [Test]
        [ExpectedException(typeof (Exception))]
        public void DivisionTestByZero()
        {
            var calculator = new Div();
            var result = calculator.Calculate(5, 0);
        }
    }
}
