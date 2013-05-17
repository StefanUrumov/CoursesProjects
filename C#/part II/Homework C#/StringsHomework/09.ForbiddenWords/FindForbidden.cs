using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbiddenWords
{
    class FindForbidden
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";
            string[] forbiden = words.Split(',');

            for (int i = 0; i < forbiden.Length; i++)
            {
                forbiden[i] = forbiden[i].Trim();
                text = text.Replace(forbiden[i], new string('*', forbiden[i].Length));
            }

            Console.WriteLine(text);

        }
    }
}
