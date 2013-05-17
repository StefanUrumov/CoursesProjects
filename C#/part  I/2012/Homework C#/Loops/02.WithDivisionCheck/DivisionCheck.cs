using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WithDivisionCheck
{
    class DivisionCheck
    {
        static void Main()
        {
            Console.Write("Insert a number bigger than 1: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers from 1 to {0} that are not divisible by 3 and 7 at the same time are:", userInput);
                        
            for (int index = 1; index <= userInput; index++)
            {
                if (index % 3 == 0 && index % 7 == 0)
                {
Console.WriteLine(index);
                    continue;
                }
                
            }

        }
    }
}
