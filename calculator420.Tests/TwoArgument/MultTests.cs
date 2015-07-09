using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class MultTests
    {
        [TestCase(1, 7, 7, 0.1)]
        [TestCase(-6, 1, -6, 0.1)]
        [TestCase(0, 2, 0, 0.1)]
        [TestCase(-20, 5, -100, 0.1)]
        [TestCase(-10, -3, 30, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Mult();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
