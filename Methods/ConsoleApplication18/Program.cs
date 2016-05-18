
/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments. 
Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.*/

using System;
using System.Linq;

class IntegerCalculations
{
    static int MinElement(int[] sequence)
    {
        int minNumber = sequence[0];
        for (int i = 0; i < sequence.Length; i++)
        {

            if (minNumber > sequence[i])
            {
                minNumber = sequence[i];
            }
        }

        return minNumber;
    }

    static int MaxElement(int[] sequence)
    {
        int maxNumber = sequence[0];

        for (int i = 0; i < sequence.Length; i++)
        {
            if (maxNumber < sequence[i])
            {
                maxNumber = sequence[i];
            }
        }

        return maxNumber;
    }

    static decimal Average(int[] sequence)
    {
        long sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        decimal average = (decimal)sum / sequence.Length;
        return average;
    }

    static long Sum(int[] sequence)
    {
        long sum = 0;
        foreach (var number in sequence)
        {
            sum += number;
        }

        return sum;
    }

    static long Product(int[] sequence)
    {
        long product = 1;
        foreach (var number in sequence)
        {
            product *= number;
        }

        return product;
    }

    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(MinElement(sequence));
        Console.WriteLine(MaxElement(sequence));
        Console.WriteLine("{0:F2}", Average(sequence));
        Console.WriteLine(Sum(sequence));
        Console.WriteLine(Product(sequence));

        // Solving the problem using extension methods:
        // Console.WriteLine("Min: " + sequence.Min());
        // Console.WriteLine("Max: " + sequence.Max());
        // Console.WriteLine("Average: {0:F2}", sequence.Average());
        // Console.WriteLine("Sum: " + sequence.Sum());
        // Console.WriteLine("Product: " + sequence.Aggregate((currentProduct, currentValue) => currentProduct * currentValue));
    }
}

/*
    using System;
using System.Linq;
using System.Numerics;

namespace _14_Integer_Calculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            // input
            int[] Numbers = Console.ReadLine()
                            .Trim(' ')          // trim trailing and leading white spaces
                            .Split(' ')
                            .Select(number => int.Parse(number))
                            .ToArray();

            //Console.WriteLine(Numbers.Min());
            //Console.WriteLine(Numbers.Max());


            GetMin(Numbers);
            GetMax(Numbers);
            GetAverage(Numbers);
            GetSum(Numbers);
            GetProduct(Numbers);
        }

        // Get Minimum
        public static void GetMin(params int[] Numbers)
        {
            int MinNumber = int.MaxValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] < MinNumber)
                {
                    MinNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MinNumber);
        }

        // Get Maximum
        public static void GetMax(params int[] Numbers)
        {
            int MaxNumber = int.MinValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] > MaxNumber)
                {
                    MaxNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MaxNumber);
        }

        // Get Average
        public static void GetAverage(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(((double)NumbersSum/(double)Numbers.Length).ToString("F2"));
        }

        // Get Sum
        public static void GetSum(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(NumbersSum);
        }

        // Get Product
        public static void GetProduct(params int[] Numbers)
        {
            BigInteger NumbersProduct = 1;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersProduct *= Numbers[curNumber];
            }

            Console.WriteLine(NumbersProduct);
        }
    }
}
*/