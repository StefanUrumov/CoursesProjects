using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequencesInMatrix
{
    class FindSequences
    {
        //not working properly for right diagonal/last col and last row - need extra check
        //and finding only longest sequence - need extra check
        static string[,] matrix;
        static int rows;
        static int cols;

        static void Main()
        {
            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = int.Parse(Console.ReadLine());

            matrix = new string[rows, cols];

            CreateMatrix();
        }

        private static void CreateMatrix()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    string input = Console.ReadLine();
                    matrix[row, column] = input;
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

            FindLongestSquareSequence();
        }

        private static void FindLongestSquareSequence()
        {
            string bestElement = " ";
            int counter = 0;
            int bestLength = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (row != rows && col != cols)
                    {
                        if (matrix[row, col] == matrix[row, col + 1] || matrix[row, col] == matrix[row + 1, col] || matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            counter++;
                            bestElement = matrix[row, col];
                        }
                        if (counter > bestLength)
                        {
                            bestLength = counter;
                            matrix[row, col] = bestElement;
                        }
                        else
                        {
                            counter = 0;                            
                        }
                    }
                }
                Console.WriteLine("Best element found {0} with length {1}", bestElement, bestLength);
            }
        }        

    }
}
