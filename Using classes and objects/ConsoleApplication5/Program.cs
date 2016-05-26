using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ReadesValuesAndCalcsSum
{
    class ReadesValuesAndCalcsSum
    {
        static void Main()
        {
            string input = "43 68 9 23 318";
            string[] numbers = input.Split(' ');
            int sum = 0;
            foreach (string p in numbers)
            {
                sum += int.Parse(p);
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}