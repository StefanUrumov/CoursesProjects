using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.IncreasingOrderSorter
{
    class FindIncreasingOrder
    {
        static void Main()
        {
            int[] array = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5};

            Console.WriteLine("The original order of the array is:");

            foreach (var nums in array)
            {
                Console.Write("{0} ", nums);
            }

            int arrayLength = array.Length;

            int[] lengthOfLNDSEndingAt = new int[arrayLength];
            int[] previous = new int[arrayLength];
            int lengthOfLNDS = 0;
            int endOfLNDS = -1;

            for (int i = 0; i < arrayLength; i++)
            {
                int lengthOfPrecedingLNDS = 0;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] <= array[i])
                    {
                        if (lengthOfPrecedingLNDS < lengthOfLNDSEndingAt[j])
                        {
                            lengthOfPrecedingLNDS = lengthOfLNDSEndingAt[j];
                            previous[i] = j;
                        }
                    }
                }

                lengthOfLNDSEndingAt[i] = lengthOfPrecedingLNDS + 1;
                
                if (lengthOfLNDSEndingAt[i] > lengthOfLNDS)
                {
                    lengthOfLNDS = lengthOfLNDSEndingAt[i];
                    endOfLNDS = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("New sequence of the array in increasing order:");

            int[] longestNDS = new int[lengthOfLNDS];
            int lastElement = endOfLNDS;
            for (int index = lengthOfLNDS - 1; lastElement > -1; index--)
            {
                longestNDS[index] = array[lastElement];
                lastElement = previous[lastElement];
            }

            for (int i = 0; i < lengthOfLNDS; i++)
            {
                Console.Write(longestNDS[i] + " ");
            }

            Console.WriteLine();
        
        }
    }
}
