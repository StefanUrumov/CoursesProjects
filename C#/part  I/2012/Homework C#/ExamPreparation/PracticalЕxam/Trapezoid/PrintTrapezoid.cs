using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class PrintTrapezoid
    {
        static int N; 

        static void Main()
        {            
            N = int.Parse(Console.ReadLine());
           
            //print top
            for (int index = 0; index < N*2; index++)
            {
                if (index >= N && index < N * 2)
                {
                    Console.Write('*');
                }
                else
                {
                   Console.Write(".");     
                }                
            }


            for (int row = 1; row <= N; row++)
            {
                Console.WriteLine();
                for (int col = 1; col <= N - row; col++)
                {
                    Console.Write(".");
                    if (col == N - row)
                    {
                        Console.Write("*");

                        //do
                        //{
                        //    Console.Write(".");
                        //    col++;
                        //} while (col == N + 5);

                        while (col == N - row)
                        {
                            Console.Write(".");
                            col++;
                        }

                        for (int i = col + 1; i <= N + N - 2; i++)
                        {
                            Console.Write(".");

                            if (i == N + N - 2)
                            {
                                Console.Write("*");
                            }
                            //while(i >= N + N - 2)
                            //{
                            //    Console.Write(" ");
                            //    break;
                            //}                           
                        }


                    }

                }
            }
            
            //print bottomside
            for (int index = 0; index < N * 2; index++) 
            {
                Console.Write("*");
            }

            Console.WriteLine();
        

     }
   }
}

