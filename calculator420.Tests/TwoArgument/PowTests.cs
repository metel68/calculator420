using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class PowTests
    {
        [TestCase(1, 7, 1, 0.1)]
        [TestCase(-6, 1, -6, 0.1)]
        [TestCase(0, 2, 0, 0.1)]
        [TestCase(-2, 5, -32, 0.1)]
        [TestCase(10, 0, 1, 0.1)]
        [TestCase(-15, 2, 225, 0.1)]
        [TestCase(0, 0, 1, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Pow();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
