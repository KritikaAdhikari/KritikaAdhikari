using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BaseSort
    {
        protected int[] arr;

        public BaseSort(int[] arr)
        {
            this.arr = arr;
        }

        public virtual void Sort()
        {
            Console.WriteLine("Base Sort method called");
        }

        public void PrintArray()
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                    Console.Write($"{arr[i]}, ");
                else
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("]");
        }
    }
}
