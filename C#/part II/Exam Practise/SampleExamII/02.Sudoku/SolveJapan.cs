using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Sudoku
{
    class SolveJapan
    {
        static Random rand = new Random();
        
        static void Main()
        {
            int[,] sudoku = new int[4,4]; //must be 9
                        
            //fill matrix
            for (int row = 0; row < 4; row++)   //must be 9
            {
                string input = Console.ReadLine();

                for (int col = 0; col < 4; col++)   //must be 9
                {
                    if (input[col] == '-')
                    {
                        while (RepeatingInRowCol(sudoku, row, col))
                        {
                            sudoku[row, col] = rand.Next(0, 9);
                        }   
                     
                    }
                    else
                    {
                        sudoku[row, col] = int.Parse(input[col].ToString());
                    }                        
                }
            }

            Console.WriteLine();
            //print matrix
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int k = 0; k < sudoku.GetLength(1); k++)
                {
                    Console.Write(sudoku[i,k]);
                }
                Console.WriteLine();
            }
            
        }

        private static bool RepeatingInRowCol(int[,] sudoku, int row, int col)
        {
            for (int r = 0; r < sudoku.GetLength(0); r++)
            {
                for (int c = 0; c < sudoku.GetLength(1); c++)
                {
                    if ((sudoku[row, col] != sudoku[r, col] && col != c) && (sudoku[row, col] != sudoku[row, c] && row != r))
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
            
    }
}



//find numbers

//for (int r = 0; r < sudoku.GetLength(0); r++)
//{
//    for (int c = 0; c < sudoku.GetLength(1); c++)
//    {
//        if (sudoku[r,c] != 0)
//        {
//            //find next cell
//            if (c<2)    //must be 8
//            {
//               sudoku[r,c] = sudoku[r, c + 1];
//            }
//            else
//            {
//                if (r<2)
//                {
//                    sudoku[r,c] = sudoku[r + 1, 0];
//                }
//                
//            }  
//        }
//        else
//        {
//            sudoku[r, c] = rand.Next(0, 9);
//        }
//
//    }
//}
