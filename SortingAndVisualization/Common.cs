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

        public static void ComparisonColorPrint(int[] array, int index1, int index2, ConsoleColor color)
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

        public static void DivisionColorPrint(int[] array, int leftIndex, int middleIndex, int rightIndex, ConsoleColor color1, ConsoleColor color2)
        {
            for (int i = 0; i < leftIndex; i++)
                Console.Write($"{array[i]} ");
            
            for (int i = leftIndex; i <= middleIndex; i++)
            {
                Console.ForegroundColor = color1;
                Console.Write($"{array[i]} ");
            }
            for (int i = middleIndex + 1; i <= rightIndex; i++)
            {
                Console.ForegroundColor = color2;
                Console.Write($"{array[i]} ");
            }

            Console.ResetColor();
            for (int i = rightIndex+1; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            Console.Write("\n");
        }
    }
}
