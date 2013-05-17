using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ForestRoad
{
    class RoadInTheForest
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (col == row) //&& col <= N
                    {
                        Console.Write('*');
                    }                    
                    else
                    {
                        Console.Write('.');    
                    }
                    
                }
                Console.WriteLine();
            }

            for (int row = 1; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (col == (N - row) - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                    Console.Write('.');
                    }                    
                }
                Console.WriteLine();
            }

        }
    }
}
