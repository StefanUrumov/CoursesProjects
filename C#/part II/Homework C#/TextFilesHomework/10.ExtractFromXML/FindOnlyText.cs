using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
 

namespace _10.ExtractFromXML
{
    class FindOnlyText
    {
        static void Main()
        {
            string htmlCode = "../../test.txt";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("http://www.dotnetperls.com/",htmlCode);
                //htmlCode = client.DownloadString("http://www.dotnetperls.com/"); //only show code as string into console
            }
            
            //Console.WriteLine("The full html code from dotnetperls.com: ");
            //Console.WriteLine(htmlCode);

            ShowNoTags(htmlCode);
        }

        private static void ShowNoTags(string htmlCode)
        {
            Console.WriteLine("Only text (without tags or new lines).");
            StreamReader reader = new StreamReader(htmlCode);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string pattern = ">[^<]*</";
                    string edited;
                    int length;
                    foreach (Match match in Regex.Matches(line, pattern))
                    {
                        edited = match.Value.ToString();
                        length = edited.Length;
                        edited = edited.Remove(length - 2, 2); //remove </
                        edited = edited.Remove(0, 1); //remove >
                        if (edited != null)
                        {
                            Console.WriteLine(edited);
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine();
        }
    }
}
