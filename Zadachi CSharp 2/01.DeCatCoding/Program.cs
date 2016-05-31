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
