using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IntegerSum
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of your numbers is: {0}", firstNum + secondNum + thirdNum);
        }
    }
}
