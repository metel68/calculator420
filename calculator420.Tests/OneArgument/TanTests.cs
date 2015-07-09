using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
            public class TanTests
    {
        [TestCase(1, 1.5574, 0.0001)]
        [TestCase(-6, 0.2910, 0.0001)]
        [TestCase(0, 0, 0.1)]
        [TestCase(-2.5, 0.7470, 0.0001)]
        [TestCase(10, 0.6483, 0.0001)]
        public void CalculateTest(double argument, double result, double accracy)
        {
            var testingFunction = new Tan();
            var testResult = testingFunction.Calculate(argument);
            Assert.AreEqual(result, testResult, accracy);
        }
    }
}
