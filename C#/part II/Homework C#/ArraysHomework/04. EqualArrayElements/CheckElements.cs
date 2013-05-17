using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EqualArrayElements
{
    class CheckElements
    {
        static void Main()
        {
            int[] array = new int[] { 2, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 1 };

            int count = 1;
            int bestLen = count;            
            int bestFound = array[0];
            

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

            Console.WriteLine("Max Sequence is: ");

            for (int i = 0; i < bestLen; i++)
			{
			    Console.Write("{0}, ", bestFound);
			}

            Console.WriteLine();
        }
    }
}
