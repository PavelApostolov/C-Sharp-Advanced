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
            string binary = " ";
            while (decValue != 0)
            {
                BigInteger bit = decValue % 2;
                binary = bit + binary;
                decValue /= 2;
            }
            Console.WriteLine(binary);
        }
    }
}

/*using System;
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
            Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()), 2));
        }
    }
}
 */

