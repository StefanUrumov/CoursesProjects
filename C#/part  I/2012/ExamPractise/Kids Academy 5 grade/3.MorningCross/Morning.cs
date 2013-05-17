using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MorningCross
{
    class Morning
    {
        static void Main()
        {
            Console.WriteLine("Enter how many km you run first day: ");
            decimal x = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many km you want to run: ");
            decimal y = decimal.Parse(Console.ReadLine());

            byte days = 1;

            do
            {
                x += x / 10;
                days++;

                if (x == y)
                {
                    break;
                }

            } while (x <= y);

            //while (x <= y)
            //{
            //    x += (x / 10);
            //    days++;
            //
            //    if (x == y)
            //    {
            //        break; 
            //    }
            //}



            Console.WriteLine("You will be able to run {0}km after {1} days.", y, days);
        }
    }
}
