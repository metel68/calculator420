using Calculator.ArraySort;
using NUnit.Framework;

namespace calculator.Tests.ArraySort
{   
    public class ArraySortTests
    {
        protected IOperation Sorter;
        [TestCase(new[] {12.0, 5.0, 1.0, 6.0}, new[] {1.0, 5.0, 6.0, 12.0})]
        [TestCase(new[] {2.0, 5.0, 123.0, 570.0}, new[] {2.0, 5.0, 123.0, 570.0})]
        [TestCase(new[] {853.0, 524.0, 123.0, -43.0}, new[] {-43.0, 123.0, 524.0, 853.0})]
        [TestCase(new[] {321.0, 321.0, 2.0, -60.0}, new[] {-60.0, 2.0, 321.0, 321.0})]
        [TestCase(new[] {1.0, 3.0, 4.0, 2.0}, new[] {1.0, 2.0, 3.0, 4.0})]
        [TestCase(new[] {32.0, 123.0, 43.0, -543.0, 3213.0, 4324.0, 6567.0, 231223.0, 678.0, 234245.0, 7657.0, 5345.0, 6788.0, 34345.0, 98798.0, 345.0, 1231.0, 768.0, 4324.0, 121.0},
            new[]{-543.0, 32.0, 43.0, 121.0, 123.0, 345.0, 678.0, 768.0, 1231.0, 3213.0, 4324.0, 4324.0, 5345.0, 6567.0, 6788.0, 7657.0, 34345.0, 98798.0, 231223.0, 234245.0})]
        public void Calculate(double[] argument, double[] result)
        {
            Sorter.Calculate(argument);
            var testResult = argument;
            Assert.AreEqual(result, testResult);
        }
    }
}