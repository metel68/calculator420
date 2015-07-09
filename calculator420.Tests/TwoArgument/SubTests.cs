using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class SubTests
    {
        [Test]
        [TestCase(1, 7, -6, 0.1)]
        [TestCase(-6, 1, -7, 0.1)]
        [TestCase(0, 2, -2, 0.1)]
        [TestCase(-200, 5, -205, 0.1)]
        [TestCase(10, 0, 10, 0.1)]
        public void CalculateTest(double firstArgument, double secondArgument, double result, double accracy)
        {
            var testingFunction = new Sub();
            var testResult = testingFunction.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
