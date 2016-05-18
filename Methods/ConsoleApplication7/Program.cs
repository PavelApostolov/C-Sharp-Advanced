using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MethodReversesDigits
{
    class MethodReversesDigits
    {
        public static int ReverseNumber(int number)
        {
            int tempNumber = 0;
            while (number > 0)
            {
                tempNumber = (tempNumber * 10) + (number % 10);
                number /= 10;
            }
            return tempNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to reverse");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }
    }
}
