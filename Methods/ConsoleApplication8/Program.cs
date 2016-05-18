using System;
using System.Linq;

class ReverseDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal number = Int32.Parse(Console.ReadLine());
        Console.Write("Reversed: ");
        decimal reversed = ReverseDecimal(number);
        Console.WriteLine(reversed);
    }

    static decimal ReverseDecimal(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}
