using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class AddTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Add();
            Assert.AreEqual(8, testingFunction.Calculate(1, 7));
            Assert.AreEqual(-5, testingFunction.Calculate(-6, 1));
            Assert.AreEqual(2, testingFunction.Calculate(0, 2));
            Assert.AreEqual(-195, testingFunction.Calculate(-200, 5));
            Assert.AreEqual(11, testingFunction.Calculate(10, 1));
        }
    }
}
