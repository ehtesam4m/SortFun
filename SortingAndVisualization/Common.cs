using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndVisualization
{
    public class Common
    {
        public static void Exchange(int[] data, int m, int n)
        {
            (data[m], data[n]) = (data[n], data[m]);
        }

        public static void ArrayColorPrint(int[] array, int index1, int index2, ConsoleColor color)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index1 || i == index2)
                {
                    Console.ForegroundColor = color;
                    Console.Write($"{array[i]} ");
                    Console.ResetColor();
                }
                else
                    Console.Write($"{array[i]} ");

            }
            Console.Write("\n");
        }
        public static void ColorPrint(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write($"{text} ");
            Console.ResetColor();
        }


    }
}
