using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]
    public class TwoArgumentTests
    {
        [TestCase(typeof(Add), "Add")]
        [TestCase(typeof(Div), "Div")]
        [TestCase(typeof(Sub), "Sub")]
        [TestCase(typeof(Mult), "Mult")]
        [TestCase(typeof(Pow), "Pow")]
        [TestCase(typeof(Root), "Root")]
        public void FactoryTest(Type type, string name)
        {
            Type resultType = TwoArgmumentFactory.CreateCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
        public void UndefTest()
        {
            Type resultType = TwoArgmumentFactory.CreateCalculator("Ass").GetType();
        }
    }
}