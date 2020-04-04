using System;

namespace Algorithms
{
    public class Sorting
    {
        #region Selection Sort
        /// <summary>
        /// Selection sort is an in-place comparison sort.
        /// It has O(n2) complexity, making it inefficient on large lists, and generally performs worse than the similar insertion sort.
        /// Selection sort is noted for its simplicity, and also has performance advantages over more complicated algorithms in certain situations.
        /// The algorithm finds the minimum value, swaps it with the value in the first position, and repeats these steps for the remainder of the list.
        /// It does no more than n swaps, and thus is useful where swapping is very expensive.
        /// 
        /// source: en.wikipedia.org/wiki/Selection_sort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Selection(int[] sourceArray)
        {
            int minIndex;

            for (int i = 0; i < sourceArray.Length - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < sourceArray.Length; j++)
                {
                    if (sourceArray[j] < sourceArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                sourceArray.Swap(minIndex, i);
            }

            return sourceArray;
        }

        /// <summary>
        /// Selection sort is an in-place comparison sort.
        /// It has O(n2) complexity, making it inefficient on large lists, and generally performs worse than the similar insertion sort.
        /// Selection sort is noted for its simplicity, and also has performance advantages over more complicated algorithms in certain situations.
        /// The algorithm finds the minimum value, swaps it with the value in the first position, and repeats these steps for the remainder of the list.
        /// It does no more than n swaps, and thus is useful where swapping is very expensive.
        /// 
        /// source: https://en.wikipedia.org/wiki/Selection_sort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual double[] Selection(double[] sourceArray)
        {
            int minIndex;

            for (int i = 0; i < sourceArray.Length - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < sourceArray.Length; j++)
                {
                    if (sourceArray[j] < sourceArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                sourceArray.Swap(minIndex, i);
            }

            return sourceArray;
        }
        #endregion

        #region Bubble Sort
        /// <summary>
        /// Bubble sort is a simple sorting algorithm. The algorithm starts at the beginning of the data set.
        /// It compares the first two elements, and if the first is greater than the second, it swaps them.
        /// It continues doing this for each pair of adjacent elements to the end of the data set.
        /// It then starts again with the first two elements, repeating until no swaps have occurred on the last pass.
        /// This algorithm's average time and worst-case performance is O(n2), so it is rarely used to sort large, unordered data sets.
        /// Bubble sort can be used to sort a small number of items (where its asymptotic inefficiency is not a high penalty).
        /// Bubble sort can also be used efficiently on a list of any length that is nearly sorted (that is, the elements are not significantly out of place).
        /// 
        /// source: en.wikipedia.org/wiki/Bubble_sort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Bubble(int[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length - 1; i++)
            {
                for (int j = 0; j < sourceArray.Length - i - 1; j++)
                {
                    if (sourceArray[j] > sourceArray[j + 1])
                    {
                        sourceArray.Swap(j, j + 1);
                    }
                }
            }

            return sourceArray;
        }

        public virtual double[] Bubble(double[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length - 1; i++)
            {
                for (int j = 0; j < sourceArray.Length - i - 1; j++)
                {
                    if (sourceArray[j] > sourceArray[j + 1])
                    {
                        sourceArray.Swap(j, j + 1);
                    }
                }
            }

            return sourceArray;
        }
        #endregion

        #region Insertion Sort
        /// <summary>
        /// Insertion sort is a simple sorting algorithm that is relatively efficient for small lists and mostly sorted lists, and is often used as part of more sophisticated algorithms.
        /// It works by taking elements from the list one by one and inserting them in their correct position into a new sorted list similar to how we put money in our wallet.
        /// In arrays, the new list and the remaining elements can share the array's space, but insertion is expensive, requiring shifting all following elements over by one.
        /// 
        /// source: en.wikipedia.org/wiki/Insertion_sort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Insertion(int[] sourceArray)
        {
            for (int i = 1; i < sourceArray.Length; ++i)
            {
                int key = sourceArray[i];
                int j = i - 1;

                while (j >= 0 && sourceArray[j] > key)
                {
                    sourceArray[j + 1] = sourceArray[j];
                    j = j - 1;
                }

                sourceArray[j + 1] = key;
            }

            return sourceArray;
        }

        public virtual double[] Insertion(double[] sourceArray)
        {
            for (int i = 1; i < sourceArray.Length; ++i)
            {
                double key = sourceArray[i];
                int j = i - 1;

                while (j >= 0 && sourceArray[j] > key)
                {
                    sourceArray[j + 1] = sourceArray[j];
                    j = j - 1;
                }

                sourceArray[j + 1] = key;
            }

            return sourceArray;
        }
        #endregion

        #region Merge Sort
        /// <summary>
        /// Merge sort takes advantage of the ease of merging already sorted lists into a new sorted list.
        /// It starts by comparing every two elements (i.e., 1 with 2, then 3 with 4...) and swapping them if the first should come after the second.
        /// It then merges each of the resulting lists of two into lists of four, then merges those lists of four, and so on; until at last two lists are merged into the final sorted list.
        /// Of the algorithms described here, this is the first that scales well to very large lists, because its worst-case running time is O(n log n).
        /// It is also easily applied to lists, not only arrays, as it only requires sequential access, not random access.
        /// 
        /// source: en.wikipedia.org/wiki/Merge_sort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Merge(int[] sourceArray)
        {
            MergeSort(sourceArray, 0, sourceArray.Length - 1);

            return sourceArray;
        }

        public virtual double[] Merge(double[] sourceArray)
        {
            MergeSort(sourceArray, 0, sourceArray.Length - 1);

            return sourceArray;
        }

        internal static void MergeTogether(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
        internal static void MergeTogether(double[] input, int left, int middle, int right)
        {
            double[] leftArray = new double[middle - left + 1];
            double[] rightArray = new double[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }


        internal static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);
                MergeTogether(input, left, middle, right);
            }
        }

        internal static void MergeSort(double[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);
                MergeTogether(input, left, middle, right);
            }
        }
        #endregion

        #region Quick Sort
        /// <summary>
        /// Quicksort is a divide and conquer algorithm which relies on a partition operation: to partition an array, an element called a pivot is selected.
        /// All elements smaller than the pivot are moved before it and all greater elements are moved after it.
        /// This can be done efficiently in linear time and in-place. The lesser and greater sublists are then recursively sorted.
        /// This yields average time complexity of O(n log n), with low overhead, and thus this is a popular algorithm.
        /// 
        /// source: en.wikipedia.org/wiki/Quicksort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Quick(int[] sourceArray)
        {
            QuickSort(sourceArray, 0, sourceArray.Length -1);

            return sourceArray;
        }

        public virtual double[] Quick(double[] sourceArray)
        {
            QuickSort(sourceArray, 0, sourceArray.Length - 1);

            return sourceArray;
        }

        internal static int QuickPartition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        internal static int QuickPartition(double[] arr, int left, int right)
        {
            double pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    double temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        internal static void QuickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = QuickPartition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        internal static void QuickSort(double[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = QuickPartition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        #endregion

        #region Heap Sort
        /// <summary>
        /// Heapsort is a much more efficient version of selection sort.
        /// It also works by determining the largest (or smallest) element of the list, placing that at the end (or beginning) of the list,
        /// then continuing with the rest of the list, but accomplishes this task efficiently by using a data structure called a heap, a special type of binary tree.
        /// Once the data list has been made into a heap, the root node is guaranteed to be the largest (or smallest) element.
        /// When it is removed and placed at the end of the list, the heap is rearranged so the largest element remaining moves to the root.
        /// Using the heap, finding the next largest element takes O(log n) time, instead of O(n) for a linear scan as in simple selection sort.
        /// This allows Heapsort to run in O(n log n) time, and this is also the worst case complexity. 
        /// 
        /// source: en.wikipedia.org/wiki/Heapsort
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public virtual int[] Heap(int[] sourceArray)
        {
            // Build heap (rearrange array) 
            for (int i = sourceArray.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(sourceArray, sourceArray.Length, i);
            }

            // One by one extract an element from heap 
            for (int i = sourceArray.Length - 1; i > 0; i--)
            {
                // Move current root to end 
                sourceArray.Swap(0, i);

                // call max heapify on the reduced heap 
                Heapify(sourceArray, i, 0);
            }

            return sourceArray;
        }

        public virtual double[] Heap(double[] sourceArray)
        {
            // Build heap (rearrange array) 
            for (int i = sourceArray.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(sourceArray, sourceArray.Length, i);
            }

            // One by one extract an element from heap 
            for (int i = sourceArray.Length - 1; i > 0; i--)
            {
                // Move current root to end 
                sourceArray.Swap(0, i);

                // call max heapify on the reduced heap 
                Heapify(sourceArray, i, 0);
            }

            return sourceArray;
        }

        internal static void Heapify(int[] sourceArray, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && sourceArray[l] > sourceArray[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && sourceArray[r] > sourceArray[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                sourceArray.Swap(i, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(sourceArray, n, largest);
            }
        }

        internal static void Heapify(double[] sourceArray, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && sourceArray[l] > sourceArray[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && sourceArray[r] > sourceArray[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                sourceArray.Swap(i, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(sourceArray, n, largest);
            }
        }
        #endregion
    }
}
