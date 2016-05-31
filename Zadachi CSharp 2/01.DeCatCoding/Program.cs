using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DeCatCoding
{
    class Program
    {
        static ulong CatToDec(string catNumber)
        {
            ulong result = 0;
            foreach (char digit in catNumber)
            {
                result = (ulong)(digit - 'a') + result * 21;
            }
            return result;
        }

        static string DecTo26(ulong dec)
        {
            var result = string.Empty;

            do
            {
                char digitValue = (char)('a' + (dec % 26));
                result = digitValue + result;
                dec /= 26;
            } while (dec > 0);

            return result;
        }


        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(CatToDec).Select(DecTo26).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
 
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        public static long ConvertToDecimal(string text)
        {
            long output = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int digit = text[text.Length - 1 -i] - 'a';

                long poweredDigit = PowerOf21(digit, i) * digit;

                output += poweredDigit;
            }
            

            return output;
        }

        public static long PowerOf21(int digit, int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 21;
            }

            return result;
        }


        public static string ConvertToAlphabet(long numberInDecimal)
        {
            StringBuilder outputAlphabet = new StringBuilder();
            
            while (numberInDecimal > 0)
            {
                char symbolToAppend = (char)(numberInDecimal % 26 + 'a');
                numberInDecimal /= 26;

                outputAlphabet.Insert(0, symbolToAppend);
            }

            return outputAlphabet.ToString();
            
        }


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
              output[i]=ConvertToAlphabet(ConvertToDecimal(input[i]));
            }


            Console.WriteLine(string.Join(" ", output));
        }
    }
}
 */
