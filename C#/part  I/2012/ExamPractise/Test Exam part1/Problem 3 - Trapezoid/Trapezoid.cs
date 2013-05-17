using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Trapezoid
{
    class Trapezoid
    {
        static int N;
        
        

        static void Main()
        {
            Console.WriteLine("Enter N [3..39], width of the smallest trapezoid side:");
            N = int.Parse(Console.ReadLine());
                      
            Console.WriteLine();
            

            PrintTop();
            PrintForm();

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
               

       static void PrintForm()
       {
           for (int row = 1; row <= N; row++)
           {
               Console.WriteLine();
               for (int col = 1; col <= N - row; col++)
               {
                   Console.Write(".");
                   if (col == N - row )
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

                       for (int i = col + 1; i <= N  + N - 2; i++)
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
           
           for (int index = 0; index < N * 2; index++) //print bottomside
           {
               Console.Write("*");
           }
       }
              
       static void PrintTop()
       {
           for (int index = 0; index < N; index++)
           {                
               Console.Write(".");
           }
           for (int index = N; index < N * 2; index++)
           {                
               Console.Write("*");
           }
       }
    }
}
