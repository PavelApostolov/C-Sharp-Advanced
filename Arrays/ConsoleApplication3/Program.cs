/// Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
using System;

public class MaximalSequence
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        arr[0] = int.Parse(Console.ReadLine());
        int maxSequence = 0;
        int currentSequence = 1;

        for (int i = 1; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] == arr[i - 1])
            {
                currentSequence += 1;
                maxSequence = Math.Max(maxSequence, currentSequence);
            }
            else
            {
                currentSequence = 1;
            }
        }

        Console.WriteLine(maxSequence);
    }
}

/*
 * using System;

class MaximalSequence
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine()); 
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        int currentLength = 1;
        int maxLength = 0;
        //int elementBestLength = 0;

        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            if (arrayNums[i] == arrayNums[i + 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    //elementBestLength = arrayNums[i];
                }
                currentLength = 1;
            }
        }

        // in case when the last sequence is the maximal sequence of equal elements
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            //elementBestLength = arrayNums[arrayNums.Length - 1];
        }

        Console.WriteLine(maxLength);

        //for (int i = 0; i < maxLength; i++)
        //{
        //    Console.Write(i != maxLength - 1 ? elementBestLength + ", " : elementBestLength + "\n");
        //}

    }
}
 * 
 * using System;

class MaximalSequenceEqualElementsArray
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.

        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        Console.WriteLine("Enter {0} elements: ", length);
        for (int index = 0; index < length; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        int longestSequence = 0;
        int value = 0;
        for (int index = 0; index < length - 1; index++)
        {
            if (arr[index] == arr[index + 1])
            {
                counter++;
                if (longestSequence < counter)
                {
                    longestSequence = counter;
                    value = arr[index];
                }
            }
            else
            {
                counter = 0;
            }
        }
        if (longestSequence == 0)
        {
            Console.WriteLine("There is no sequence of elements");
        }
        else
        {
            Console.WriteLine("The longest sequence is of {0} elements", longestSequence + 1);
        }
    }
}
*/