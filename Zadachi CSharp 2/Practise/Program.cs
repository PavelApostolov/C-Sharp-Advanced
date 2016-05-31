using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    var name = lines[i].Split(new[] {' ', '('}), StringSplitOptions.
                }

        }
    }
}
