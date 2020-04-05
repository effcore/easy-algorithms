using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class SortingTest
    {
        int[] SourceIntArray = { 64, 25, 12, 22, 11 };
        int[] ExpectedIntArray = { 11, 12, 22, 25, 64 };
        double[] SourceDoubleArray = { 64.00, 25.00, 11.01, 22.00, 11.04 };
        double[] ExpectedDoubleArray = { 11.01, 11.04, 22.00, 25.00, 64.00 };
        Sorting SortingAlgorithms = new Sorting();

        #region Selection Sort
        [TestMethod]
        public void TestSelectionInt()
        {
            int[] resultIntArray = SortingAlgorithms.Selection(SourceIntArray);
            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestSelectionDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Selection(SourceDoubleArray);
            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion

        #region Bubble Sort
        [TestMethod]
        public void TestBubbleInt()
        {
            int[] resultIntArray = SortingAlgorithms.Bubble(SourceIntArray);

            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestBubbleDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Bubble(SourceDoubleArray);

            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion

        #region Insertion Sort
        [TestMethod]
        public void TestInsertionInt()
        {
            int[] resultIntArray = SortingAlgorithms.Insertion(SourceIntArray);

            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestInsertionDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Insertion(SourceDoubleArray);

            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion

        #region Merge Sort
        [TestMethod]
        public void TestMergeInt()
        {
            int[] resultIntArray = SortingAlgorithms.Merge(SourceIntArray);

            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestMergeDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Merge(SourceDoubleArray);

            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion

        #region Quick Sort
        [TestMethod]
        public void TestQuickInt()
        {
            int[] resultIntArray = SortingAlgorithms.Quick(SourceIntArray);

            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestQuickDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Quick(SourceDoubleArray);

            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion

        #region Heap Sort
        [TestMethod]
        public void TestHeapInt()
        {
            int[] resultIntArray = SortingAlgorithms.Heap(SourceIntArray);
            CollectionAssert.AreEqual(ExpectedIntArray, resultIntArray);
        }

        [TestMethod]
        public void TestHeapDouble()
        {
            double[] resultDoubleArray = SortingAlgorithms.Heap(SourceDoubleArray);

            CollectionAssert.AreEqual(ExpectedDoubleArray, resultDoubleArray);
        }
        #endregion
    }
}
