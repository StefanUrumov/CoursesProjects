using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int counter = 1;
            //top
            for (int i = 0; i < wide; i++)
            {
                if (i == wide / 2 - 1 || i == wide / 2)
                {
                    Console.Write('#');
                }
                else
                {
                     Console.Write('.');
                }
               
            }
            Console.WriteLine();

            counter += (wide / 2) - 2;
            //body
            for (int row = 0; row < (wide/2)-2; row++)
            {
                for (int dot = 0; dot < wide-1; dot++)
                {
                    if (dot == (wide / 2 - 2) - row || dot == (wide / 2 + 1) + row)
                    {
                        Console.Write('#');
                    }                    
                    else
                    {
                        Console.Write('.');
                    }
                    
                }
                Console.WriteLine('.');
            }
           
            //body-middle            
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < wide; i++)
                {
                    if (i == 0 || i == wide - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }          
            
            //counter/k must be defined acorrding to all rows needed for the fire
            counter += 2;

            
            //body-bottom
            for (int row = 1; row < (wide - (wide/4) + 1) - counter; row++)
            {
                for (int dot = 1; dot <= wide; dot++)
                {
                    if (dot == row + 1 || dot == wide - row)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

            //middle
            for (int i = 0; i < wide; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            //bottom
            for (int i = 0; i < wide / 2; i++)
            {
                for (int k = 1; k <= wide; k++)
                {
                    if (k <= i || k > wide - i)
                    {
                        Console.Write('.');
                    }
                    else if (k <= wide/2)
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write('/');
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
