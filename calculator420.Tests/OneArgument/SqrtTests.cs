using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class SqrtTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Sqrt();
            Assert.AreEqual(3, testingFunction.Calculate(9));
            Assert.AreEqual("NaN", testingFunction.Calculate(-9));
            Assert.AreEqual(0, testingFunction.Calculate(0));
        }
    }
}
