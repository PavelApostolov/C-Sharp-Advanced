using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Zadachi_CSharp_2
{
    class Program
    {

        static void Main()
        {

            var alphabet = new List<string> { "CHU", "TEL", "OFT", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "YLO", "PLA" };
            var input = Console.ReadLine();

            long decimalRepresentation = 0;
            for (int i = 0; i < input.Length; i += 3)
            {
                var digitIn13 = input.Substring(i, 3);
                //Array.IndexOf
                var decValue = alphabet.IndexOf(digitIn13);

                decimalRepresentation *= 13;
                decimalRepresentation += decValue;
            }
            Console.WriteLine(decimalRepresentation);
        }
    }
}
