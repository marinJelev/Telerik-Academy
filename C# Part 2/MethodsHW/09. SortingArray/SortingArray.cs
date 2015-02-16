﻿//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static int leftMax = int.MinValue;
    static int rightMax = int.MinValue;


    static void Main()
    {
        //User input of arrays

        //Console.Write("Length of first array: ");
        //int length = int.Parse(Console.ReadLine());
        //Console.WriteLine();

        //Console.WriteLine("Input array:");
        //int[] test = new int[length];
        //for (int i = 0; i < length; i++)
        //{
        //    Console.Write("numArray[{0}]= ", i);
        //    test[i] = int.Parse(Console.ReadLine());
        //}

        int[] test = { 10, 2, 5, 10, 40, 100, 30, 90 };

        Console.Write("Choose index: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Max numbers in left/right portion, depending on index position: ");
        Console.WriteLine(MaxElementInPortion(index, test));
        Console.WriteLine();


    }

    static int MaxElementInPortion(int index, int[] someArray)
    {

        int rightCurrentPosition = someArray[index];

        //right portion
        if (index >= someArray.Length / 2)
        {
            for (int i = index; i < someArray.Length; i++)
            {
                if (someArray[i] > rightCurrentPosition)
                {
                    rightMax = someArray[i];
                    rightCurrentPosition = someArray[i];
                }
                else
                {
                    rightMax = rightCurrentPosition;
                }

            }
            return rightMax;
        }
        //left portion
        else  //(index < someArray.Length / 2)
        {
            int leftCurrentPosition = someArray[0];
            for (int i = 0; i <= index; i++)
            {
                if (someArray[i] > leftCurrentPosition)
                {
                    leftMax = someArray[i];
                    leftCurrentPosition = someArray[i];
                }
                else
                {
                    leftMax = leftCurrentPosition;
                }
            }
            return leftMax;
        }
    }

}   


//static public int[] test = { 10, 2, 5, 10, 100, 40, 30, 90 };
//                             0   1  2  3   4    5   6   7  length = 8