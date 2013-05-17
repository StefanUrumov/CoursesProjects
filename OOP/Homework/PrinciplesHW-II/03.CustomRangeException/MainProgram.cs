using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomRangeException
{
    class MainProgram
    {
        static void Main()
        {
            //int example
            Console.WriteLine("Enter a number between [1..100].");
            TryIntRange();

            //DateTime example
            Console.WriteLine("Enter date between [1.1.1980 … 31.12.2013]");
            TryDateRange();
        }

        private static void TryDateRange()
        {
            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);
            
            try
            {
                DateTime userDate = DateTime.Parse(Console.ReadLine());
                if (userDate < startDate || userDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date is not in range {0}...{1}", startDate, endDate);
                }
                else
                {
                    Console.WriteLine("Correct input!");
                }
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine("<!> InvalidRangeException catched:");
                Console.WriteLine("DateTime {0} is not in defined range of [{1}:{2}].",
                    ire.Start.ToShortDateString(), ire.End.ToShortDateString());
            }

           
        }

        private static void TryIntRange()
        {
            const int start = 0;
            const int end = 100;
            int userInput = byte.Parse(Console.ReadLine());;
            try
            {
                if (userInput < start || userInput > end)
	            {
                    throw new InvalidRangeException<int>("The number is not i range [{0}....{1}]}", start, end);   	 
	            }
                else
                {
                    Console.WriteLine("Correct input!");
                }
            }
            catch(InvalidRangeException<int> ire)
            {
                Console.WriteLine("InvalidRangeException!");
                Console.WriteLine("The number {0} is not i range [{1}....{2}]}", userInput, ire.Start, ire.End);
            }            
        }
    }
}
