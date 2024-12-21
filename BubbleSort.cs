using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // Derived class for Bubble Sort
    public class BubbleSort : BaseSort
    {
        public BubbleSort(int[] arr) : base(arr)
        {
        }

        public override void Sort()
        {
            Console.WriteLine("Bubble Sort method called");
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
