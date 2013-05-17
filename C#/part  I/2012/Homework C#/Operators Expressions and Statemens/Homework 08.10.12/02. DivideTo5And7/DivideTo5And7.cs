using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DivideTo5And7
{
    class DivideTo5And7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number and see if it can be divided by 5 and 7 in the same time:");
            int userInput = int.Parse(Console.ReadLine());

            bool result = userInput % 35 == 0;

            Console.WriteLine(result);
        }


    }
}
