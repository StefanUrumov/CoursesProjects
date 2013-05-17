using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ShowProductSign
{
    class ProductSign
    {
        static void Main()
        {
            Console.WriteLine("Enter three real numbers and see the sign of their product:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("The product of your numbers is 0!");
            }
            if ((firstNum < 0 &&  secondNum < 0 && thirdNum < 0) || (firstNum < 0 && secondNum > 0 && thirdNum > 0)
                || (firstNum > 0 && secondNum < 0 && thirdNum > 0) || (firstNum > 0 && secondNum > 0 && thirdNum < 0))
            {
                Console.WriteLine("The sign of the product is '-'!");
            }
            else
            {
                Console.WriteLine("The sign of the product is '+'!");
            }
            
        }
    }
}
