using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = new int[2];

            arrays = Console.ReadLine()
                   .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(item => int.Parse(item))
                   .ToArray();


            int[] numbers1 = new int[arrays[0]];

            numbers1 = Console.ReadLine()
                   .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(item => int.Parse(item))
                   .ToArray();

            int[] numbers2 = new int[arrays[1]];

            numbers2 = Console.ReadLine()
                   .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(item => int.Parse(item))
                   .ToArray();
            //--------------------------------------

            int finalScore = GetFinalScore(numbers1, numbers2);
            Result(finalScore);
        }

        private static void Result(int finalScore)
        {
            int[] result = finalScore.ToString().ToCharArray().
                            Select(x => (int)Char.GetNumericValue(x)).ToArray();

            Array.Reverse(result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

        private static int GetFinalScore(int[] numbers1, int[] numbers2)
        {
            Array.Reverse(numbers1);
            Array.Reverse(numbers2);

            int finalScore = 0;


            for (int i = 0; i < numbers1.Length; i++)
            {
                finalScore += numbers1[i] * Convert.ToInt32(Math.Pow(10, numbers1.Length - i - 1));
            }


            for (int i = 0; i < numbers2.Length; i++)
            {
                finalScore += numbers2[i] * Convert.ToInt32(Math.Pow(10, numbers2.Length - i - 1));
            }

            return finalScore;
        }
    }
}