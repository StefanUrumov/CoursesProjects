using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatrixGrid
{
    class MatrixArray
    {
        static int[,] matrix; 
        static int rows;
        static int cols;

        static void Main()
        {
            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = int.Parse(Console.ReadLine());

            matrix = new int[rows, cols];

            Console.WriteLine("Select:");
            Console.WriteLine("- option a:");
            Console.WriteLine("- option b:");
            Console.WriteLine("- option c:");
            Console.WriteLine("- option d:");
            string userInput = Console.ReadLine();
            string selected = userInput.ToLower();

            Console.WriteLine("Your matrix: ");

            switch (selected)
            {
                case "a":
                    PrintA();break;
                case "b":
                    PrintB(); break;
                case "c":
                    PrintC(); break;
                case "d":
                    PrintD(); break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }
            
        }

        private static void PrintD()
        {
            Console.WriteLine("d)");

            int number = 1;
            int row = 0;
            int col = 0;
            matrix[0, 0] = 1;

            while (number < rows * cols)
            {
                for (row++; row < rows; row++)
                {
                    if (matrix[row, col] != 0)
                    {
                        break;
                    }
                    number++;
                    matrix[row, col] = number;
                }

                row--;
                
                for (col++; col < cols; col++)
                {
                    if (matrix[row, col] != 0)
                    {
                        break;
                    }
                    number++;
                    matrix[row, col] = number;
                }
                
                col--;
                
                for (row--; row >= 0; row--)
                {
                    if (matrix[row, col] != 0)
                    {
                        break;
                    }
                    number++;
                    matrix[row, col] = number;
                }

                row++;
                
                for (col--; col >= 0; col--)
                {
                    if (matrix[row, col] != 0)
                    {
                        break;
                    }
                    number++;
                    matrix[row, col] = number;
                }
                col++;
            }
            
            Console.WriteLine();
            
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();              
        }

        private static void PrintC()
        {
            Console.WriteLine("c)");

            int[,] mArray = new int[rows, cols];
           
            int counter = 1;
            mArray[rows - 1, 0] = counter;
            mArray[0, cols - 1] = rows * cols;
            counter++;

            for (int index = rows - 2; index >= 0; index--)
            {
                for (int row = 0; row <= cols - 1; row++)
                {
                    for (int col = rows - 1; col >= 0; col--)
                    {
                        if (row == col)
                        {
                            if (row - index < 0)
                            {
                                continue;
                            }
                            else
                            {
                                mArray[col, row - index] = counter;
                                counter++;
                            }

                        }
                    }
                }
            }

            counter = (rows * cols) - 1;

            for (int index = rows - 2; index > 0; index--)
            {
                for (int col = cols - 1; col > 0; col--)
                {
                    for (int row = 0; row <= rows - 1; row++)
                    {
                        if (row == col)
                        {
                            if (col - index < 0)
                            {
                                continue;
                            }
                            else
                            {
                                mArray[col - index, row] = counter;
                                counter--;
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < cols; l++)
                {
                    Console.Write("[{0:00}] ", mArray[k, l]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintB()
        {
            Console.WriteLine("b)");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = (row + 1) + (col * matrix.GetLength(0));
                        Console.Write("[{0, 1}]", matrix[row, col]);
                    }
                    else
                    {
                        matrix[row, col] = (col + 1) * matrix.GetLength(1) - row;
                        Console.Write("[{0, 1}]", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void PrintA()
        {
            Console.WriteLine("a)");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (row + 1) + (col * matrix.GetLength(0));
                    Console.Write("[{0, 1}]", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
