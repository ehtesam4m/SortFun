using System;
using System.Threading;

namespace SortingAndVisualization
{
    public class InsertionSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Starting Insertion Sort...");
            int i, j;
            int N = array.Length;
            int innerIteration;
            for (j = 1; j < N; j++)
            {
                innerIteration = 1;
                Console.WriteLine("Iteration {0} : {1}", j, string.Join(",", array));
                Thread.Sleep(2000);
                for (i = j; i > 0; i--)
                {
                    Console.WriteLine($"\tInner Iteration {innerIteration}");
                    Console.Write("\t");
                    Common.ComparisonColorPrint(array, i, i- 1, ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                    Console.Write("\t");
                    if (array[i] < array[i - 1])
                    {
                        Common.Exchange(array, i, i - 1);
                        Common.ComparisonColorPrint(array, i, i - 1, ConsoleColor.Red);
                        Thread.Sleep(2000);
                       
                    }
                    else
                    {
                        Common.ComparisonColorPrint(array, i, i - 1, ConsoleColor.Green);
                        Thread.Sleep(2000);
                        break;
                    }
                    
                    innerIteration++;
                }
            }
        }
    }
}
