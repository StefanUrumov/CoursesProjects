using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _16.FindTimeSpan
{
    public class FindDateSpan
    {
        public static void Main()
        {
            Console.WriteLine("Enter first date (ex. 27.02.2006):");
            string firstDate = Console.ReadLine();

            Console.WriteLine("Enter second date:");
            string secondDate = Console.ReadLine();

            if (ValidDate(firstDate) == true && ValidDate(secondDate) == true)
            {
                DateTime fiDate = DateTime.Parse(firstDate);
                DateTime secDate = DateTime.Parse(secondDate);

                TimeSpan span = fiDate.Subtract(secDate);
                //Console.WriteLine(span);
                Console.WriteLine("{0} days", span.TotalDays);   
            }
            else
            {
                Console.WriteLine("Invalid DateTime input!");
            }
            
        }

        public static bool ValidDate(string data)
        {
            if (Regex.IsMatch(data, "[0-9]{1,2}[.][0-9]{2,}[.][0-9]{4,}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
