using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Problem_5___Lines
{
    class Lines
    {
        static void Main()
        {
          System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int row = 8;
            int[] numbers = new int[row];
            //enter numbers
            for (int counter = 0; counter < row; counter++)
            {
                numbers[counter] = byte.Parse(Console.ReadLine());
            }
            int howManyTimesInRowGlobal;
            int maxBitGlobalRow;
            int howManyTimesInColGlobal;
            int maxBitGlobalCol;
            GetMaxInRow(row, numbers, out howManyTimesInRowGlobal, out maxBitGlobalRow);
            GetMaxInColum(numbers, out howManyTimesInColGlobal, out maxBitGlobalCol);
 
            if (maxBitGlobalRow>maxBitGlobalCol)
            {
                Console.WriteLine(maxBitGlobalRow);
                Console.WriteLine(howManyTimesInRowGlobal);
            }
            else if(maxBitGlobalRow<maxBitGlobalCol)
            {
                Console.WriteLine(maxBitGlobalCol);
                Console.WriteLine(howManyTimesInColGlobal);
            }
            else //if (maxBitGlobalRow==maxBitGlobalCol)
            {
                Console.WriteLine(maxBitGlobalCol);
                if (maxBitGlobalRow ==1)
                {
                    Console.WriteLine(howManyTimesInColGlobal);
                }
                else
                {
                    Console.WriteLine(howManyTimesInColGlobal + howManyTimesInRowGlobal);
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
 
                //new column - check MAX in column and all column to now
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
 
                //new row - check Max in row and all row to now - get MAX
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
