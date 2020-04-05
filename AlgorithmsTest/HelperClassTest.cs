using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class HelperClassTest
    {
        HelperClass HelperClass = new HelperClass();

        [TestMethod]
        public void TestGetMajorityNumber()
        {
            int[] someArray = new int[] { 8, 3, 5, 1, 8, 10, 2, 2, 2, 19, 2 };
            int result = HelperClass.GetMajorityNumber(someArray);
            Assert.AreEqual(2, result);
        }
    }
}
