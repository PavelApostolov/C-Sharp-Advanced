//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there is no such element.
using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static int IndexOfLargerThanNeighbours(int[] numbers)
    {
        int index = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }

        return index;
    }

    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

        Console.WriteLine(IndexOfLargerThanNeighbours(numbers));
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours

{
    class Program
    {
        static void LargerThan(int N)

        {
            int[] numbers = new int[N];

            numbers = Console.ReadLine()
           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(item => int.Parse(item))
           .ToArray();



            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine(i);
                    break;

                }

            }


        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            LargerThan(N);

        }
    }

*/