using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.SortingClass;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 20, 3, 4, 31, 7, 4, 2, 1, 10 };
            int[] array2 = { 2, 1, 23, 5, 5, 2, 0, -2 };
            Console.WriteLine("Source array1: ");
            ShowArray(array1);
            Console.WriteLine("Quick sort: ");
            QuickSort(array1);
            ShowArray(array1);
            Console.WriteLine("Source array2: ");
            ShowArray(array2);
            Console.WriteLine("Merge sort: ");
            MergeSort(array2);
            ShowArray(array2);
        }

        static void ShowArray(int[] array)
        {
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
