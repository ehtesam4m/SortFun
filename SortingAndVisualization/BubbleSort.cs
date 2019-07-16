using System;
using System.Threading;

namespace SortingAndVisualization
{
    public class BubbleSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Starting Bubble Sort...");
            int i, j;
            int N = array.Length;
            int iteration = 1;
            bool switched = false;
            for (j = N - 1; j > 0; j--)
            {
                Console.WriteLine("Iteration {0} : {1}", iteration, string.Join(",", array));
                Thread.Sleep(2000);
                for (i = 0; i < j; i++)
                {
                    switched = false;
                    Console.WriteLine($"\tInner Iteration {i + 1}");
                    Console.Write("\t");
                    Common.ArrayColorPrint(array, i, i + 1, ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                    Console.Write("\t");

                    if (array[i] > array[i + 1])
                    {
                        Common.Exchange(array, i, i + 1);
                        Common.ArrayColorPrint(array, i, i + 1, ConsoleColor.Red);
                        switched = true;
                    }
                    else
                        Common.ArrayColorPrint(array, i, i + 1, ConsoleColor.Green);
                    Thread.Sleep(2000);
                }
                if (!switched)
                    break;
                iteration++;
            }

        }
    }
}
