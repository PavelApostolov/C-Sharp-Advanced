using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_SolvingMultipleTasks
{
    class SolvingMultipleTasks
    {
        public static int ReverseNumber(int number)
        {
            int tempNumber = 0;
            while (number > 0)
            {
                tempNumber = (tempNumber * 10) + (number % 10);
                number /= 10;
            }
            return tempNumber;
        }

        static double GetAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }

        static double SolveEquation(int a, int b)
        {
            return (double)-b / a;
        }

        static void PrintReverseDigits()
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("The reversed number is: " + ReverseNumber(n));
            }
            else
            {
                Console.WriteLine("The number should be positive");
            }
        }

        static void PrintAverage()
        {
            Console.WriteLine("The the length of the array");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (array.Length > 0)
            {
                Console.WriteLine("Get Average: " + GetAverage(array));
            }
            else
            {
                Console.WriteLine("You have entered blank or invalid input");
            }
        }

        static void PrintEquation()
        {
            Console.WriteLine("Enter a and b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("Solve equation" + SolveEquation(a, b));
            }
            else
            {
                Console.WriteLine("Coefficient 'a' should bi different from zero");
            }

        }
        static void Main()
        {
            Console.WriteLine("1: ReverseDigits 2: GetAverage 3: SolveEquation");

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                PrintReverseDigits();
            }
            else if (n == 2)
            {
                PrintAverage();
            }
            else if (n == 3)
            {
                PrintEquation();
            }
        }
    }
}
