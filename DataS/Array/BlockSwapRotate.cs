using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /*
    https://www.geeksforgeeks.org/block-swap-algorithm-for-array-rotation/
    Block swap algorithm for array rotation
    Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
        */
    class BlockSwapRotate
    {

        //Recusrive implementation 
        public static void BlockSwapRotateArray(int [] arr, int d,int n)
        {
            if (n - d == d)
            {
                Swap(arr, 0, n-d, d);
                return;
            }
            else if (n-d < d)
            {
                Swap(arr, 0,n - d,d);
                BlockSwapRotateArray(arr, d, n - d);
            }
            else if(n-d > d)
            {
                Swap(arr, 0, d, n - d);
                //BlockSwapRotateArray(arr + n-d, 2 * d - n, d);
            }
        }

        //Iterative implementation 
        public static void BlockSwapRotateArrayItertive(int [] arr, int d, int n)
        {
            int i, j;

            if (d == 0 || d == n)
                return;

            i = d;
            j = n - d;

            while(i !=j)
            {
                if(i < j) // A is shorter
                {
                    Swap(arr, d - i, d + j - i,i);
                    j -= i;
                }
                else //B is shorter
                {
                    Swap(arr, d - i, d, j);
                    i -= j;
                }
            }
            //Finally block swap A and B
            Swap(arr, d - i, d, i);
        }


        public static void Swap(int [] arr,int fi, int si, int d)
        {
            int temp;
            for(int i = 0; i < d;i++)
            {
                temp = arr[fi + i];
                arr[fi + i] = arr[si + i];
                arr[si + i] = temp;

            }
        }

    }
}
