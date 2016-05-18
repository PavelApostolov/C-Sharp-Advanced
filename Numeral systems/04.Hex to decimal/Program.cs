using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToInt64(Console.ReadLine(), 16));
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Numeral_systems
{
    class ConvertHexidecimalToDecimal
    {
        static void Main()
        {
            string number = Console.ReadLine();
            BigInteger decNumber = 0;
            int index = 0;
            int j = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                switch (number[i])
                {
                    case 'A': index = 10;
                        break;
                    case 'B': index = 11;
                        break;
                    case 'C': index = 12;
                        break;
                    case 'D': index = 13;
                        break;
                    case 'E': index = 14;
                        break;
                    case 'F': index = 15;
                        break;
                    default: index = int.Parse(number[i].ToString());
                        break;
                }
                decNumber += index * (BigInteger)Math.Pow(16, j);
                j++;
            }
            Console.WriteLine(decNumber);
        }
    }
}
 * */

/*
 * using System;
using System.Numerics;

namespace _04_Hexadecimal_To_Decimal
{
    class HexToDec
    {
        static void Main()
        {
            // input
            string HexNumber = Console.ReadLine().ToUpper();

            // variables
            // can be used for ANY base up to 16
            string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            int fromBase = 16;

            BigInteger DecNumber = 0;

            for (int curIndex = 0; 
                     curIndex < HexNumber.Length; 
                     curIndex++)
            {
                DecNumber += (BigInteger)Math.Pow(fromBase, curIndex)
                           * Array.IndexOf(HexKey,
                             HexNumber[HexNumber.Length - 1 - curIndex].ToString());         
            }

            //print
            Console.WriteLine(DecNumber.ToString());
        }
    }
}
*/