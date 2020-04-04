using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Search
    {
		public virtual int BinarySearch(int[] givenArray, int targetValue)
		{
			// search space is givenArray[sorted low to high]
			int low = 0;
			int high = givenArray.Length - 1;

			// iterate till search space contains at-least one element
			while (low <= high)
			{
				// find the mid value in the search space and
				// compares it with target value
				int mid = (low + high) / 2; // overflow can happen
											// int mid = low + (high - low)/2;
											// int mid = high - (high - low)/2;

				// target value is found
				if (targetValue == givenArray[mid])
					return mid;

				// if target is less than the mid element, discard all elements
				// in the right search space including the mid element
				else if (targetValue < givenArray[mid])
					high = mid - 1;

				// if target is more than the mid element, discard all elements
				// in the left search space including the mid element
				else
					low = mid + 1;
			}

			// target doesn't exist in the array
			return -1;
		}
	}
}
