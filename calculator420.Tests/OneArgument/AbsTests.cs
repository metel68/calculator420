using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]

    public class AbsTests
    {
        [Test]
        public void CalculateTest()
        {
            var testingFunction = new Abs();
            var control = Math.Abs(15);
            var result = testingFunction.Calculate(15);
            Assert.AreEqual(control,result);
        }
    }
}