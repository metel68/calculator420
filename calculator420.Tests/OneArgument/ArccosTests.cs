using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class ArccosTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Arccos();
            Assert.AreEqual(0, testingFunction.Calculate(1));
            Assert.AreEqual("NaN", testingFunction.Calculate(-6));
            Assert.AreEqual(1.5707963267949, testingFunction.Calculate(0));
            Assert.AreEqual(1.0471975511966, testingFunction.Calculate(0.5));
            Assert.AreEqual(3.14159265358979, testingFunction.Calculate(-1));
        }
    }
}
