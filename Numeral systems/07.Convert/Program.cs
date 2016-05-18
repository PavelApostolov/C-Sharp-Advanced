using System;
using System.Text;
using System.Numerics;

namespace _07_One_Base_To_Any_2
{
    class AnyToAny2
    {

        static string HexKey = "0123456789ABCDEF";

        static void Main()
        {
            var fromBase = int.Parse(Console.ReadLine());
            var toConvert = Console.ReadLine();
            var toBase = int.Parse(Console.ReadLine());

            var toPrint = "";

            toPrint = AnyToDec(toConvert, fromBase);
            toPrint = DecToAny(toPrint, toBase);

            Console.WriteLine(toPrint);
        }

        static string AnyToDec(string toConvert, int fromBase)
        {
            BigInteger result = 0;

            foreach (var digit in toConvert)
            {
                result = (BigInteger)
                    (HexKey.IndexOf(digit.ToString()) + result * fromBase);
            }

            return result.ToString();
        }

        static string DecToAny(string toConvert, int toBase)
        {
            var result = new StringBuilder();

            var decNumber = BigInteger.Parse(toConvert);

            while (decNumber > 0)
            {
                var curDigit = decNumber % toBase;

                result.Insert(0, HexKey[(int)curDigit]);

                decNumber /= toBase;
            }

            return result.ToString();
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.SystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputBase = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToUpper();
            int outputBase = int.Parse(Console.ReadLine());
            Console.WriteLine(DecToAnything(ToDecimal(input, inputBase), outputBase));
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

        static string DecToAnything(BigInteger decValue, int outputBase)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % outputBase;
                result = intToHex[reminder] + result;
                decValue /= outputBase;
            } while (decValue > 0);

            return result;
        }

        public static Dictionary<BigInteger, char> intToHex = new Dictionary<BigInteger, char>()
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
*/