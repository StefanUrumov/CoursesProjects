using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_29._10._12
{
    class TwoIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter two intgers to be compared:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine("The bigger number is {0}!", firstNum);
            }
            else
            {
                Console.WriteLine("The bigger number is {0}!", secondNum);
            }
            }
    }
}
