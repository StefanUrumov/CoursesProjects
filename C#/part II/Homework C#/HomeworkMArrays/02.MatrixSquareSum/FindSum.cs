using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixSquareSum
{
    class FindSum
    {
        static int [,] matrix; 
        static int rows;
        static int cols;

        static void Main()
        {
            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = int.Parse(Console.ReadLine());

            matrix = new int[rows, cols];

            CreateMatrix();

        }

        private static void CreateMatrix()
        {
            String inputNumber;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    inputNumber = Console.ReadLine();
                    matrix[row, column] = int.Parse(inputNumber);
                }
            }

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            Console.WriteLine("Your matrix: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            FindBestSquareSum();
        }

        private static void FindBestSquareSum()
        {
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (row != rows - 2 && col != cols - 2)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                    }
                }
            }

            Console.WriteLine("Best found sum of 3x3 square: {0} ", bestSum);
 
        }
    }
}
