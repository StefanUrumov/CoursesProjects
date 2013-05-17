using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class FindLeap
    {
        static int year;

        static void Main()
        {
            Console.WriteLine("Enter a year to check if it is leap: ");
            year = int.Parse(Console.ReadLine());

            CheckLeapYear();
        }

        static void CheckLeapYear()
        {
            bool result = DateTime.IsLeapYear(year);

            if (result == true)
            {
                Console.WriteLine("The year {0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not a leap year!", year);
            }

        }
    }
}
