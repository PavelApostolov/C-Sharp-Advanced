/*  Problem 10. Find sum in array
    Write a program that finds in given array of integers a sequence of given sum S (if present).
    Example:
        array 	                    S 	    result
        4, 3, 1, 4, 2, 5, 8 	    11 	    4, 2, 5
 */
// Note: The elements are consecutively placed.

using System;

class FindSumInArray
{
    static void Main()
    {
        // Input array
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        // Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Fill an integer array from string array
        int[] arrayNums = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            arrayNums[i] = int.Parse(inputElements[i]);
        }

        // Input S
        Console.WriteLine("Enter the sum S = ");
        int s = int.Parse(Console.ReadLine());

        // The first loop assigns a starting index
        for (int i = 0; i < arrayNums.Length; i++)
        {
            int sum = 0;

            /* The second loop sums the elements from the starting index to the right 
             * until this partial sum reaches or is greater than S. */
            for (int j = i; j < arrayNums.Length; j++)
            {
                sum = sum + arrayNums[j];

                if (sum > s)
                {
                    sum = 0;
                    break;
                }

                // If the sum is equal to S, we remember the starting index (from the first loop) and the ending index (from the second loop).
                if (sum == s)
                {
                    for (int index = i; index <= j; index++)
                    {
                        Console.Write(index != j ? arrayNums[index] + ", " : arrayNums[index] + "\n");
                    }
                }
            }
        }

    }
}

/*using System;

class SequenceOfGivenSum
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
        Console.Write("Enter sum  S: ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        bool solution = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The following sequence has the sum of {0}: ", s);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", arr[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        if (!solution)
        {
            Console.WriteLine("There's no sequnce with the sum of {0}!", s);
        }
    }
}
*/