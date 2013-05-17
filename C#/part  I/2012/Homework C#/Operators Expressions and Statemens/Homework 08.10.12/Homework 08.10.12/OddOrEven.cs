using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08._10._12
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Please enter a number to check is it odd or even: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 != 0)
            {
                Console.WriteLine("Your number is odd!");
            }
            else
            {
                Console.WriteLine("Your number is even!");
            }
        }
    }
}
