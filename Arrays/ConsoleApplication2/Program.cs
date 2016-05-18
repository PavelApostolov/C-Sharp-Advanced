using System;

namespace _3_Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string wordA = Console.ReadLine();
            string wordB = Console.ReadLine();

            if (string.Compare(wordA, wordB) == -1)
            {
                Console.WriteLine("<");
            }
            else if (string.Compare(wordA, wordB) == 1)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}

/*
using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstChars = Console.ReadLine();
        char[] firstArray = firstChars.ToCharArray();   // convert string to char array
        int firstLength = firstArray.Length;            // gets length of the first array

        string secondChars = Console.ReadLine();
        char[] secondArray = secondChars.ToCharArray();
        int secondLength = secondArray.Length;

        bool equal = true;

        if (firstLength < secondLength)
        {
            equal = false;
            // the first array is lexicographically smaller (comes earlier)
            Console.WriteLine("<");
        }
        else if (firstLength > secondLength)
        {
            equal = false;
            // the second array is lexicographically smaller (comes earlier) 
            Console.WriteLine(">");
        }
        else  // firstLength == secondLength
        {
            for (int i = 0; i < firstLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    // the first array is lexicographically smaller (comes earlier)
                    Console.WriteLine("<");
                    equal = false;
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    // the second array is lexicographically smaller(comes earlier)
                    Console.WriteLine(">");
                    equal = false;
                    break;
                }
            }
        }

        if (equal)
        {
            // the arrays are equal
            Console.WriteLine("=");
        }

    }
}
*/