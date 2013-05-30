
namespace Task3
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
        }

        /*There is a bug in the code, if the matrix is non-quadratic, because the size checks are switched.
         * If rows > cols, then the first for loop,
         * else will be executed n-times and then recursion. Until row < rows the recursion will be called n-times.
         * The complexity is O(n^2).
         */
        long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
                sum += matrix[row, col];
            if (row + 1 < matrix.GetLength(1))
                sum += CalcSum(matrix, row + 1);
            return sum;
        }

    }
}
