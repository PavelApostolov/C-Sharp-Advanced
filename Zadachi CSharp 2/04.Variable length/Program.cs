using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Length_Decoder
{
    class Decoder
    {
        static void Main(string[] args)
        {
            //using (StreamReader reader = new StreamReader("input.txt"))
            //{
            //string firstLine = reader.ReadLine();
            string encodedText = Console.ReadLine();

            string[] encodedStrings = encodedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            byte[] encodedNumbers = new byte[encodedStrings.Length];

            for (int i = 0; i < encodedNumbers.Length; i++)
            {
                encodedNumbers[i] = byte.Parse(encodedStrings[i]);
            }

            StringBuilder binaryEncodedText = new StringBuilder();

            foreach (var number in encodedNumbers)
            {
                binaryEncodedText.Append(
                    Convert.ToString(number, 2).PadLeft(8, '0')
                    );
            }

            string[] encodedSymbols = binaryEncodedText.ToString().Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

            //int codeTableSize = int.Parse(reader.ReadLine());
            int codeTableSize = int.Parse(Console.ReadLine());

            char[] symbolPerCodeLength = new char[codeTableSize + 1];
            for (int i = 0; i < codeTableSize; i++)
            {
                //string currentCodePair = reader.ReadLine();
                string currentCodePair = Console.ReadLine();
                char symbol = currentCodePair[0];
                int codeLength = int.Parse(currentCodePair.Substring(1));

                symbolPerCodeLength[codeLength] = symbol;
            }

            for (int i = 0; i < encodedSymbols.Length; i++)
            {
                var codedSymbol = encodedSymbols[i];
                Console.Write(symbolPerCodeLength[codedSymbol.Length]);
            }

            Console.WriteLine();
            //}
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Zadachi_CSharp_2
{
    class Program
    {

        static void Main()
        {
            
            var numbersAsStrings = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            
            StringBuilder encodedString = new StringBuilder();

            foreach (var str in numbersAsStrings)
	{
		 var num = int.Parse(str);
         encodedString.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
	}
            int n = int.Parse(Console.ReadLine());
            char[] dictionary = new char[n + 1];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                char symbol = line[0];
                int index = int.Parse(line.Substring(1));
                dictionary[index] = symbol;
            }
            StringBuilder decoded = new StringBuilder();
            int ones = 0;
            foreach (var ch in encodedString.ToString())
            {
                if (ch=='1')
                {
                    ones++;
                }
                else
                {
                    decoded.Append(dictionary[ones]);
                    ones = 0;
                }
            }
            Console.WriteLine(encodedString);
        }
    }
}
 * */

