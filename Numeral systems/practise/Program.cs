using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace practise
{
    class Program
    {
        static void Main()
        {
            BigInteger decValue = BigInteger.Parse(Console.ReadLine());
            string result = " ";
            string[] hexDigits = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' '); ;

            do
            {
                BigInteger value = (int)decValue % 16;
                result = hexDigits[(int)value] + result;
                decValue /= 16;
            } while (decValue !=0);
            Console.WriteLine(result);
        }
    }
}

/*
 * private static long Pow(int a, int b)
    {
        long result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        return result;
    }
 * */
