using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LettersAndDigits
{
    class LettersDigits
    {
        static void Main()
        {
            Console.WriteLine("Enter six elements long text: ");
            string text = Console.ReadLine();

            byte digits = 0;
            byte small = 0;
            byte big = 0;
            byte rest = 0;

            foreach (var item in text)
            {
                bool isDigit = char.IsDigit(item);
                if (isDigit)
                {
                    digits++;
                }

                bool isLower = char.IsLower(item);
                if (isLower)
                {
                    small++;
                }

                bool isUpper = char.IsUpper(item);
                if (isUpper)
                {
                    big++;
                }

                
                bool isSymbol = char.IsSymbol(item);
                if (isSymbol)
                {
                    rest++;
                }
                                
            }
            Console.WriteLine("{0} {1} {2} {3}", digits, small, big, rest);




        }
    }
}
