using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            // spell 
            int[] arrayLinearSearch = { 1, 2, 4, 3, 5, 7, 6, 9, 8, 10 };

            int i = LinearSearch.DoLinearSearch(arrayLinearSearch, 11);

            if (i > 0)
            {
                Console.WriteLine("Element {0} found in the array at {1} position", arrayLinearSearch[i], i);
            }
            else
            {
                Console.WriteLine("Element not found in the given array ");
            }

            Console.Read();
        }
    }
}
