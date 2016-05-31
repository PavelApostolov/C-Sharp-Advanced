using System;
using System.Collections.Generic;
using System.Linq;


namespace Zadachi_CSharp_2
{
    class Program
    {

        static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long sum = 0;
            int i = 1;

            while (i < sequence.Length)
            {
                long absDiff = Math.Abs(sequence[i] - sequence[i - 1]);
                if (absDiff % 2 == 0)
                {
                    sum += absDiff;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}


/*using System;

public class Program
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var numbersAsString = line.Split(' ');
        var numbers = new long[numbersAsString.Length];
        for (int j = 0; j < numbersAsString.Length; j++)
        {
            numbers[j] = int.Parse(numbersAsString[j]);
        }

        var answer = SumOfDifferences(numbers);
        Console.WriteLine(answer);
    }

    private static long SumOfDifferences(long[] numbers)
    {
        long sum = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            long diff = Math.Abs(numbers[i] - numbers[i - 1]);
            if (diff % 2 == 0)
            {
                i++;
                sum += diff;
            }
        }

        return sum;
    }
}
 * */
