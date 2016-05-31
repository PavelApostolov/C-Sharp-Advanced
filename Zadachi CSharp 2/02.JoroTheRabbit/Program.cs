
using System;
using System.Linq;

class JoroTheRabbit
{
    static int bestLength = 0;

    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(',').Select(ch => Convert.ToInt32(ch)).ToArray();
        
        FindBestLength(numbers);

        Console.WriteLine(bestLength);
    }

    static void FindBestLength(int[] numbers)
    {
        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int index = startIndex, next = 0, currentLength = 1;

                while (next != startIndex)
                {
                    if (index + step >= numbers.Length) next = (index + step) - numbers.Length;
                    else next = index + step;

                    if (numbers[index] >= numbers[next]) break;
                    index = next;
                    currentLength++;
                }

                               
                if (currentLength > bestLength) bestLength = currentLength;

                /*int index = startIndex;
                int currentIndex = 1;
                int index = (index + step) % numbers.Length;

                while (numbers[index] < numbers[next])
                {
                    currentIndex++;
                    index = next;
                    next = (index + step) % numbers.Length;
                }
                if (bestLength<currentLength)
                {
                    bestLength = currentLength;
                }*/
            }
        }
    }
}

/*using System;
using System.Linq;

class JoroTheRabbit
{
    static int bestLength = 0;

    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(',').Select(ch => Convert.ToInt32(ch)).ToArray();

        FindBestLength(numbers);

        Console.WriteLine(bestLength);
    }

    static void FindBestLength(int[] numbers)
    {
        bool[,] visited = new bool[numbers.Length, numbers.Length];

        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                if (visited[startIndex, step]) continue;

                int index = startIndex, next = 0, currentLength = 1;

                while (next != startIndex)
                {
                    next = (index + step) % numbers.Length;
                    if (numbers[index] >= numbers[next]) break;
                    visited[index, step] = true;
                    index = next;
                    currentLength++;
                }

                if (currentLength > bestLength) bestLength = currentLength;
            }
        }
    }
}
*/

