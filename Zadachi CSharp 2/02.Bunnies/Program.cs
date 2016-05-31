using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Zadachi_CSharp_2
{
    class Program
    {

        static void Main()
        {
            string currentCage = Console.ReadLine();

            int[] cages = new int[205];
            int n = 0;

            while (currentCage != "END")
            {
                cages[n] = int.Parse(currentCage);
                n++;
                currentCage = Console.ReadLine();
            }

            for (int i = 1; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < i; j++)
                {
                    s += cages[j];
                }
                if (n - i < s)
                {
                    break;
                }

                int sum = 0;
                BigInteger product = 1;
                for (int j = i; j < i + s; j++)
                {
                    sum += cages[j];
                    product *= cages[j];
                }

                string next = sum.ToString() + product.ToString();
                for (int j = i + s; j < n; j++)
                {
                    next += cages[j].ToString();
                }

                next = next.Replace("0", "");
                next = next.Replace("1", "");

                n = next.Length;
                for (int j = 0; j < n; j++)
                {
                    cages[j] = next[j] - '0';
                }
            }

            //string[] end = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //end[i] = cages[i].ToString();
            //}
            //Console.WriteLine(string.Join(" ", end, 0, n));
            Console.WriteLine(string.Join(" ", cages.Select(x => x.ToString()).ToArray(), 0, n));
        }
    }
}
