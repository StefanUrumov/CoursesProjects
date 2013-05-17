using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ShortToBinary
{
    class ShortToBin
    {
        static short shortNum;
        static short current;

        public static void Main()
        {
            Console.Write("Enter number value (short) : ");
            shortNum = short.Parse(Console.ReadLine());

            current = shortNum;

            FindInBinary();

        }

        public static void FindInBinary()
        {
            if (current <= 0)
            {
                shortNum = (short)(shortNum + 1);
            }

            Console.WriteLine("In binary:");

            for (int i = 15; i >= 0; i--)
            {
                short exponent = (short)Math.Pow(2, i);
                short digit = (short)(shortNum / exponent);
                shortNum = (short)(shortNum % exponent);

                if (current < 0)
                {
                    Console.Write(1 + digit);
                }
                else
                {
                    Console.Write(digit); 
                }
            }

            Console.WriteLine();

        }
    }
}
