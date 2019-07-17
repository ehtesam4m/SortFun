using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndVisualization
{
    public class SortFactory
    {
        public static ISortAlgorithm GetSortAlgorithm(SortType type)
        {
            switch (type)
            {
                case SortType.BubbleSort:
                    return new BubbleSort();
                case SortType.SelectionSort:
                    return new SelectionSort();
                case SortType.InsertionSort:
                    return new InsertionSort();
                case SortType.MergeSort:
                    return new MergeSort();
                default:
                    return new BubbleSort();
            }
        }
    }
}
