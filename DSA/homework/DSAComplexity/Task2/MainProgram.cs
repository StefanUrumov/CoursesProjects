
namespace Task2
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {

        }

        /*The outer for loop is executed n-times, but we enter the inner when the first row number is even (z-times),
         * If z is const, then О(n + m)
         * If z is n, then O(n*m)
         * The complexity is  O(n-z + z*m)
         */
        long CalcCount(int[,] matrix)
        {
            long count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
                if (matrix[row, 0] % 2 == 0)
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        if (matrix[row, col] > 0)
                            count++;
            return count;
        }

    }
}
