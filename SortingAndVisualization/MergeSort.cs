using System;
using System.Threading;

namespace SortingAndVisualization
{
    public class MergeSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            mSort(array, 0, array.Length - 1);
        }
        private void mSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                // Find the middle point 
                int middleIndex = (leftIndex + rightIndex) / 2;
                Console.Write("Dividing ");
                Common.DivisionColorPrint(array, leftIndex, middleIndex, rightIndex, ConsoleColor.Magenta, ConsoleColor.Cyan);
                Thread.Sleep(2000);
                // Sort first and second halves 
                mSort(array, leftIndex, middleIndex);
                mSort(array, middleIndex + 1, rightIndex);

                // Merge the sorted halves 
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
        }
        private void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            Console.Write("Merging ");
            Common.DivisionColorPrint(array, leftIndex, middleIndex, rightIndex, ConsoleColor.Yellow, ConsoleColor.Green);
            Thread.Sleep(2000);
            // Find sizes of two subarrays to be merged 
            int leftArraySize = middleIndex - leftIndex + 1;
            int rightArraySize = rightIndex - middleIndex;

            /* Create temp arrays */
            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];

            /*Copy data to temp arrays*/
            for (int i = 0; i < leftArraySize; i++)
                leftArray[i] = array[leftIndex + i];
            for (int j = 0; j < rightArraySize; j++)
                rightArray[j] = array[middleIndex + 1 + j];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int lIndex = 0, rIndex = 0;

            // Initial index of merged subarry array 
            int mIndex = leftIndex;
            while (lIndex < leftArraySize && rIndex < rightArraySize)
            {
                if (leftArray[lIndex] <= rightArray[rIndex])
                {
                    array[mIndex] = leftArray[lIndex];
                    lIndex++;
                }
                else
                {
                    array[mIndex] = rightArray[rIndex];
                    rIndex++;
                }
                mIndex++;
            }

            /* Copy remaining elements of L[] if any */
            while (lIndex < leftArraySize)
            {
                array[mIndex] = leftArray[lIndex];
                lIndex++;
                mIndex++;
            }

            /* Copy remaining elements of R[] if any */
            while (rIndex < rightArraySize)
            {
                array[mIndex] = rightArray[rIndex];
                rIndex++;
                mIndex++;
            }
            Console.Write("Merged and Sorted ");
            Common.DivisionColorPrint(array, leftIndex, middleIndex, rightIndex, ConsoleColor.Red, ConsoleColor.Red);
            Thread.Sleep(2000);
        }
    }
}
