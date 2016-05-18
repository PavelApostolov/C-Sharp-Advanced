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
            string binary = Console.ReadLine();
            BigInteger sum = 0;
            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }
            Console.WriteLine(sum);
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()),2));
        }
    }
}
*/