using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class ArcsinTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Arcsin();
            Assert.AreEqual(1.5707963267949, testingFunction.Calculate(1));
            Assert.AreEqual("NaN", testingFunction.Calculate(-6));
            Assert.AreEqual(0, testingFunction.Calculate(0));
            Assert.AreEqual(0.523598775598299, testingFunction.Calculate(0.5));
            Assert.AreEqual(-1.5707963267949, testingFunction.Calculate(-1));
        }
    }
}
