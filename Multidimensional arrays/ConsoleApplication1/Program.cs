using System;

class PrintingMatrix
{
    static void Main()
    {
        int[,] matrix = new int[4, 4];
        int number = 1;
        for (int col = 0; col < 4; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < 4; row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = 3; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                Console.Write("{0,2} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}