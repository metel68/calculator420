using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class OneArgumentTests
    {
        [TestCase(typeof(Abs), "Abs")]
        [TestCase(typeof(Sin), "Sin")]
        [TestCase(typeof(Cos), "Cos")]
        [TestCase(typeof(Tan), "Tan")]
        [TestCase(typeof(Arcsin), "Arcsin")]
        [TestCase(typeof(Arccos), "Arccos")]
        [TestCase(typeof(Arctan), "Arctan")]
        [TestCase(typeof(Sqrt), "Sqrt")]
        public void FactoryTest(Type type, string name)
        {
            Type resultType = OneArgmumentFactory.CreateCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void UndefTest()
        {
            Type resultType = OneArgmumentFactory.CreateCalculator("Ass").GetType();
        }
    }
}