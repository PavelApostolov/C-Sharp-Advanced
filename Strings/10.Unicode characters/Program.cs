using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            answer.AppendFormat("\\u{0:X4}", (int)input[i]);
            //answer.Append(string.Format("\\u{0:X4}", (int)input[i]));
        }

        // other way
        //foreach (char character in input)
        //{
        //    answer.AppendFormat("\\u{0:X4}", (int)character);
        //}

        Console.WriteLine(answer.ToString());
    }
}