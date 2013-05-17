using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHex
{
    public class DecToHex
    {
        public static void Main()
        {
            Console.WriteLine("Enter decimal number: ");
            int decNumber = int.Parse(Console.ReadLine());

            int current = 0;
            string finalNum = "";

            while (decNumber != 0)
            {
                current = decNumber / 16;
                if (decNumber % 16 == 10)
                {
                    finalNum += "A";
                }
                if (decNumber % 16 == 11)
                {
                    finalNum += "B";
                }
                if (decNumber % 16 == 12)
                {
                    finalNum += "C";
                }
                if (decNumber % 16 == 13)
                {
                    finalNum += "D";
                }
                if (decNumber % 16 == 14)
                {
                    finalNum += "E";
                }
                if (decNumber % 16 == 15)
                {
                    finalNum += "F";
                }
                else
                {
                    finalNum += (decNumber % 16).ToString();
                }
                
                decNumber = current;
            }

            // Reversing to print the result
            string inHex = "";

            for (int i = finalNum.Length - 1; i >= 0; i--)
            {
                inHex += finalNum[i];
            }

            Console.WriteLine("In hex: {0}", inHex);
        
        }
    }
}
