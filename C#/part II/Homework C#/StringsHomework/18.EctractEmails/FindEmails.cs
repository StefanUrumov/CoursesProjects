using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.EctractEmails
{
    class FindEmails
    {
        static void Main()
        {
            string text = @"Please contact us by phone (+359 222 222 222) or
                       by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk.
                       This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            string[] words = text.Split(' ');

            foreach (var word in words)
            {
               
                if (Regex.IsMatch(word, @"[\w.]{2,25}@[\w]{2,25}[.]{1}[\w.]{2,6}")) //от 2до 25 букви, цифри или подчертавка, следвани от кльомба,
                {                                                                  //следвани от 2-25 букви, цифри или подчертавка, следвани от една
                    Console.WriteLine("Valid email:");                               //точка, следвани от 2 до 6 букви, цифри или точка.
                    Console.WriteLine("- {0}", word);                                
                }
            }

        }
    }
}
