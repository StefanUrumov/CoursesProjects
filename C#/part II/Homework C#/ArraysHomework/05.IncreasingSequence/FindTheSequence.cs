using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingSequence
{
    class FindTheSequence
    {
        static int[] array;      
        static int count;
        static int bestLen;
        static int start;

        static void Main()
        {
            array = new int[] { 3, 2, 3, 4, 2, 2, 4 };
            
            FindIncreasingNumbers();           

        }

        private static void FindIncreasingNumbers()
        {
            count = 1;
            bestLen = 0;
            start = 0;
            
            for (int index = 0; index < array.Length - 1; index++)
            {
                if (array[index] < array[index + 1])
                {
                    count++;
                }
                if (array[index] > array[index + 1])
                {
                    if (bestLen < count)
                    {
                        bestLen = count;
                        start = index - count + 1;
                    }
                    count = 1;
                }
            }

            PrintResult();            
        }

        private static void PrintResult()
        {
            Console.WriteLine("Best found increasing sequence is:");

            for (int index = start; index <= bestLen; index++)
            {
                Console.Write(array[index] + " ");
            }
            
            Console.WriteLine();
        }       
    }
}
