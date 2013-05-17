using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Enter three  numbers and see the biggest of them:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int fifthNum = int.Parse(Console.ReadLine());

            if (firstNum != 0 && secondNum != 0 && thirdNum != 0 && fourthNum != 0 && fifthNum != 0)
            {
                Console.WriteLine("The biggest number is:");
                if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)
                {
                    Console.WriteLine(firstNum);
                }

                if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)
                {
                    Console.WriteLine(secondNum);
                }

                if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)
                {
                    Console.WriteLine(thirdNum);
                }
                if (fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum)
                {
                    Console.WriteLine(fourthNum);
                }
                if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > fourthNum)
                {
                    Console.WriteLine(fifthNum);
                }
            }
            else
            {
                Console.WriteLine("The numbers are equal!");
            }
        }
    }
}
