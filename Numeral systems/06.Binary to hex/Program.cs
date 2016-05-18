using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHexaDecimal
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
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimal(binaryNumber));
        }

        private static string BinaryToHexadecimal(string number)
        {
            // Binary to decimal
            long numberInDecimal = Convert.ToInt64(number, 2);

            // Decimal to hex
            string numberInHex = Convert.ToString(numberInDecimal, 16);

            return numberInHex.ToUpper().TrimStart('0');
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.BinaryToHexadecimal
{
    class Program
    {
        static void Main()
        {
            string binValue = Console.ReadLine();
            Console.WriteLine(DecToAnything(ToDecimal(binValue, 2), 16));
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = (item - '0') + sum * inputNumSystem;
            }
            return sum;
        }

        static string DecToAnything(BigInteger decValue, int inputBase)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % inputBase;
                result = hexValues[reminder] + result;
                decValue /= inputBase;
            } while (decValue > 0);

            return result;
        }


        public static Dictionary<BigInteger, char> hexValues = new Dictionary<BigInteger, char>()
        {
            {0 , '0'},
            {1 , '1'},
            {2 , '2'},
            {3 , '3'},
            {4 , '4'},
            {5 , '5'},
            {6 , '6'},
            {7 , '7'},
            {8 , '8'},
            {9 , '9'},
            {10 , 'A'},
            {11 , 'B'},
            {12 , 'C'},
            {13 , 'D'},
            {14 , 'E'},
            {15 , 'F'},
        };
    }
}
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_systems
{
    class ConvertBinaryToHexidecimal
    {
        static void Main()
        {
            string binNum = Console.ReadLine();

            int strLength = binNum.Length;
            StringBuilder hexNum = new StringBuilder();

            for (int i = 0; i < strLength; i = i + 4)
            {
                switch (binNum.Substring(i, 4))
                {
                    case "1010": hexNum.Append("A"); break;
                    case "1011": hexNum.Append("B"); break;
                    case "1100": hexNum.Append("C"); break;
                    case "1101": hexNum.Append("D"); break;
                    case "1110": hexNum.Append("E"); break;
                    case "1111": hexNum.Append("F"); break;
                    case "0000": hexNum.Append("0"); break;
                    case "0001": hexNum.Append("1"); break;
                    case "0010": hexNum.Append("2"); break;
                    case "0011": hexNum.Append("3"); break;
                    case "0100": hexNum.Append("4"); break;
                    case "0101": hexNum.Append("5"); break;
                    case "0110": hexNum.Append("6"); break;
                    case "0111": hexNum.Append("7"); break;
                    case "1000": hexNum.Append("8"); break;
                    case "1001": hexNum.Append("9"); break;
                }
            }

            Console.WriteLine(hexNum);
        }
    }
}
*/