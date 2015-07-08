using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class MultTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Mult();
            Assert.AreEqual(7, testingFunction.Calculate(1, 7));
            Assert.AreEqual(-6, testingFunction.Calculate(-6, 1));
            Assert.AreEqual(0, testingFunction.Calculate(0, 2));
            Assert.AreEqual(-100, testingFunction.Calculate(-20, 5));
            Assert.AreEqual(30, testingFunction.Calculate(-10, -3));
        }
    }
}
