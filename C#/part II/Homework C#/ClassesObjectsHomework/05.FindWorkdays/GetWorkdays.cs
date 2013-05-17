using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FindWorkdays
{
    class GetWorkdays
    {
        static DateTime today;
        static DateTime userTime;
        static TimeSpan daysBetween;
        static int daysDiff;

        static List<DateTime> holidays = new List<DateTime>() {
            DateTime.Parse("01.01.2013"),
            DateTime.Parse("23.01.2013"),
            DateTime.Parse("24.01.2013"),            
            DateTime.Parse("03.03.2013"),
            DateTime.Parse("01.05.2013"),
            DateTime.Parse("02.05.2013"),            
            DateTime.Parse("06.05.2013"),
            DateTime.Parse("24.05.2013"),
            DateTime.Parse("22.09.2013"),            
            DateTime.Parse("24.12.2013"),
            DateTime.Parse("25.12.2013"),
            DateTime.Parse("26.12.2013"),
            DateTime.Parse("31.12.2013")                        
            };

        static void Main()
        {
            today = DateTime.Today;

            Console.WriteLine("If today is: {0}, \n enter the date that you want and see the workdays up to then!", DateTime.Today.Date);
            string dateString = Console.ReadLine();

            userTime = DateTime.Parse(dateString); // Converts the string of a date and time to its DateTime equivalent

            daysBetween = userTime - today;
            daysDiff = daysBetween.Days; // gets the days between into int

            Console.WriteLine("There are {0} days from today to {1}!", daysDiff, userTime);
            int workDays = 0;
            foreach (DateTime dateFinal in GetDateRange(today, userTime))
            {
                //Console.WriteLine(dateFinal.ToShortDateString());
                if ((dateFinal.DayOfWeek != DayOfWeek.Saturday) && (dateFinal.DayOfWeek != DayOfWeek.Sunday)) //&& (holidays.IndexOf(dateFinal) == -1)
                {                                                                                             //to compare with holidays
                    workDays++;
                }
            }

            Console.WriteLine("There are {0} workdays (counting today)!",workDays);
            
        }

        public static List<DateTime> GetDateRange(DateTime today, DateTime userTime)
        {
            if (today > userTime)
            {
                return null;
            }
            List<DateTime> rv = new List<DateTime>();
            DateTime tmpDate = today;
            do
            {
                rv.Add(tmpDate);
                tmpDate = tmpDate.AddDays(1);
            } while (tmpDate <= userTime);
            return rv;
        }
    
  
    }
}
