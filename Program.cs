using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 7, 1, 11, 5, 90 };

            Console.WriteLine("Original Array:");
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Using BubbleSort
            BaseSort sorter = new BubbleSort(numbers);
            sorter.Sort();

            Console.WriteLine("Sorted Array:");
            sorter.PrintArray();

            Console.ReadLine();
        }
    }
}
