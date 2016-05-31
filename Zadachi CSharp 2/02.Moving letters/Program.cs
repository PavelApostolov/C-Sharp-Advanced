using System;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        // Read the words from the console
        string inputWords = Console.ReadLine();
        string[] words = inputWords.Split(' ');

        // Find the longest word
        int longestWord = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord)
            {
                longestWord = words[i].Length;
            }
        }

        // Extract the letters
        StringBuilder letters = new StringBuilder();
        for (int index = 0; index < longestWord; index++)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int currentLetterIndex = words[i].Length - 1 - index;
                if (currentLetterIndex >= 0)
                {
                    letters.Append(words[i][currentLetterIndex]);
                }
            }
        }

        // Move each letter to its new position
        for (int pos = 0; pos < letters.Length; pos++)
        {
            char letter = letters[pos];
            int positions = char.ToLower(letter) - 'a' + 1;
            MoveRight(letters, pos, positions);
        }

        Console.WriteLine(letters);
    }

    static void MoveRight(StringBuilder letters, int pos, int positions)
    {
        char letter = letters[pos];
        letters.Remove(pos, 1);
        int newPos = (pos + positions) % (letters.Length + 1);
        letters.Insert(newPos, letter);
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
            string[] words = Console.ReadLine().Split(' ');
            
            StringBuilder result = ExtractLetters(words);
            result = MoveLetters(result);
            
            Console.WriteLine(result.ToString());
	    }

        private static StringBuilder MoveLetters(StringBuilder builder)
        {
            
            for (int i = 0; i < builder.Length; i++)
            {
                char letter = builder[i];
                int indexInAlphabet = char.ToLower(letter) - 'a' + 1;
                MoveRight(builder, i, indexInAlphabet);
            }
            return builder;
        }

        private static void MoveRight(StringBuilder builder, int index, int count)
        {
            char letter = builder[index];
            int postion = index + count;
            postion %= builder.Length + 1;
            builder.Remove(index, 1);
            builder.Insert(postion, letter);
        }
        
        private static StringBuilder ExtractLetters(string[] words)
        {
            StringBuilder builder = new StringBuilder();
            
            int maxWordLength = words.Max(word => word.Length);
            for (int  i= 0;  i < maxWordLength; i++)
            {
                foreach (string word in words)
                {
                    int index = word.Length - i - 1;
                    bool condition = index >= 0;
                    if (condition)
                    {
                        builder.Append( word[index]);
                    }
                }
            }
            return builder;
        }
    }
}
 * */
