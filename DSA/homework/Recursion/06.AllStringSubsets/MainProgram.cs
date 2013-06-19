
namespace _06.AllStringSubsets
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            string[] strings = new string[] { "test", "rock", "fun" };
            string[] taken = new string[strings.Length];
            int k = 2;

            RecursiveLoop(1, 0, strings.Length, k, strings, taken);
        }

        static void RecursiveLoop(int i, int after, int limit, int kElements, string[] all, string[] taken)
        {
            if (i > kElements)
            {
                return;
            }

            for (int j = after; j < limit; j++)
            {
                taken[i - 1] = all[j];
                if (i == kElements)
                {
                    Print(i, taken);
                }
                RecursiveLoop(i + 1, j + 1, limit, kElements, all, taken);
            }
        }

        static void Print(int i, string[] taken)
        {
            for (int l = 0; l < i; l++)
            {
                Console.Write("{0} ", taken[l]);
            }
            Console.WriteLine();
        }
    }
}
