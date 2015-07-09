using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class AddTests
    {
        [TestCase(1, 7, 8, 0.1)]
        [TestCase(-6, 1, -5, 0.1)]
        [TestCase(0, 2, 2, 0.1)]
        [TestCase(-200, 5, -195, 0.1)]
        [TestCase(10, 0, 10, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Add();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
