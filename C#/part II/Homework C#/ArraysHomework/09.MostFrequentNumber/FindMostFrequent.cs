using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class FindMostFrequent
    {
        static void Main()
        {
            int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

            int count = 1;
            int bestLen = count;
            int bestFound = array[0];

            Array.Sort(array);

            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] == array[index - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestLen)
                {
                    bestLen = count;
                    bestFound = array[index];
                }
            }

            Console.WriteLine("Most frequent number ->{0} ({1}times)", bestFound, bestLen);
            
        }
    }
}
