using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Divisors
{
    class Divide
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers (m n):");
            string line = Console.ReadLine();

            string[] words = line.Split(' ');
            
            int m = int.Parse(words[0].ToString());
            int n = int.Parse(words[1].ToString());

            int bigger = 0;
            if (m > n)
            {
                bigger = m;
            }
            else
            {
                bigger = n;
            }
            int i = 0;

            for (i = 2; i < bigger; i++)
            {                
                if (m % i == 0 && n % i == 0)
                {
                    if (m == i || n == i)
                    {                        
                         return;
                    }                   
                    Console.WriteLine(i);
                }
                if (m % i != 0 && n % i != 0) // inccorect output in some cases
                {
                    Console.WriteLine("-1");
                }
            }
            
        
        }
    }
}
