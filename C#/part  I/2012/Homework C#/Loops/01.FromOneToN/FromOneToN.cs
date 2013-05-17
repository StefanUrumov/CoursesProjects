using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FromOneToN
{
    class FromOneToN
    {
        static void Main()
        {
            Console.Write("Insert a number bigger than 1: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers from 1 to {0} are:", userInput);

            for (int index = 1; index <= userInput; index++)
            {
                Console.WriteLine(index);
            }
        
        
        }
    }
}
