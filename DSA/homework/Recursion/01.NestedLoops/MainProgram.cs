
namespace _01.NestedLoops
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            const int n = 3;
            int[] taken = new int[n];

            RecursiveLoop(0, n, taken);
        }

        static void RecursiveLoop(int i, int limit, int[] taken)
        {
            if (i >= limit)
            {
                Print(i, taken);
                return;
            }

            for (int j = 0; j < limit; j++)
            {
                taken[i] = j;
                RecursiveLoop(i + 1, limit, taken);
            }
        }

        static void Print(int i, int[] taken)
        {
            for (int l = 0; l < i; l++)
            {
                Console.Write("{0} ", taken[l] + 1);
            }
            Console.WriteLine();
        }
    }

}
