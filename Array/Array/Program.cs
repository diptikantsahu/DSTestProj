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
            Console.WriteLine("Original Array");
            PrintArray(arr);

            //Array rotation
            int[] arr1;
            arr1 = ArrayRotation.RotateArrayByN(arr,2);
            Console.WriteLine("Rotate array: ");
            PrintArray(arr1);


            //Reverse an array
            int[] revarr = { 2, 3, 6, 5, 9 };
            Console.WriteLine("Original Array reversal");
            PrintArray(revarr);
            int[] revarray;
            revarray = ArrayReversal.ReverseArray(revarr);
            Console.WriteLine("Reversal of an array: ");
            PrintArray(revarray);

            Console.Read();

        }

        public static void PrintArray(int [] arr)
        {
            for(int i = 0; i< arr.Length;i++ )
            {
                Console.Write("{0},",arr[i]);
            }
        }

        
    }

    
}
