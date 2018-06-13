using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        #region All Array Problem Definations
        /*
          
        1.Program for array rotation (ArrayRotation)
        2.Reversal algorithm for array rotation (ArrayReversal)
        3.Block swap algorithm for array rotation
        4.Program to cyclically rotate an array by one
        5.Search an element in a sorted and rotated array
        6.Given a sorted and rotated array, find if there is a pair with a given sum
        7.Find maximum value of Sum( i*arr[i]) with only rotations on given array allowed
        8.Maximum sum of i*arr[i] among all rotations of a given array
        9.Find the Rotation Count in Rotated Sorted array
        10.Quickly find multiple left rotations of an array
        11.Find the minimum element in a sorted and rotated array
        12.Reversal algorithm for right rotation of an array
        13.Find a rotation with maximum hamming distance
        14.Queries on Left and Right Circular shift on array
        15.Print left rotation of array in O(n) time and O(1) space
        16.Find element at given index after a number of rotations
        17.Split the array and add the first part to the end

        */
        #endregion

        static void Main(string[] args)
        {

        Console.WriteLine(
        "***List of Programs to run" + "\n \n"+
        "1.Program for array rotation (ArrayRotation)" + "\n"
        + "2.Reversal algorithm for array rotation (ArrayReversal)" + "\n"
        + "3.Block swap algorithm for array rotation"+"\n"
        + "4.Program to cyclically rotate an array by one" + "\n"
        + "5.Search an element in a sorted and rotated array" + "\n"
        + "6.Given a sorted and rotated array, find if there is a pair with a given sum" + "\n"
        + "7.Find maximum value of Sum(i * arr[i]) with only rotations on given array allowed" + "\n"
        + "8.Maximum sum of i * arr[i] among all rotations of a given array" + "\n"
        + "9.Find the Rotation Count in Rotated Sorted array" + "\n"
        + "10.Quickly find multiple left rotations of an array" + "\n"
        + "11.Find the minimum element in a sorted and rotated array" + "\n"
        + "12.Reversal algorithm for right rotation of an array" + "\n"
        + "13.Find a rotation with maximum hamming distance" + "\n"
        + "14.Queries on Left and Right Circular shift on array" + "\n"
        + "15.Print left rotation of array in O(n) time and O(1) space" + "\n"
        + "16.Find element at given index after a number of rotations" + "\n"
        + "17.Split the array and add the first part to the end" + "\n"
        + "0. Exit"
                ) ;
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    //Array sample for rotation
                    Console.WriteLine("1.Program for array rotation (ArrayRotation)");
                    int[] arr = { 2, 3, 6, 5, 9 };
                    Console.WriteLine("Original Array");
                    PrintArray(arr);

                    //Array rotation
                    int[] arr1;
                    arr1 = ArrayRotation.RotateArrayByN(arr, 2);
                    Console.WriteLine("Rotate array: ");
                    PrintArray(arr1);
                    break;
                case 2:
                    //Reverse an array
                    int[] revarr = { 2, 3, 6, 5, 9 };
                    Console.WriteLine("Original Array reversal");
                    PrintArray(revarr);
                    int[] revarray;
                    revarray = ArrayReversal.ReverseArray(revarr);
                    Console.WriteLine("Reversal of an array: ");
                    PrintArray(revarray);
                    break;
                case 3:
                    //Blockswap rotate array
                    int[] blockswaparr = { 1, 2, 3, 4, 5, 6, 7 };
                    Console.WriteLine("Original Array reversal");
                    PrintArray(blockswaparr);
                    BlockSwapRotate.BlockSwapRotateArrayItertive(blockswaparr, 2, 7);
                    Console.WriteLine("Result after Block swap of an array: ");
                    PrintArray(blockswaparr);
                    break;

                case 0:
                    break;

                default :
                    {
                        Console.WriteLine("Please enter a valid choice");
                        break;
                    }

            }

        
        Console.Read();

        }

        public static void PrintArray(int [] arr)
        {
            for(int i = 0; i< arr.Length;i++ )
            {
                Console.Write("{0}, \t",arr[i]);
            }
            Console.WriteLine();
        }

        
    }

    
}
