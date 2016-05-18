﻿/*  Problem 7. Selection sort
    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
    find the smallest from the rest, move it at the second position, etc.
    Print the sorted array. Each number should be on a new line.                     */

using System;

class SelectionSort
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        // Classical implementation of Selection Sort Algorithm
        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            // find the min element in the unsorted a[i..n-1]

            // assume the min is the first element           
            int indexMin = i;

            // test against elements after i to find the smallest
            int j;
            for (j = i + 1; j < arrayNums.Length; j++)
            {
                // if this element is less, then it is the new minimum
                if (arrayNums[j] < arrayNums[indexMin])
                {
                    // found new minimum; remember its index
                    indexMin = j;
                }
            }

            // swaping
            if (indexMin != j)
            {
                int swap = arrayNums[i];
                arrayNums[i] = arrayNums[indexMin];
                arrayNums[indexMin] = swap;
            }
        }

        foreach (var item in arrayNums)
        {
            Console.WriteLine(item);
        }

        // other input => printed on a single line, separated by spaces
        //Console.WriteLine(string.Join(" ", arrayNums) + "\n");
    }
}

/*using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minIndex = j;
                }
            }
            temp = arr[i];
            arr[i] = min;
            arr[minIndex] = temp;
            min = int.MaxValue;
        }

        for (int index = 0; index < n; index++)
        {
            Console.Write("{0} ", arr[index]);
        }
    }
}
*/