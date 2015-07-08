using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class ArctanTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Arctan();
            Assert.AreEqual(0.785398163397448, testingFunction.Calculate(1));
            Assert.AreEqual(-1.40564764938027, testingFunction.Calculate(-6));
            Assert.AreEqual(0, testingFunction.Calculate(0));
            Assert.AreEqual(0.463647609000806, testingFunction.Calculate(0.5));
            Assert.AreEqual(-0.785398163397448, testingFunction.Calculate(-1));
        }
    }
}
