using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TodayIs
{
    class FindToday
    {
        static void Main()
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;
            Console.WriteLine("Today is {0}!", today);
        }
    }
}
