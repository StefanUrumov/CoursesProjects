using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class DoReverse
    {
        static void Main()
        {
            string sample = "sample";
            string reversed = ReverseText(sample);
            Console.WriteLine(reversed);
        }

        public static string ReverseText(string intro)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = intro.Length - 1; i >= 0; i--)
            {
                sb.Append(intro[i]);
            }
            return sb.ToString();

        }
    }
}
