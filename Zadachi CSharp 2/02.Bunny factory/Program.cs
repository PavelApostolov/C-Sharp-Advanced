namespace BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class BF
    {
        static List<int> bunnyCages;
        static string result;

        static void Initialize()
        {
            ReadInput();
            result = string.Empty;
        }

        static void ReadInput()
        {
            bunnyCages = new List<int>();

            string currentCage = Console.ReadLine();

            while (currentCage != "END")
            {
                bunnyCages.Add(int.Parse(currentCage));
                currentCage = Console.ReadLine();
            }
        }

        static string CalculateSumOfNumbers(List<int> listOfNumbers)
        {
            BigInteger sum = 0;

            foreach (var number in listOfNumbers)
            {
                sum += number;
            }

            return sum.ToString();
        }

        static string CalculateProductOfNumbers(List<int> listOfNumbers)
        {
            BigInteger product = 1;

            foreach (var number in listOfNumbers)
            {
                product *= number;
            }

            return product.ToString();
        }

        static void Calculate()
        {
            int counter = 1;

            while (true)
            {
                if (!NextConversion(counter))
                {
                    break;
                }

                counter++;
            }
        }

        static bool NextConversion(int counter)
        {
            if (counter >= bunnyCages.Count)
            {
                return false;
            }

            int firstCage = 0;

            for (int i = 0; i < counter; i++)
            {
                firstCage += bunnyCages[i];
            }

            if (firstCage >= bunnyCages.Count)
            {
                return false;
            }

            List<int> bunniesToTransfer = new List<int>();

            for (int i = counter; i < counter + firstCage; i++)
            {
                bunniesToTransfer.Add(bunnyCages[i]);
            }

            string sum = CalculateSumOfNumbers(bunniesToTransfer);
            string product = CalculateProductOfNumbers(bunniesToTransfer);

            List<int> nextCages = new List<int>();
            foreach (var symbol in sum)
            {
                AddSymbol(nextCages, symbol);
            }

            foreach (var symbol in product)
            {
                AddSymbol(nextCages, symbol);
            }

            for (int i = counter + firstCage; i < bunnyCages.Count; i++)
            {
                foreach (var symbol in bunnyCages[i].ToString())
                {
                    AddSymbol(nextCages, symbol);
                }
            }

            bunnyCages = nextCages;
            return true;
        }

        static void AddSymbol(List<int> symbols, char symbol)
        {
            if (symbol != '0' && symbol != '1')
            {
                symbols.Add(symbol - '0');
            }
        }

        static void PrintResult()
        {
            result = string.Join(" ", bunnyCages);
            Console.WriteLine(result);
        }

        static void Main()
        {
            Initialize();
            Calculate();
            PrintResult();
        }
    }
}
/*
 * using System;
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
            string currentCage = Console.ReadLine();

            int[] cages = new int[205];
            int n = 0;

            while (currentCage != "END")
            {
                cages[n] = int.Parse(currentCage);
                n++;
                currentCage = Console.ReadLine();
            }

            for (int i = 1; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < i; j++)
                {
                    s += cages[j];
                }
                if (n - i < s)
                {
                    break;
                }
                
                int sum = 0;
                BigInteger product = 1;
                for (int j = i; j < i + s; j++)
                {
                    sum += cages[j];
                    product *= cages[j];
                }

                string next = sum.ToString() + product.ToString();
                for (int j = i + s; j < n; j++)
                {
                    next += cages[j].ToString();
                }

                next = next.Replace("0", "");
                next = next.Replace("1", "");

                n = next.Length;
                for (int j = 0; j < n; j++)
                {
                    cages[j] = next[j] - '0';
                }
            }
            
            //string[] end = new string[n];
            //for (int i = 0; i < n; i++)
			//{
			 //end[i] = cages[i].ToString();
			//}
            //Console.WriteLine(string.Join(" ", end, 0, n));
            Console.WriteLine(string.Join(" ", cages.Select(x => x.ToString()).ToArray(), 0, n));
        }
    }
}
 * */
