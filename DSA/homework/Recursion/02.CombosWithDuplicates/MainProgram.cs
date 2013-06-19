
namespace _02.CombosWithDuplicates
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            int n = 3;
            int k = 2;
            int[] taken = new int[k];
            RecursiveLoop(1, 1, n, k, taken);

        }

        static void RecursiveLoop(int i, int after, int limit, int kElements, int[] taken)
        {
            if (i > kElements)
            {
                return;
            }

            for (int j = after; j <= limit; j++)
            {
                taken[i - 1] = j;
                if (i == kElements)
                {
                    Print(i, taken);
                }
                RecursiveLoop(i + 1, j, limit, kElements, taken);
            }
        }

        static void Print(int i, int[] taken)
        {
            for (int l = 0; l < i; l++)
            {
                Console.Write("{0} ", taken[l]);
            }
            Console.WriteLine();
        }
    }
}
