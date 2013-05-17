using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Dancing_Bits
{
    class DancingBits
    {
        static void Main()
        {
            Console.Write("Enter N:");
            ushort N = ushort.Parse(Console.ReadLine());

            Console.Write("Enter K:");
            ushort K = ushort.Parse(Console.ReadLine());
            string fullNumber = " ";

            for (int i = 1; i <= K; i++)
            {
                Console.WriteLine("enter number: ");
                int currentNum = int.Parse(Console.ReadLine());

                string currentNumStr = currentNum.ToString();
                string result = Convert.ToString(Convert.ToInt32(currentNumStr, 10), 2);
                //Console.WriteLine(result);
                fullNumber += result;
                //Console.WriteLine(fullNumber);
            }
            //Console.WriteLine(fullNumber);

            int counter = 0;
            char[] some = fullNumber.ToCharArray();
            for (int i = 0; i < some.Length; i++)
            {
                Console.WriteLine(some[i]);
                if (some[i] == some[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);


            //int counter = 0;
            //foreach (var item in fullNumber)
            //{
            //    Console.Write(item + " ");
            //
            //    
            //    if (item == item + 1)
            //    {
            //        Console.WriteLine('p');
            //    }
            //
            //    //if (fullNumber[item] == fullNumber[item + 1])
            //    //{
            //    //    counter++;
            //    //}
            //    //Console.WriteLine(counter);
            //}


        }
    }
}


/*
the solution useng bits
 * 
 * 
 *  static void Main()
        {
           int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            uint number;
            uint counter1 = 0;
            uint counter0 = 0;
            int counterResult = 0;
            uint bit = 0;
            for (int count = 0; count<n; count++)
            {
                number = uint.Parse(Console.ReadLine());
                //find first 1 bit position
                bit = 0;
                int bitPosition = 0;
                uint bitStart = 0;
                for (int counterBit = 0; counterBit < 32; counterBit++)
                {
                    bitStart = GetBitInPosition(counterBit, number);
                    if (bitStart == 1)
                    {
                        bitPosition = counterBit;
                        break;
                    }
                }
                for (int counter = bitPosition; counter < 32; counter++)
                {
                    bit = GetBitInPosition(counter, number);
                    if (bit == 1)
                    {
                        counter1++;
                        if (counter0==k)
                        {
                            counterResult++;
                        }
                        counter0 = 0;
                    }
                    else
                    {
                        counter0++;
                        if (counter1==k)
                        {
                            counterResult++;
                        }
                        counter1 = 0;
                    }
                }
               
            }
            //check last bit in last number
            if (bit == 1)
            {
                if (counter1 == k)
                {
                    counterResult++;
                }
            }
            else
            {
                if (counter0 == k)
                {
                    counterResult++;
                }
            }
            Console.WriteLine(counterResult);
        }
 
        private static uint GetBitInPosition(int bitPosition, uint number)
        {
            uint bit = 0;
            uint mask = 2147483648;
            mask = mask >> bitPosition;
            uint nAndMask = number & mask;
            if (nAndMask==mask)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
*/