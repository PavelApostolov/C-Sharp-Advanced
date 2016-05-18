using System;
using System.Collections.Generic;
using System.Linq;


namespace ReverseNumber07
{
    class Program
    {
        static void Reverse(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Reverse(Console.ReadLine());
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumber
{
    class ReverseNum
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            ReverseDigits(input);
        }

        private static void ReverseDigits(decimal input)
        {
            string inputAsStr = input.ToString();

            string output = string.Empty;

            for (int i = inputAsStr.Length - 1; i >= 0; i--)
            {
                output += inputAsStr[i];
            }

            //or second way convert to char array
            //char[] charArr = inputAsStr.ToCharArray();
            //Array.Reverse(charArr);

            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    output += charArr[i];
            //}

            Console.WriteLine(output);
        }
    }
}
*/