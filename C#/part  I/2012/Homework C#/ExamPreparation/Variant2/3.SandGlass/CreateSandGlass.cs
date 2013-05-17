using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SandGlass
{
    class CreateSandGlass
    {
        static void Main()
        {            
            int N = int.Parse(Console.ReadLine());
            char element = '*';
                                    
            for (int top = 1; top <= N; top++) //print top
            {
                Console.Write(element);  
            }
            Console.WriteLine();
            for (int row = 1; row <= N; row++) //print body
            {
                if (row <= N / 2)
                {
                    for (int col = 1; col <= N; col++)
                    {
                        if (col <= N - (N - row) || col >= N - row + 1)
                        {
                            element = '.';
                            Console.Write(element);
                        }
                        else
                        {
                            element = '*';
                            Console.Write(element);
                        }
                    }
                    Console.WriteLine();
                }
                if(row > N/2 + 1)
                {
                    for (int col = 1; col <= N; col++)
                    {
                        if (col <= N - row || col >= N - (N - row) + 1)
                        {
                            element = '.';
                            Console.Write(element);
                        }
                        else
                        {
                            element = '*';
                            Console.Write(element);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();       

        }
    }
}
