using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._20CharsMaxString
{
    class CorrectString
    {
        static void Main()
        {
            Console.WriteLine("Enter (20 chars max) string:");
            string str = Console.ReadLine();
            int len = str.Length;
            
            if ( len < 20)
            {
                int maxLen = 20 - len;
                StringBuilder sb = new StringBuilder();
                sb.Append(str);

                for (int i = 0; i < maxLen; i++)
                {
                    sb.Append('*');
                }
                Console.WriteLine(sb);
            }

        }
    }
}
