using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexToDecimal
{
    public class HexToDec
    {
        public static void Main()
        {
            Console.WriteLine("Enter hex number: ");
            string inHex = Console.ReadLine();

            int length = inHex.Length - 1;
            int digit = 0;
            int result = 0;

            for (int index = 0; index < inHex.Length; index++)
            {
                if (inHex[index] == 'A' || inHex[index] == 'a')
                {
                    digit = 10;
                }
                else if (inHex[index] == 'B' || inHex[index] == 'b')
                {
                    digit = 11;
                }
                else if (inHex[index] == 'C' || inHex[index] == 'c')
                {
                    digit = 12;
                }
                else if (inHex[index] == 'D' || inHex[index] == 'd')
                {
                    digit = 13;
                }
                else if (inHex[index] == 'E' || inHex[index] == 'e')
                {
                    digit = 14;
                }
                else if (inHex[index] == 'F' || inHex[index] == 'f')
                {
                    digit = 15;
                }
                else
                {
                    digit = int.Parse(inHex[index].ToString());                 
                }

                result += digit * FindPow(length);
                length--;
            }

            Console.WriteLine(result);             
            
        }

        public static int FindPow(int sqr)
        {
            return (1 << (sqr * 4));
        }
        
    }
}
