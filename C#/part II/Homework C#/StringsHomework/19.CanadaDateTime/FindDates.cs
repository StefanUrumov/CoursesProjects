using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using _16.FindTimeSpan;


namespace _19.CanadaDateTime
{
    class FindDates
    {
        static void Main()
        {
            string text = "World Clock Meeting Planner Find best time across Time 03.03.2013 Zones Need to make a call to someone far away or arrange a web 21.12.2012 or video conference across different 12.12.2012 time zones? Find the best time 28.01.2013 across time zones with this Meeting Planner.";

            string[] words = text.Split(' ');
            DateTime date;
                        
            foreach (var word in words)
            {
                FindDateSpan.ValidDate(word);

                if (FindDateSpan.ValidDate(word) == true)
                {
                    date = DateTime.ParseExact(word, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));                    
                }
            }
            
        }

    }
}
