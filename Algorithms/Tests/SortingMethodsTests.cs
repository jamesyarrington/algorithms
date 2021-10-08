using NUnit.Framework;
using Sorts;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    public class SortingMethodsTests
    {
        private int[] _testArray;
        private int[] _sortedArray;

        private List<int> _testList;
        private List<int> _sortedList;

        [SetUp]
        public void Setup()
        {
            _testArray = new int[] { 8, 6, 7, 5, 3, 0, 9, 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            _sortedArray = new int[] { 0, 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 6, 7, 8, 9, 9 };
            _testList = new List<int> { 8, 6, 7, 5, 3, 0, 9, 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            _sortedList = new List<int> { 0, 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 6, 7, 8, 9, 9 };
        }

        [Test]
        public void QuickSort_Sorts()
        {
            Assert.AreEqual(_sortedArray, _testArray.QuickSort());
        }

        [Test]
        public void MergeSort_Sorts()
        {
            Assert.AreEqual(_sortedList, _testList.QuickSort());
        }
    }
}