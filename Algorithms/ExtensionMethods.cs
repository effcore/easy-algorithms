using System.Collections.Generic;

namespace Algorithms
{
    public static class ExtensionMethods
    {
        public static void Swap(this int[] givenArray, int indexA, int indexB)
        {
            int tempValue = givenArray[indexA];
            givenArray[indexA] = givenArray[indexB];
            givenArray[indexB] = tempValue;
        }
        public static void Swap(this double[] givenArray, int indexA, int indexB)
        {
            double tempValue = givenArray[indexA];
            givenArray[indexA] = givenArray[indexB];
            givenArray[indexB] = tempValue;
        }

        public static int[] ToIntArray(this string givenString)
        {
            List<int> intList = new List<int>();

            foreach(char c in givenString)
            {
                intList.Add(System.Convert.ToInt32(c));
            }

            return intList.ToArray();
        }

        public static string ToStringFromAscii(this int[] givenArray)
        {
            string phrase = string.Empty;

            foreach(int i in givenArray)
            {
                char c = (char)i;
                phrase += c;
            }

            return phrase;
        }
    }
}
