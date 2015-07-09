using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Tests.TwoArgument
{
    [TestFixture]
    /// <summary>
    /// Creates and returns an object of selected one-operation calculator
    /// </summary>
    /// <param name="operation">Name of required operation</param>
    /// <returns>Calculator object</returns>
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