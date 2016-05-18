using System;
using System.Numerics;


namespace _03_Decimal_To_Hexadecimal
{
    class DecimalToHex
    {
        static void Main()
        {
            //input
            BigInteger DecNumber = BigInteger.Parse(Console.ReadLine());

            // variablse
            string HexNumber = "";
            string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            int toBase = 16;

            while (DecNumber > 0)
            {
                // Step 1: Remainders build the Hex number
                // Right To Left
                HexNumber = HexKey[(int)(DecNumber % toBase)]
                          + HexNumber;

                // Step 2: Divide the Dec Number by toBase
                DecNumber /= toBase;
            }

            // print
            Console.WriteLine(HexNumber);
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()),16).ToString().ToUpper());
        }
    }
}
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Numeral_systems
{
    class ConvertDecimalToHexidecimal
    {
        static void Main()
        {

            ulong number = ulong.Parse(Console.ReadLine());

            StringBuilder list = new StringBuilder();

            while (number != 0)
            {
                if (number % 16 > 9)
                {
                    switch (number % 16)
                    {
                        case 10: list.Append("A");
                            break;
                        case 11: list.Append("B");
                            break;
                        case 12: list.Append("C");
                            break;
                        case 13: list.Append("D");
                            break;
                        case 14: list.Append("E");
                            break;
                        case 15: list.Append("F");
                            break;
                    }
                }
                else
                {
                    list.Append((number % 16).ToString());
                }
                number /= 16;
            }

            for (int i = list.Length - 1; i > -1; i--)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
 * */

