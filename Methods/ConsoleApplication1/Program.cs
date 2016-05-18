using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumberEx2
{
    class Program
    {
        static double GetMax(double a, double b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;

            }
        }

        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = sequence[0];
            int b = sequence[1];
            int c = sequence[2];


            Console.WriteLine(GetMax(c, GetMax(a, b)));

        }
    }
}