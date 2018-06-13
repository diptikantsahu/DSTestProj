using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayReversal
    {
        /*
        https://www.geeksforgeeks.org/program-for-array-rotation-continued-reversal-algorithm/

        Write a function rotate(arr[], d, n) that rotates arr[] of size n by d elements

        */
        public static int[] ReverseArray(int [] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
            return arr;
        }
    }
}
