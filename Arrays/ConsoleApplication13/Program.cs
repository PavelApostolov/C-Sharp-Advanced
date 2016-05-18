using System;

namespace _12_Index_Of_Letters
{
    class IndexOfLetters
    {
        static void Main()
        {
            //input
            string theWord = Console.ReadLine();

            //create the array
            char[] Alphabet = new char[26];

            for (int letter = 0; letter < Alphabet.Length; letter++)
            {
                Alphabet[letter] = (char)('a' + letter);
            }

            foreach (char letter in theWord)
            {
                Console.WriteLine(Array.IndexOf(Alphabet, letter));
            }
        }
    }
}

/*
 * using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] arr = new char[122 - 96];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)(97 + i);
        }
        string word = Console.ReadLine();
        foreach (var ch in word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
*/