using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.NumbersToText
{
    class TextNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 8 digit long sequence (letters or numbers):");
            string line = Console.ReadLine();

            byte sum = 0;
            byte count = 0;

            foreach (char item in line)
            {                
                bool isDigit = char.IsDigit(item);
                if (isDigit)
                {
                    sum += byte.Parse(item.ToString());
                }

                bool isletter = char.IsLetter(item);
                if (isletter)
                {
                    count++;
                }

            }

            if (sum == 0)
            {
                if (count == 8)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine("0");
                }
                
            }            
            if (sum > 0)
            {
                Console.WriteLine(sum);
            }
            
            
            

            



        }
    }
}
