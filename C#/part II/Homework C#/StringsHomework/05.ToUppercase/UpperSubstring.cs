using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ToUppercase
{
    class UpperSubstring
    {
        static void Main()
        {
            string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            
            Console.WriteLine("Original string : \n {0}", text);

            ChangeToUpper(text);

        }

        private static string ChangeToUpper(string text)
        {
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < text.Length - 8; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    startIndex = i + 8;
                    i = startIndex;
                }
                if (text.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;
                    int length = endIndex - startIndex;
                    string upperStr = text.Substring(startIndex, length).ToUpper();
                    //Console.WriteLine(upperStr);
                    text = text.Remove(startIndex, length);
                    //Console.WriteLine(str);
                    text = text.Insert(startIndex, upperStr);
                    //Console.WriteLine(str);
                    text = text.Remove(startIndex - 8, 8);
                    text = text.Remove(endIndex - 8, 9);
                }
            }

            Console.WriteLine("Modified string : \n {0}", text);
            return text;
        }
    }
}
