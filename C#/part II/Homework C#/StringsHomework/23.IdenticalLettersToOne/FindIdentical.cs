using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.IdenticalLettersToOne
{
    class FindIdentical
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    sb.Append(text[i]);
                }               
            }
            //need  extra check for the last chars
            if (text[text.Length - 1 ] == text[text.Length - 2])
            {
                sb.Append(text[text.Length - 1 ]);
            }
            Console.WriteLine(sb);
        }
    }
}
