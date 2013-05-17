using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreatestCommonDivisor
{
    class GCD
    {
        
        static void Main()
        {
            Console.WriteLine("Enter an integer:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The Greatest Common Divisor is:");

            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum)
                {
                    firstNum %= secondNum; 
                }
                else
                {
                    secondNum %= firstNum; 
                }
            }

            if (firstNum == 0)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(firstNum);
            }
        }
                

    }
}
