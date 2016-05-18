using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number N size of the array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers of array:", n);
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("Sorted words by length :\n");
        var sortedArray = array.OrderBy(x => x.Length);
        Console.WriteLine(string.Join("\n", sortedArray));

        // SECOND WAY:

        //Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        //Console.WriteLine(string.Join("\n", array));
    }
}
/*
using System;
using System.Collections;

namespace _05_Sort_By_String_Length
{
    class SortByStringLength
    {
        // Custom Coparer, Sorting based on String.Length
        public class myCompare : IComparer
        {
            int IComparer.Compare(object Right, object Left)
            {
                string strLeft = Left.ToString();
                string strRight = Right.ToString();

                if (strRight.Length < strLeft.Length)
                {
                    return -1;
                }
                else if (strRight.Length > strLeft.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        static void Main()
        {
            // input
            int arraySize = int.Parse(Console.ReadLine());

            // get array
            string[] toSearch = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                toSearch[i] = Console.ReadLine();
            }

            // initialize custom sort
            myCompare sortStrLength = new myCompare();

            // sort
            Array.Sort(toSearch, sortStrLength);

            // print the results
            Console.WriteLine(string.Join(Environment.NewLine, toSearch));
        }
    }
}
*/