using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CheckFor7
{
    class CheckNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number and see if it's third digit (right-to-left) is 7:");
            int userInput = int.Parse(Console.ReadLine());

            int divideNumberBy100 = userInput / 100;
            int divideNumberBy10 = divideNumberBy100 % 10;

            bool thirdDigit = divideNumberBy10 == 7;
            Console.WriteLine("The digit is 7 -> {0}", thirdDigit);
        }
    }
}
