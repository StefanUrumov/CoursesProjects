using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _25.ExtractFromHTML
{
    class FindAndExtract
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../html.txt");

            using (reader)
            {
                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    MatchCollection matchText = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                    foreach (var item in matchText)
                    {
                        Console.WriteLine(  item);
                    }
                }
            }
        }
    }
}
