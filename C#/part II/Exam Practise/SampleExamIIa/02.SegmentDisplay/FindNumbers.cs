using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SegmentDisplay
{
    class FindNumbers
    {
        static int numbers;
        static int toNumber;

        static void Main()
        {
            numbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                string displayNum = Console.ReadLine();
                CheckNum(displayNum);
                if (numbers > 1)
                {
                    FindPair(toNumber);
                }
            }
            
        }

        private static void CheckNum(string displayNum)
        {
            string zero = "1111110";
            string one  = "0110000";
            string two  = "1101101";
            string three ="1111001";
            string four = "0110011";
            string five = "1011011";
            string six  = "1011111";
            string seven ="1110000";
            string eight ="1111111";
            string nine = "1110111";

            
            if (displayNum == zero)
            {
                toNumber = 0;
            }
            if (displayNum == one)
            {
                toNumber =1;
            }
            
            if (displayNum == two)
            {
                toNumber =2;
            }
            if (displayNum == three)
            {
                toNumber =3;
            }
            if (displayNum == four)
            {
                toNumber =4;
            }
            if (displayNum == five)
            {
                toNumber =5;
            }
            if (displayNum == six)
            {
                toNumber =6;
            }
            if (displayNum == seven)
            {
                toNumber =7;
            }
            if (displayNum == eight)
            {
                toNumber = 8;
            }
            if (displayNum == nine)
            {
                toNumber =9;
            }

            FindPair(toNumber);
        }

        private static void FindPair(int toNumber)
        {
            List<char> pair = new List<char>();
            
            if (toNumber == 0)
            {
                pair.Add('0');
                pair.Add('8');
            }
            if (toNumber == 1)
            {
                pair.Add('1');
                pair.Add('0');
                pair.Add('3');
                pair.Add('4');
                pair.Add('7');
                pair.Add('8');
                pair.Add('9');
            }
            if (toNumber == 2)
            {
                pair.Add('2');
                pair.Add('8');
            }
            if (toNumber == 3)
            {
                pair.Add('3');
                pair.Add('8');
            }
            if (toNumber == 4)
            {
                pair.Add('4');
                pair.Add('8');
                pair.Add('9');
            }
            if (toNumber == 5)
            {
                pair.Add('5');
                pair.Add('8');
                pair.Add('9');
            }
            if (toNumber == 6)
            {
                pair.Add('6');
                pair.Add('8');                
            }
            if (toNumber == 7)
            {
                pair.Add('0');
                pair.Add('7');
                pair.Add('8');
                pair.Add('9');
            }
            if (toNumber == 8)
            {
                pair.Add('8');
            }
            if (toNumber == 9)
            {
                pair.Add('8');
                pair.Add('9');
            }

            PrintResult(pair);
        }

        private static void PrintResult(List<char> pair)
        {            
            Console.WriteLine(pair.Count);
            foreach (var num in pair)
            {
                Console.WriteLine(num);
            }
        }
    }
}
