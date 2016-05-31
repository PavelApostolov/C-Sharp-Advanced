using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        const int NUMBERALBASE = 168;
        StringBuilder input = new StringBuilder(Console.ReadLine());
        ulong result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            result *= NUMBERALBASE;

            if (Char.IsUpper(input[i]))
            {
                result += (uint)(input[i] - 'A');
            }
            else
            {
                result += (uint)(input[i] - ('a' - 1)) * 26;
                i += 1;
                result += (uint)(input[i] - 'A');
            }
        }

        Console.WriteLine(result);
    }
}
/*
using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        List<string> numbers = new List<string>();
        AddNumbersToList(numbers);

        string number = Console.ReadLine();

        ulong result = 0;

        while (number.Length > 0)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (number.StartsWith(numbers[i]))
                {
                    result = result * 168 + (ulong)i;
                    number = number.Remove(0, numbers[i].Length);
                }
            }
        }

        Console.WriteLine(result);
    }

    static void AddNumbersToList(List<string> digits)
    {
        for (char i = 'A'; i <= 'Z'; i++)
            digits.Add(i.ToString());

        for (char i = 'a'; i <= 'f'; i++)
            for (char j = 'A'; j <= 'Z'; j++)
                digits.Add(i.ToString() + j.ToString());
    }
}
*/