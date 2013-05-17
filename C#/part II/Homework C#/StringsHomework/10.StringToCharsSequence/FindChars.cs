using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StringToCharsSequence
{
    class FindChars
    {
        static void Main()
        {
            string input = "Hi!";
            foreach (var ch in input)
            {
                Console.Write("\\u{0:X4}", (int)ch);
            }
            Console.WriteLine();
        }
    }
}
