using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class ExtensionMethods
    {
        #region Extensions for int[]
        public static void Swap(this int[] givenArray, int indexA, int indexB)
        {
            if (indexA < 0 || indexB < 0)
                throw new Exception("negative index is not allowed");

            if (indexA != indexB)
            {
                int tempValue = givenArray[indexA];
                givenArray[indexA] = givenArray[indexB];
                givenArray[indexB] = tempValue;
            }
        }

        public static string ToStringFromAscii(this int[] givenArray)
        {
            if (givenArray.Length == 0)
                throw new Exception("array is empty");

            string phrase = string.Empty;

            foreach (int i in givenArray)
            {
                char c = (char)i;
                phrase += c;
            }

            return phrase;
        }
        #endregion

        #region Extensions for double[]
        public static void Swap(this double[] givenArray, int indexA, int indexB)
        {
            if (indexA < 0 || indexB < 0)
                throw new Exception("negative index is not allowed");

            if (indexA != indexB)
            {
                double tempValue = givenArray[indexA];
                givenArray[indexA] = givenArray[indexB];
                givenArray[indexB] = tempValue;
            }
        }
        #endregion

        #region Extensions for string
        public static int[] ToIntArray(this string givenString)
        {
            if (string.IsNullOrEmpty(givenString))
                throw new Exception("string is empty");

            List<int> intList = new List<int>();

            foreach(char c in givenString)
            {
                intList.Add(System.Convert.ToInt32(c));
            }

            return intList.ToArray();
        }
        #endregion
    }
}
