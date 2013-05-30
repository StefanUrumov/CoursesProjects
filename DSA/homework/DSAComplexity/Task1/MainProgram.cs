
namespace Task1
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main(string[] args)
        {
        }

        /*
         * The outer for loop is executed n times, on every iteration the inner while loop is executed again n times
         * every time start-end difference is -1 until is  equal to 0.
         * So the comlexity is 0(n*n)
         */

        long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
                while (start < end)
                    if (arr[start] < arr[end])
                    { start++; count++; }
                    else
                        end--;
            }
            return count;
        }
    }
}
