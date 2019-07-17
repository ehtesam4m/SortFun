using System;
using System.Threading;

namespace SortingAndVisualization
{
    public class SelectionSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Starting Selection Sort...");
            int i;
            int N = array.Length;
            for (i = 0; i < N - 1; i++)
            {
                Console.WriteLine("Iteration {0} : {1}", i + 1, string.Join(",", array));
                Thread.Sleep(2000);
                int k = FindMinPosition(array, i);
                if (i != k)
                {
                    Common.Exchange(array, i, k);
                    Common.ColorPrint("Exchanged: ", ConsoleColor.Red);
                    Common.ComparisonColorPrint(array, i, k, ConsoleColor.Red);
                }
                else
                    Common.ColorPrint("Not Exchanged", ConsoleColor.Green);
                Console.Write("\n");
            }
        }

        private int FindMinPosition(int[] array, int start)
        {
            int minPos = start;
            int iteration = 1;
            for (int pos = start + 1; pos < array.Length; pos++)
            {
                Console.WriteLine($"\tInner Iteration {iteration}\n\tMin Position: {minPos}");
                Console.Write("\t");
                Thread.Sleep(2000);
                Common.ComparisonColorPrint(array, minPos, pos, ConsoleColor.Yellow);
                Thread.Sleep(2000);
                Console.Write("\t");

                if (array[pos] < array[minPos])
                {
                    minPos = pos;
                    Common.ColorPrint($"Min Position: {minPos}", ConsoleColor.Red);
                }
                else
                    Common.ColorPrint($"Min Position: {minPos}", ConsoleColor.Green);
                iteration++;
                Console.Write("\n\n");
            }
            return minPos;
        }
    }
}
