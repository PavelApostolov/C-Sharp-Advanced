using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(short.Parse(Console.ReadLine()), 2).PadLeft(16, '0'));
        }
    }
}

/*using System;

namespace _08_Binary_Short
{
    class BinaryShort
    {
        static void Main()
        {
            // input Short 16 bit number
            short toDisplay = short.Parse(Console.ReadLine());

            string toPrint = "";
            string[] BinKey = "0 1".Split(' ');

            for (int i = 0; i < 16; i++)
            {
                // get current 1/ 0
                toPrint = BinKey[(toDisplay & 1)] + toPrint;

                // shift right
                toDisplay >>= 1;
            }

            //print
            Console.WriteLine(toPrint.PadLeft(16, '0'));
        }
    }
}
 * 
 * using System;

class ShortToBinary
{
    static void Main()
    {
        short shortNumber = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinaryConvertion(shortNumber));
    }

    static string ShortToBinaryConvertion(int number)
    {
        string binaryNumber = string.Empty;

        for (int i = 15; i >= 0; i--)
        {
            binaryNumber = ((number % 2) & 1) + binaryNumber;
            number >>= 1;
            //if (i % 4 == 0) binary = " " + binary;    // for better print
        }
        return binaryNumber;
    }
}
*/