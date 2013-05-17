using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BiggetsOfThree
{
    class BiggetsOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter three  numbers and see the biggest of them:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine("The biggest number is {0}", firstNum);
            }
            if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine("The biggest number is {0}", secondNum);
            }
            if (thirdNum > secondNum && thirdNum > firstNum)
            {
                Console.WriteLine("The biggest number is {0}", thirdNum);
            }
        }
    }
}
