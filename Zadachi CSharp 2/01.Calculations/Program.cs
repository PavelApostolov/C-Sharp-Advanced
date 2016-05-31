using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadachi_CSharp_2
{
    class Program
    {
        static int MeoToDec(string meow)
        {
            int result = 0;
            foreach (char digit in meow)
            {
                result = (digit - 'a') + result * 23;
            }

            return result;
        }

        static string DecToMeow(int dec)
        {
            var result = string.Empty;

            do
            {
                char digit = (char)('a' + (dec % 23));
                result = digit + result;
                dec /= 23;
            } while (dec > 0);

            return result;
        }

        static void Main()
        {
            var sum = Console.ReadLine().Split(' ').Select(MeoToDec).Sum();
            var answer = DecToMeow(sum) + " = " + sum;
            Console.WriteLine(answer);
        }
    }
}


/*namespace CSharpExam
{
    using System;
    using System.IO;
    using System.Linq;

    public class CalculationProblem
    {
        public static void Main()
        {
            int numBase = 23;
            //new TestGenerator().GenerateTests(numBase);
            //return;

            string input = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] words = input.Split(' ').Take(numBase).ToArray();

            input = Console.ReadLine();
            words = input.Split(' ');
            int num = SumString(words, numBase);
            string res = ConvertNumberToString(num, numBase);
            Console.WriteLine("{0} = {1}", res, num);
        }

        private static int SumString(string[] words, int numBase)
        {
            int[] numbers = new int[words.Length];
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                numbers[i] = ConvertStringToNumber(words[i].ToLower(), numBase);
                //Console.WriteLine("{0} = {1}", ConvertNumberToString(numbers[i], numBase), numbers[i]);
                result += numbers[i];
            }
            return result;
        }

        private static int ConvertStringToNumber(string word, int numBase)
        {
            int num = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int digit = word[word.Length - 1 - i] - 'a';
                num += digit * (int)Math.Pow(numBase, i);
            }

            return num;
        }

        private static string ConvertNumberToString(int result, int numBase)
        {
            string resultStr = string.Empty;
            if (result == 0)
            {
                resultStr = "a";
            }

            while (result > 0)
            {
                char ch = (char)((result % numBase) + 'a');
                resultStr = ch.ToString() + resultStr;
                result /= numBase;
            }

            return resultStr;
        }
    }
}
 * */
