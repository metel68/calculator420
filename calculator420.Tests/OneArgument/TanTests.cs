using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class TanTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Tan();
            Assert.AreEqual(1.5574077246549, testingFunction.Calculate(1));
            Assert.AreEqual(0.291006191384749, testingFunction.Calculate(-6));
            Assert.AreEqual(0, testingFunction.Calculate(0));
            Assert.AreEqual(0.74702229723866, testingFunction.Calculate(-2.5));
            Assert.AreEqual(0.648360827459087, testingFunction.Calculate(10));
        }
    }
}
