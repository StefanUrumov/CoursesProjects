using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    class SomeApples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int x = 1;

            if (n <= y)
            {
                Console.WriteLine("-1"); 
            }
            else
            {
                for (int index = 1; index < n; index++)
                {
                    
                    if ((index + y) % k == 0)
                    {
                        Console.Write(index + " ");
                    }
                }
            }
            Console.WriteLine();







        }
    }
}
