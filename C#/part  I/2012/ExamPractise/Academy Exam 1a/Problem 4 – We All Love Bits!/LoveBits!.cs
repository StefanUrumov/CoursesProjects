using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___We_All_Love_Bits_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers you want to transform and then the numbers:");
            ushort userInput = ushort.Parse(Console.ReadLine());

            int p = 0;
            int pReversed = 0;
            int pInversed = 0;
            int [] pNew = new int [userInput];

            for (int index = 0; index < userInput; index++)
            {
                p = int.Parse(Console.ReadLine()); // read from the concole                

                // turn zeroes to ones and ones to zeroes
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
                
                // generate second number form userInput
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
                pNew[index] = (p ^ pInversed) & pReversed; // fill arrray with results
            }
            foreach (var num in pNew) //print new numbers
            {
                Console.WriteLine(num);
            }
        
        
        }
    }
}



/* solution
 using System;
02
 
03
class WeAllLoveBits
04
{
05
    static void Main()
06
    {
07
        // Read N
08
        int n = int.Parse(Console.ReadLine());
09
 
10
        // For all N numbers
11
        for (int i = 1; i < = n; i++)
12
        {
13
            // Read P
14
            int p = int.Parse(Console.ReadLine());
15
 
16
            // calculate pNew
17
            int pNew = 0;
18
            while (p > 0)
19
            {
20
                pNew < < = 1;
21
                if ((p & 1) == 1)
22
                {
23
                    pNew |= 1;
24
                }
25
                p > > = 1;
26
            }
27
 
28
            // Write pNew
29
            Console.WriteLine(pNew);
30
        }
31
    }
32
}

*/