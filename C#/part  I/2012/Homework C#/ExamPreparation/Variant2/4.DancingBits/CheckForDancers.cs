using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DancingBits
{
    class CheckForDancers
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            uint num;
            uint counter1 = 0;
            uint counter0 = 0;
            int counterFinal = 0;
            uint bit = 0;

            for (int count = 0; count < n; count++)
            {
                num = uint.Parse(Console.ReadLine());                
                bit = 0;
                int bitPosition = 0;
                uint bitStart = 0;
                for (int counterBit = 0; counterBit < 32; counterBit++)
                {
                    bitStart = GetBitInPosition(counterBit, num);
                    if (bitStart == 1)
                    {
                        bitPosition = counterBit;
                        break;
                    }
                }
                for (int counter = bitPosition; counter < 32; counter++)
                {
                    bit = GetBitInPosition(counter, num);
                    if (bit == 1)
                    {
                        counter1++;
                        if (counter0 == k)
                        {
                            counterFinal++;
                        }
                        counter0 = 0;
                    }
                    else
                    {
                        counter0++;
                        if (counter1 == k)
                        {
                            counterFinal++;
                        }
                        counter1 = 0;
                    }
                }
            }            
            if (bit == 1)
            {
                if (counter1 == k)
                {
                    counterFinal++;
                }
            }
            else
            {
                if (counter0 == k)
                {
                    counterFinal++;
                }
            }
            Console.WriteLine(counterFinal);
        }

        private static uint GetBitInPosition(int bitPosition, uint number)
        {
            uint bit = 0;
            uint mask = 2147483648;
            mask = mask >> bitPosition;
            uint nAndMask = number & mask;
            if (nAndMask == mask)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
