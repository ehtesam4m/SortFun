using System;

namespace SortingAndVisualization
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                //Console.WriteLine("Please enter your comma separated integer array list. eg: 5,8,3");
                //string arrayString = Console.ReadLine();
                /*Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yelow: Comparing");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red: Exchanged");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green: Not Exchanged\n");
                Console.ResetColor();*/
                string arrayString = "8,7,1,3,6,4,6";
                string[] tokens = arrayString.Split(',');
                int[] array = Array.ConvertAll(tokens, int.Parse);
                Console.WriteLine("Select sort type. Enter one of the number from options");
                foreach (var value in Enum.GetValues(typeof(SortType)))
                {
                    string name = Enum.GetName(typeof(SortType), value);
                    Console.WriteLine("{0} {1}", Convert.ToInt32(value), name);
                }
                var selectedOption = Convert.ToInt32(Console.ReadLine());
                ISortAlgorithm alg = SortFactory.GetSortAlgorithm((SortType)selectedOption);
                alg.Sort(array);
                Console.WriteLine("Final: {0}", string.Join(",", array));
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
