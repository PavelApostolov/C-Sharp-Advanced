using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IncreasingAbsoluteDifferences
{
    class Program
    {
        static void Main()
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long last = sequence[0];


                bool isIncreasing = true;
                for (int j = 2; j < sequence.Length; j++)
                {
                    var lastAbsDiff = Math.Abs(sequence[j-2] - sequence[j-1]);
                    var currentAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

                    if (lastAbsDiff > currentAbsDiff || currentAbsDiff - lastAbsDiff > 1)
                    {
                        isIncreasing = false;
                        break;
                    }
                    
                   
                }
                Console.WriteLine(isIncreasing);
            }
            
        }
    }
}
