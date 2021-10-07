using NUnit.Framework;
using Sorts;

namespace Algorithms.Tests
{
    public class SortingMethodsTests
    {
        private int[] _testArray;
        private int[] _sortedArray;

        [SetUp]
        public void Setup()
        {
            _testArray = new int[] { 8, 6, 7, 5, 3, 0, 9, 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            _sortedArray = new int[] { 0, 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 6, 7, 8, 9, 9 };
        }

        [Test]
        public void QuickSort_Sorts()
        {
            Assert.AreEqual(_sortedArray, _testArray.QuickSort());
        }
    }
}