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
            var numeralSystem = 9;
            var digits = new[]{
        "LON+",
        "VK-", 
        "*ACAD",
        "^MIM", 
        "ERIK|", 
        "SEY&", 
        "EMY>>", 
        "/TEL",
        "<<DON"};

            ulong numberInDecimal = ulong.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            if (numberInDecimal == 0)
            {
                Console.WriteLine(digits[0]);
            }
            else
            {
                while (numberInDecimal > 0)
                {
                    int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem);
                    result.Insert(0, digits[digitIn9th]);
                    numberInDecimal /= (ulong)numeralSystem;
                }
                Console.WriteLine(result.ToString());
            }
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tres4 = { };
            ulong number = ulong.Parse(Console.ReadLine());
            int[] digits = new int[32];
            int digitCount = 0;

            do
            {
                digits[digitCount] = (int)(number % 9);
                number /= 9;
                digitCount++;
            } 
            while (number > 0);

            for (int i = digitCount - 1; i >= 0; i--)
            {
                Console.Write(tres4[digits[i]]);
            }
        }
    }
}

 * 
 * using System;
using System.Collections.Generic;

class TresFourNumbers
{
    const int TresNumFourDigitsCount = 9;

    static readonly string[] TresNumFourDigits = new string[TresNumFourDigitsCount]
    { 
        "LON+",
        "VK-", 
        "*ACAD",
        "^MIM", 
        "ERIK|", 
        "SEY&", 
        "EMY>>", 
        "/TEL",
        "<<DON"
    };

    static void Main()
    {
        Console.WriteLine(ConvertToTresNumFourNumber(ulong.Parse(Console.ReadLine())));
    }

    static string ConvertToTresNumFourNumber(ulong decimalNumber)
    {
        List<string> tresNumFourNumber = new List<string>();
        do
        {
            tresNumFourNumber.Add(TresNumFourDigits[decimalNumber % TresNumFourDigitsCount]);

            decimalNumber /= TresNumFourDigitsCount;
        }
        while (decimalNumber != 0);

        tresNumFourNumber.Reverse(); // Reversing the number to get the real value
        return string.Join(string.Empty, tresNumFourNumber);
    }
}
*/

