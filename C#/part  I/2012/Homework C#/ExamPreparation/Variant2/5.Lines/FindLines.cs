using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _5.Lines
{
    class FindLines
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            int row = 8;
            int[] numbersArray = new int[row];
            
            for (int count = 0; count < row; count++)
            {
                numbersArray[count] = byte.Parse(Console.ReadLine());
            }
            int TimesInRowTotal;
            int maxBitTotalRow;
            int TimesInColTotal;
            int maxBitTotalCol;
            GetMaxInRow(row, numbersArray, out TimesInRowTotal, out maxBitTotalRow);
            GetMaxInColum(numbersArray, out TimesInColTotal, out maxBitTotalCol);

            if (maxBitTotalRow > maxBitTotalCol)
            {
                Console.WriteLine(maxBitTotalRow);
                Console.WriteLine(TimesInRowTotal);
            }
            else if (maxBitTotalRow < maxBitTotalCol)
            {
                Console.WriteLine(maxBitTotalCol);
                Console.WriteLine(TimesInColTotal);
            }
            else //if (maxBitGlobalRow==maxBitGlobalCol)
            {
                Console.WriteLine(maxBitTotalCol);
                if (maxBitTotalRow == 1)
                {
                    Console.WriteLine(TimesInColTotal);
                }
                else
                {
                    Console.WriteLine(TimesInColTotal + TimesInRowTotal);
                }

            }
        }


        private static void GetMaxInColum(int[] numbers, out int howManyTimesInColGlobal, out int maxBitGlobalCol)
        {
            maxBitGlobalCol = 0;
            howManyTimesInColGlobal = 0;
            for (int counterCol = 0; counterCol < 8; counterCol++)
            {
                int countBitInCol = 0;
                int maxBitInCol = 0;
                int howManyTimesInCol = 0;
                bool newValue = false;
                for (int counterBit = 0; counterBit < 8; counterBit++)
                {
                    int bit = GetBitAtPosition(counterCol, numbers, counterBit);
                    if (bit == 1)
                    {
                        countBitInCol++;
                    }
                    else
                    {
                        newValue = CheckForNewMax(countBitInCol, ref maxBitInCol);
                        CountMaximumBitInRow(maxBitInCol, countBitInCol, ref howManyTimesInCol, ref newValue);
                        countBitInCol = 0;
                    }


                }
                newValue = CheckForNewMax(countBitInCol, ref maxBitInCol);
                CountMaximumBitInRow(maxBitInCol, countBitInCol, ref howManyTimesInCol, ref newValue);
                                
                if (maxBitGlobalCol < maxBitInCol)
                {
                    maxBitGlobalCol = maxBitInCol;
                    howManyTimesInColGlobal = howManyTimesInCol;
                }
                else if (maxBitGlobalCol == maxBitInCol)
                {
                    howManyTimesInColGlobal += howManyTimesInCol;
                }
            }
        }

        private static void GetMaxInRow(int row, int[] numbers, out int howManyTimesInRowGlobal, out int maxBitGlobalRow)
        {
            maxBitGlobalRow = 0;
            howManyTimesInRowGlobal = 0;
            for (int counterRow = 0; counterRow < row; counterRow++)
            {
                int countBitInRow = 0;
                int maxBitInRow = 0;
                int howManyTimesInRow = 0;
                bool newValue = false;
                for (int counterBit = 0; counterBit < 8; counterBit++)
                {
                    int bit = GetBitAtPosition(counterBit, numbers, counterRow);
                    if (bit == 1)
                    {
                        countBitInRow++;
                    }
                    else
                    {
                        newValue = CheckForNewMax(countBitInRow, ref maxBitInRow);
                        CountMaximumBitInRow(maxBitInRow, countBitInRow, ref howManyTimesInRow, ref newValue);
                        countBitInRow = 0;
                    }
                }
                newValue = CheckForNewMax(countBitInRow, ref maxBitInRow);
                CountMaximumBitInRow(maxBitInRow, countBitInRow, ref howManyTimesInRow, ref newValue);
                               
                if (maxBitGlobalRow < maxBitInRow)
                {
                    maxBitGlobalRow = maxBitInRow;
                    howManyTimesInRowGlobal = howManyTimesInRow;
                }
                else if (maxBitGlobalRow == maxBitInRow)
                {
                    howManyTimesInRowGlobal += howManyTimesInRow;
                }
            }
        }

        private static void CountMaximumBitInRow(int maxBit, int countBit, ref int howManyTimes, ref bool newValue)
        {
            if (maxBit == countBit && countBit != 0)
            {
                if (newValue)
                {
                    howManyTimes = 1;
                    newValue = false;
                }
                else
                {
                    howManyTimes++;
                }
            }
        }

        private static bool CheckForNewMax(int countBit, ref int maxBit)
        {
            bool newValue = false;
            if (maxBit < countBit)
            {
                maxBit = countBit;
                newValue = true;
            }
            return newValue;
        }

        private static int GetBitAtPosition(int bitPosition, int[] numbers, int counterRow)
        {
            int bit = 0;
            int mask = 1;
            mask = mask << bitPosition;
            int nAndMask = numbers[counterRow] & mask;
            bit = nAndMask >> bitPosition;
            return bit;
        }
    }
}
