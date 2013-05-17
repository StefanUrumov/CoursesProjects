using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.WeAllLoveBits
{
    class LoveTheBits
    {
        static void Main()
        {
            ushort userInput = ushort.Parse(Console.ReadLine());

            int p = 0;
            int pReversed = 0;
            int pInversed = 0;
            int[] pNew = new int[userInput];

            for (int index = 0; index < userInput; index++)
            {
                p = int.Parse(Console.ReadLine());                 

                
                int nextNum = p;
                while (nextNum > 0)
                {
                    pReversed <<= 1;

                    if ((nextNum & 1) == 1)
                    {
                        pReversed |= 1;
                    }

                    nextNum >>= 1;
                }

                
                pInversed = p;
                int position = 0;
                int n = p;

                while (n >= 1)
                {
                    int mask = 1 << position;
                    int nAndMask = pInversed & mask;
                    pInversed = pInversed ^ mask;
                    position++;
                    n >>= 1;
                }
                pNew[index] = (p ^ pInversed) & pReversed; 
            }
            foreach (var num in pNew) 
            {
                Console.WriteLine(num);
            }


        }
    }
}
