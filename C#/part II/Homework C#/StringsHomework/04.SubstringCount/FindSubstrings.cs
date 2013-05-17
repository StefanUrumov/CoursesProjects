using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubstringCount
{
    class FindSubstrings
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("If this is our text:");
            Console.WriteLine(text);

            string textLower = text.ToLower();
            //Console.WriteLine(textLower);

            string word = "in";
                        
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (textLower.Substring(i, 2) == word)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        
        }

    }
}
