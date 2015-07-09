using Calculator.ArraySort;
using NUnit.Framework;

namespace calculator.Tests.ArraySort
{
    [TestFixture]
    public class FastSortTests : ArraySortTests
    {
        [SetUp]

        public void Initialize()
        {
            Sorter = ArraySortFactory.CreateCalculator("FastSort");
        }
    }
}