using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersUpToN
{
    class PrintNumbers
    {
        static int number;

        static void Main()
        {
            Console.WriteLine("Enter a positive integer number!");
            string line = Console.ReadLine();
            number = 0;

            if (int.TryParse(line, out number))
            {
                PrintSomeNumbers();
            }
            else{
            Console.WriteLine("Incorrect input!");
            }
            
        }

        static void PrintSomeNumbers()
        {
            if (number >= 1)
            {
                for (int index = 1; index <= number; index++)
                {
                    Console.WriteLine(index);
                }
            }
        }
        

    }
}
