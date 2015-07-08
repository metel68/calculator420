using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]

    public class DivTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Div();
            Assert.AreEqual(0,142857142857143, testingFunction.Calculate(1, 7));
            Assert.AreEqual(-6, testingFunction.Calculate(-6, 1));
            Assert.AreEqual(0, testingFunction.Calculate(0, 2));
            Assert.AreEqual(-40, testingFunction.Calculate(-200, 5));
            Assert.AreEqual("NaN", testingFunction.Calculate(5, 0));
        }
    }
}
