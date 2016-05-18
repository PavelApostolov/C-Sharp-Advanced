using System;
using System.Linq;

class MatrixA
{
    static void Main()
    {

        int[,] matrix = new int[4, 4];

        for (int row = 0, count = 1; row < 4; row++)
            for (int col = 0; col < 4; col++)
                matrix[col, row] = count++;

        Console.WriteLine();
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
                Console.Write("{0,4} ", matrix[row, col]);
            Console.WriteLine("\n");
        }
    }
}