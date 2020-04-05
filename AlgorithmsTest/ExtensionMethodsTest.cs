using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class ExtensionMethodsTest
    {
        #region Extensions for int[]
        [TestMethod]
        public void TestExtensionIntSwap()
        {
            int[] testArray = new int[] { 72, 101, 108, 108, 111, 32, 109, 121, 32, 102, 114, 105, 101, 110, 100, 115, 33 };
            int[] expectedArray = new int[] { 111, 101, 108, 108, 72, 32, 109, 121, 32, 102, 114, 105, 101, 110, 100, 115, 33 };
            testArray.Swap(0, 4);

            CollectionAssert.AreEqual(expectedArray, testArray);
        }

        [TestMethod]
        public void TestExtensionIntArrayToAscii()
        {
            // Given Input:
            // 72 101 108 108 111 32 109 121 32 102 114 105 101 110 100 115 33
            // Expected Output:
            // Hello my friends!

            int[] testArray = new int[] { 72, 101, 108, 108, 111, 32, 109, 121, 32, 102, 114, 105, 101, 110, 100, 115, 33 };
            string result = testArray.ToStringFromAscii();
            Assert.AreEqual("Hello my friends!", result);
        }
        #endregion

        #region Extensions for double[]
        [TestMethod]
        public void TestExtensionDoubleSwap()
        {
            double[] testArray = new double[] { 72.48, 101.51, 108.01, 108.12, 111.74 };
            double[] expectedArray = new double[] { 72.48, 101.51, 111.74, 108.12, 108.01 };
            testArray.Swap(4, 2);

            CollectionAssert.AreEqual(expectedArray, testArray);
        }
        #endregion

        #region Extensions for string
        [TestMethod]
        public void TestExtensionStringToIntArray()
        {
            // Given Input:
            // Hello my friends!
            // Expected Output:
            // 72 101 108 108 111 32 109 121 32 102 114 105 101 110 100 115 33

            string input = "Hello my friends!";
            int[] expectedOutput = new int[] { 72, 101, 108, 108, 111, 32, 109, 121, 32, 102, 114, 105, 101, 110, 100, 115, 33 };
            int[] result = input.ToIntArray();

            CollectionAssert.AreEqual(expectedOutput, result);
        }
        #endregion
    }
}
