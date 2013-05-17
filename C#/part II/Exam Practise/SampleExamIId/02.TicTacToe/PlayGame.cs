using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TicTacToe
{
    class PlayGame
    {
        static void Main()
        {
            string fiLine = Console.ReadLine();
            string seLine = Console.ReadLine();
            string thLine = Console.ReadLine();
 
            char[,] grid = new char[3,3] {
                {fiLine[0],fiLine[1],fiLine[2]},
                {seLine[0],seLine[1],seLine[2]},
                {thLine[0],thLine[1],thLine[2]}
            };

            //for (int row = 0; row < grid.GetLength(0); row++)
            //{
            //    for (int col = 0; col < grid.GetLength(1); col++)
            //    {
            //        //Console.Write(grid[row,col]);
            //        
            //        if (grid[row,col] == 'O')
            //        {
            //            grid[row, col] = '0'; //put zero so char.IsDigit() is true
            //        }
            //        GridFilling(grid);
            //    }
            //    //Console.WriteLine();
            //}

            GridFilling(grid);

        }

        private static void GridFilling(char[,] grid)
        {
            //check which player turn is next
            int XTurnCount = 0;
            int OTurnCount = 0;
            
            foreach (var move in grid)
            {
                if (move == 'X')
                {
                    XTurnCount++;
                }
                if (move == 'O')
                {
                    OTurnCount++;
                }
            }

            //using Random so each player can choose randem cell
            Random rand = new Random();

            //filling grid
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == '-') // maybe while()
                    {
                        //if (grid[rand.Next(1, 3), rand.Next(1, 3)] == '-' &&  XTurnCount <= OTurnCount)
                        //{
                        //    grid[row, col] = 'X';
                        //}
                        //if (grid[rand.Next(1, 3), rand.Next(1, 3)] == '-' && XTurnCount > OTurnCount)
                        //{
                        //    grid[row, col] = 'O'; //put 0
                        //}


                        if (XTurnCount <= OTurnCount)
                        {
                            grid[row, col] = 'X';
                        }
                        if (XTurnCount > OTurnCount)
                        {
                            grid[row, col] = 'O'; //put 0
                        }     
                    }                                   
                }
                //Console.WriteLine();
            }
            
            GridReady(grid);
            
        }

        private static void GridReady(char[,] grid)
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    Console.Write(grid[row,col]);   
                }
                Console.WriteLine();
            }
            CheckWinner(grid);
        }

        private static void CheckWinner(char[,] grid)
        {
            int XPlayer = 0;
            int OPlayer = 0;
            int evenGame = 0;

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if ( ((grid[0, 0] == 'X' && grid[0, 1] == 'X' && grid[0, 2] == 'X') || (grid[1, 0] == 'X' && grid[1, 1] == 'X' && grid[1, 2] == 'X') || (grid[2, 0] == 'X' && grid[2, 1] == 'X' && grid[2, 2] == 'X')) || ((grid[0, 0] == 'X' && grid[1, 0] == 'X' && grid[2, 0] == 'X') || (grid[0, 1] == 'X' && grid[1, 1] == 'X' && grid[2, 1] == 'X') || (grid[0, 2] == 'X' && grid[1, 2] == 'X' && grid[2, 2] == 'X')) || ((grid[0, 0] == 'X' && grid[1, 1] == 'X' && grid[2, 2] == 'X') || (grid[0, 2] == 'X' && grid[1, 1] == 'X' && grid[2, 0] == 'X')))
                    {
                        XPlayer++;
                    } 
                    //rows ((grid[0, 0] == 'X' && grid[0, 1] == 'X' && grid[0, 2] == 'X') || (grid[1, 0] == 'X' && grid[1, 1] == 'X' && grid[1, 2] == 'X') || (grid[2, 0] == 'X' && grid[2, 1] == 'X' && grid[2, 2] == 'X'))
                    //cols  ((grid[0, 0] == 'X' && grid[1, 0] == 'X' && grid[2, 0] == 'X') || (grid[0, 1] == 'X' && grid[1, 1] == 'X' && grid[2, 1] == 'X') || (grid[0, 2] == 'X' && grid[1, 2] == 'X' && grid[2, 2] == 'X'))
                    //diag ((grid[0, 0] == 'X' && grid[1, 1] == 'X' && grid[2, 2] == 'X') || (grid[0, 2] == 'X' && grid[1, 1] == 'X' && grid[2, 0] == 'X'))
                    if (((grid[0, 0] == 'O' && grid[0, 1] == 'O' && grid[0, 2] == 'O') || (grid[1, 0] == 'O' && grid[1, 1] == 'O' && grid[1, 2] == 'X') || (grid[2, 0] == 'O' && grid[2, 1] == 'O' && grid[2, 2] == 'O')) || ((grid[0, 0] == 'O' && grid[1, 0] == 'O' && grid[2, 0] == 'O') || (grid[0, 1] == 'O' && grid[1, 1] == 'O' && grid[2, 1] == 'O') || (grid[0, 2] == 'O' && grid[1, 2] == 'O' && grid[2, 2] == 'O')) || ((grid[0, 0] == 'O' && grid[1, 1] == 'O' && grid[2, 2] == 'O') || (grid[0, 2] == 'O' && grid[1, 1] == 'O' && grid[2, 0] == 'O')))
                    {
                        OPlayer++;
                    }
                    else
                    {
                        evenGame++;
                    }
                }                
            }

            Console.WriteLine(XPlayer);
            Console.WriteLine(OPlayer);
            Console.WriteLine(evenGame);
        }




    }
}
