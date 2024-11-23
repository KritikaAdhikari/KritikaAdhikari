using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5 ; int n2 = 4;
            Console.WriteLine($"Before Swapping = {n1},{n2}");
            n1 = n1 * n2;
            n2 = n1 / n2;
            n1 = n1 / n2;
            Console.WriteLine($"After Swapping = {n1},{n2}");
        }
    }
}
