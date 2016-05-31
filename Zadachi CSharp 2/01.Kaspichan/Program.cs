using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Kaspichan
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            List<string> digits = new List<string>();
            for (char i='A' ; i<='Z'; i++)
            {
                digits.Add(i.ToString());
            }

            for (int i = 'a'; i <= 'i'; i++)
            {
                for (int j = 'A'; j <= 'Z' ; j++)
                {
                    digits.Add(i.ToString() + j.ToString());
                }
            }
            string result = "";
            if (n == 0)
            {
                Console.WriteLine("A");
            }
            while (n !=0)
            {
                result = digits[(int)(n % 256)] + result;
                n = n / 256;
            }
            Console.WriteLine(result);
        }
    }
}
