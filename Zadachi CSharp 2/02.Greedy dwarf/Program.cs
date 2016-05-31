using System;
using System.Collections.Generic;
using System.Linq;

class GreedyDwarf
{
    static int bestCollection = Int32.MinValue;

    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(ch => int.Parse(ch)).ToArray();

        int pattersCount = int.Parse(Console.ReadLine());
        List<int[]> patterns = new List<int[]>();

        for (int i = 0; i < pattersCount; i++)
            patterns.Add(Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(ch => int.Parse(ch)).ToArray());

        for (int i = 0; i < pattersCount; i++)
        {
            bool[] visited = new bool[numbers.Length];
            visited[0] = true;

            int indexPattern = 0, indexNumbers = 0, currentCollection = numbers[0];

            while (true)
            {
                indexNumbers += patterns[i][indexPattern];
                indexPattern = (indexPattern + 1) % patterns[i].Length;

                if (indexNumbers < 0 || indexNumbers >= numbers.Length) break;

                if (visited[indexNumbers]) break;

                visited[indexNumbers] = true;

                currentCollection += numbers[indexNumbers];
            }

            if (currentCollection > bestCollection) bestCollection = currentCollection;
        }

        Console.WriteLine(bestCollection);
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Zadachi_CSharp_2
{

    class Program
    {
        private static long ProcessPattern(int[] vally)
        {
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNumbers.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNumbers[i]);
            }
            bool[] visited = new bool[vally.Length];
            long coinSum = 0;
            coinSum += vally[0];
            visited[0] = true;
            int currentPosition = 0;

            while (true)
	        {
	            for (int i = 0; i < pattern.Length; i++)
            {
                int nextMove = currentPosition + pattern[i];
                if (nextMove >= 0 && nextMove < vally.Length && !visited[nextMove])
                {
                    coinSum += vally[nextMove];
                    visited[nextMove] = true;
                    currentPosition = nextMove;
                }
                else
	            {
                    return coinSum;
	            }
	        }
            }

        }
        
        static void Main()
        {
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] vallyNumbers = new int[rawNumbers.Length];
            for (int i = 0; i < vallyNumbers.Length; i++)
            {
                vallyNumbers[i] = int.Parse(rawNumbers[i]);
            }
            
            int numberOfPatterns = int.Parse(Console.ReadLine());

            long bestSum = long.MinValue;

            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = ProcessPattern(vallyNumbers);
                if (sum>bestSum)
                {
                    bestSum = sum;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}*/


