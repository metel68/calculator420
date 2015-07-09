using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
        public class ArctanTests
    {
        [TestCase(1, 0.7853, 0.0001)]
        [TestCase(-6, -1.4056, 0.0001)]
        [TestCase(0, 0, 0.1)]
        [TestCase(0.5, 0.4636, 0.0001)]
        [TestCase(-1, -0.7853, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Arctan();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
