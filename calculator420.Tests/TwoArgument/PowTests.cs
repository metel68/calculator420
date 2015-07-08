using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class PowTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Pow();
            Assert.AreEqual(1, testingFunction.Calculate(1, 7));
            Assert.AreEqual(-6, testingFunction.Calculate(-6, 1));
            Assert.AreEqual(0, testingFunction.Calculate(0, 2));
            Assert.AreEqual(32, testingFunction.Calculate(2, 5));
            Assert.AreEqual(1, testingFunction.Calculate(10, 0));
        }
    }
}
