﻿/*  Problem 11. Binary search
    Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
            On the last line you will receive the number X
    Output:
            Print the index where X is in the array
                If there is more than one occurence print the first one
                If there are no occurences print -1                              */

using System;

class BinarySearch
{
    static void Main()
    {
        // Input 
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }
        int element = int.Parse(Console.ReadLine()); //the element, whose index You want to find

        // Binary search works only on sorted arrays.
        Array.Sort(arrayNums);

        int leftRange = 0;
        int rightRange = arrayNums.Length - 1;
        int middle = 0;
        int index = -1;

        while (leftRange <= rightRange)
        {
            middle = (leftRange + rightRange) / 2;
            if (arrayNums[middle] < element)
            {
                leftRange = middle + 1;
            }
            else if (arrayNums[middle] > element)
            {
                rightRange = middle - 1;
            }
            else  // array[middle] == element 
            {
                index = middle;
                break;
            }
        }

        Console.WriteLine(index);

    }
}


/*using System;

class FindsIndexInSortedArrayUsingBinarySearch
{
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array);
        int iMax = array.Length - 1;
        int iMin = 0;
        while (iMax >= iMin)
        {
            int iMidpoint = (iMin + iMax) / 2;
            if (array[iMidpoint] < key)
            {
                iMin = iMidpoint + 1;
            }
            else if (array[iMidpoint] > key)
            {
                iMax = iMidpoint - 1;
            }
            else
            {
                return iMidpoint;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] myArray = { 4, 7, 4, 6, 2, 7, 5, 12, 22, 13, };
        int key = 7;
        Console.WriteLine(BinSearch(myArray, key));
    }
}
*/