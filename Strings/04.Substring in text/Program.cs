using System;

class SubStringInText
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        int count = 0;
        int index = 0;

        while (true)
        {
            int foundIndex = text.IndexOf(word, index);
            if (foundIndex < 0)
            {
                break;
            }

            count++;
            index = foundIndex + 1;
        }

        Console.WriteLine(count);
    }
}