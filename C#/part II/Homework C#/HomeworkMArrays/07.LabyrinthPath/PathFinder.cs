using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LabyrinthPath
{
    class PathFinder
    {
        //not counting properly sequence length
        static int counter;
        static int row;
        static int col;

        static int [,] matrix = new int[5, 6]
        {
                {'1', '3', '2', '2', '2', '4'},
                {'3', '3', '3', '2', '4', '4'},
                {'4', '3', '1', '2', '3', '3'},
                {'4', '3', '1', '3', '3', '1'},
                {'4', '3', '3', '3', '1', '1'},
        };

        static void PrintMatrix()
        {
            for (int index = 0; index < matrix.GetLength(0); index++)
             {
                 for (int index2 = 0; index2 < matrix.GetLength(1); index2++)
                 {
                     Console.Write((char)matrix[index, index2]+ " ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();             
        }

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);

            bool colInRange = col >= 0 && col < matrix.GetLength(1);

            return rowInRange && colInRange;
        }         

        static void FindPathToExit(int row, int col)
        {           
            //check for out of range exception
            if (!InRange(row, col))
            {
                return;
            }            
            
            //check matrix[0, 0] as entry point 
            if (matrix[row, col] != matrix[row, col + 1] || matrix[row, col] != matrix[row + 1, col])
            {
                matrix[row, col] = matrix[row, col + 1];
            }

            //check for neighbour cells
            if (matrix[row, col] != matrix[row, col + 1] || matrix[row, col] != matrix[row + 1, col])
            {
                return; 
            }
                        
            //needed to determine and output the element's value
            matrix[row, col] = matrix[row, col] + 1;
            counter++;
            
            FindPathToExit(row, col - 1); // left

            FindPathToExit(row - 1, col); // up

            FindPathToExit(row, col + 1); // right

            FindPathToExit(row + 1, col); // down            
        }

        static void Main()
        {
            Console.WriteLine("This is the matrix: ");
            PrintMatrix();

            FindPathToExit(0, 0);

            Console.Write("Most frequent element: {0}, ", (char)(matrix[row, col] - 1));
            Console.WriteLine("repeated {0} times.", counter);
        }
        
    }
}
