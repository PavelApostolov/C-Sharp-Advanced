
//
/* 1 12	11	10
* 2	13	16	9
* 3	14	15	8
* 4	5	6	7
*/

using System;



class PrintMatrixD
{
    static void Main()
    {

        Console.Write("Enter the lenght of matrix N: ");
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++) // get top rows and cols
        {
            for (int j = i; j < n - i; j++)
            {
                array[i, j] = number;
                number++;

            }

            for (int j = 0; j < n - 1 - i * 2; j++) // get right coloumns 
            {
                array[j + 1 + i, n - i - 1] = number;
                number++;
            }


            for (int j = 0; j < n - 1 - i * 2; j++) // get botom rows and cols
            {
                array[n - 1 - i, n - j - 2 - i] = number;
                number++;
            }


            for (int j = 0; j < n - 2 - i * 2; j++) //get left cols
            {
                array[n - j - 2 - i, i] = number;
                number++;
            }
        }


        for (int i = 0; i < n; i++) // print
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
