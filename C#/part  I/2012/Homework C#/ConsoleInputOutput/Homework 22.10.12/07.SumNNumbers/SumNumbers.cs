using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumNNumbers
{
    class SumNumbers
    {
        static void Main()
        {            
            int number = 0;

            while (true)
            {
                Console.WriteLine("Enter next number!");
                int nextNum = int.Parse(Console.ReadLine());

                number += nextNum;
                Console.WriteLine("The sum of all your numbers at this stage is: {0}", number);
            }               

        }
    }
}
