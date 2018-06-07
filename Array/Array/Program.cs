using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array sample for rotation
            int[] arr = { 2, 3, 6, 5, 9 };

            //Array rotation
            int[] arr1;

           arr1 = ArrayRotation.RotateArrayByN(arr,2);

            PrintArray(arr1);

            Console.Read();

        }

        public static void PrintArray(int [] arr)
        {
            for(int i = 0; i< arr.Length;i++ )
            {
                Console.WriteLine("{0},",arr[i]);
            }
        }

        
    }

    
}
