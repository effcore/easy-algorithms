using System;
using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class SearchTest
    {
        public Search Search = new Search();

        #region Binary Search
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] givenArray = new int[] { 1, 5, 7, 23, 4, 29, 84 };
            int targetNo = 23;

            int result = Search.BinarySearch(givenArray, targetNo);
            Assert.AreEqual(3, result);
        }
        #endregion
    }
}
