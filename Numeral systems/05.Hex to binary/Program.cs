using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            Console.WriteLine(DecimaToAnything(ToDecimal(hexValue, 16), 2));
        }

        static string DecimaToAnything(BigInteger decValue, int baseValue)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % baseValue;
                result = reminder + result;
                decValue /= baseValue;
            } while (decValue > 0);
            return result;
        }
        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = hexValues[item] + sum * inputNumSystem;
            }
            return sum;
        }

        public static Dictionary<char, BigInteger> hexValues = new Dictionary<char, BigInteger>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        public static Dictionary<char, string> HexToBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }
        };

        public static Dictionary<string, char> BinaryToHexTable = new Dictionary<string, char>()
        {
            {"0000", '0' },
            {"0001", '1' },
            {"0010", '2' },
            {"0011", '3' },
            {"0100", '4' },
            {"0101", '5' },
            {"0110", '6' },
            {"0111", '7' },
            {"1000", '8' },
            {"1001", '9' },
            {"1010", 'A' },
            {"1011", 'B' },
            {"1100", 'C' },
            {"1101", 'D' },
            {"1110", 'E' },
            {"1111", 'F' }
        };
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            Console.WriteLine(HexadecimalToBinary(hexNumber));
        }

        private static string HexadecimalToBinary(string hexNumber)
        {
            StringBuilder decimalRepresentation = new StringBuilder();

            foreach (var digit in hexNumber)
            {
                decimalRepresentation.Append(HexToBinaryTable[digit]);
            }

            return (decimalRepresentation.ToString().Substring(decimalRepresentation.ToString().IndexOf('1'), decimalRepresentation.ToString().Length - decimalRepresentation.ToString().IndexOf('1')));
        }
    }
}
 * 
 * using System;

namespace _05_Hexadecimal_To_Binary
{
    class HexToBin
    {
        static void Main()
        {
            // input
            string HexNumber = Console.ReadLine();

            // variables 
            string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            string BinNumber = "";
            string tempBinNumb = "";

            int toBase = 2;

            for (int curIndex = HexNumber.Length - 1;
                     curIndex >= 0; curIndex--)
            {
                var curDigit = Array.IndexOf(HexKey, HexNumber[curIndex].ToString());

                while (curDigit > 0)
                {
                    tempBinNumb = (curDigit % toBase).ToString() + tempBinNumb;

                    curDigit /= toBase;
                }

                tempBinNumb = tempBinNumb.PadLeft(4, '0');

                BinNumber = tempBinNumb + BinNumber;

                tempBinNumb = "";
            }

            // Print
            Console.WriteLine(BinNumber.TrimStart('0'));
        }
    }
}
*/