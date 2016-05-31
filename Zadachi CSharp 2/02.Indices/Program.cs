using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int[] arrayOfNumber = new int[n];
            bool[] visited = new bool[n];

            for (int i = 0; i < array.Length; i++)
            {
                arrayOfNumber[i] = int.Parse(array[i]);
            }
            StringBuilder result = new StringBuilder();
            
            int currentIndex = 0;
            int loopStart = -1;
            while (true)
            {
                if (currentIndex < 0 || currentIndex >= n)
                {
                    break;
                }

                if (visited[currentIndex])
                {
                    loopStart = currentIndex;
                    break;
                }

                result.Append(currentIndex);
                result.Append(' ');
                visited[currentIndex] = true;
                currentIndex = arrayOfNumber[currentIndex];
            }

            if (loopStart>=0)
            {
                int index = result.ToString().IndexOf(( " " + loopStart + " ").ToString());
                if (index <0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    result[index] = '(';
                }
                
                result[result.Length - 1] = ')';
            }
            Console.WriteLine(result.ToString().Trim());
            
        }
    }
}
