using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.Add6H30M
{
    class AddMoreTime
    {
        static void Main()
        {
            Console.WriteLine("Enter date (date.month.year hour:minute:second):");
            string date = Console.ReadLine();

            DateTime dt = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            dt = dt.AddHours(6.5);

            Console.WriteLine("{0} {1}", dt.ToString("dddd", new CultureInfo("bg-BG")), dt); //dddd is day of week full name
    
        }
    }
}
