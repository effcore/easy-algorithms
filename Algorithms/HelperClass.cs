using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class HelperClass
    {
        /// <summary>
        /// Gets the majority number of an array, which occurs 50% or more.
        /// </summary>
        /// <param name="givenArray"></param>
        /// <returns></returns>
        public virtual int GetMajorityNumber(int[] givenArray)
        {
            return givenArray.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
        }
    }
}
