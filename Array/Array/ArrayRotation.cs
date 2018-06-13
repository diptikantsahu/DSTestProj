using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayRotation
    {

        /* https://www.geeksforgeeks.org/array-rotation/ 

        Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.

        */

        public static void RotateArrayByOne(int [] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i+1] = temp;
            }
        }

        public static int[] RotateArrayByN(int [] arr, int number)
        {
            for (int i = 0;i < number;i++)
            {
                RotateArrayByOne(arr);
            }

            return arr;
        }
    }
}
