using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FallDown
{
    class FallDownDown
    {
        static void Main()
        {           
            int number0 = int.Parse(Console.ReadLine());
            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());
            int number03 = int.Parse(Console.ReadLine());
            int number04 = int.Parse(Console.ReadLine());
            int number05 = int.Parse(Console.ReadLine());
            int number06 = int.Parse(Console.ReadLine());
            int number07 = int.Parse(Console.ReadLine());

            for (int count = 1; count <= 7; count++)
            {
                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number07 >> bit & 1) == 0 &&
                        (number06 >> bit & 1) == 1)
                    {
                        number07 |= (1 << bit);
                        number06 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number06 >> bit & 1) == 0 &&
                        (number05 >> bit & 1) == 1)
                    {
                        number06 |= (1 << bit);
                        number05 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number05 >> bit & 1) == 0 &&
                        (number04 >> bit & 1) == 1)
                    {
                        number05 |= (1 << bit);
                        number04 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number04 >> bit & 1) == 0 &&
                        (number03 >> bit & 1) == 1)
                    {
                        number04 |= (1 << bit);
                        number03 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number03 >> bit & 1) == 0 &&
                        (number02 >> bit & 1) == 1)
                    {
                        number03 |= (1 << bit);
                        number02 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number02 >> bit & 1) == 0 &&
                        (number01 >> bit & 1) == 1)
                    {
                        number02 |= (1 << bit);
                        number01 &= ~(1 << bit);
                    }
                }

                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((number01 >> bit & 1) == 0 &&
                        (number0 >> bit & 1) == 1)
                    {
                        number01 |= (1 << bit);
                        number0 &= ~(1 << bit);
                    }
                }
            }

            Console.WriteLine(number0);
            Console.WriteLine(number01);
            Console.WriteLine(number02);
            Console.WriteLine(number03);
            Console.WriteLine(number04);
            Console.WriteLine(number05);
            Console.WriteLine(number06);
            Console.WriteLine(number07);
        }
    }
}
