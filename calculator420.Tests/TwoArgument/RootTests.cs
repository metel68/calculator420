using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class RootTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Root();
            Assert.AreEqual(1, testingFunction.Calculate(1, 7));
            Assert.AreEqual(-6, testingFunction.Calculate(-6, 1));
            Assert.AreEqual(0, testingFunction.Calculate(0, 2));
            Assert.AreEqual("бесконечность", testingFunction.Calculate(-200, 0));
            Assert.AreEqual("NaN", testingFunction.Calculate(-10, 2));
        }
    }
}
