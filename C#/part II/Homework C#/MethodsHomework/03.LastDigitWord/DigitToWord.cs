using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigitWord
{
    class DigitToWord
    {
        static int number;
        static int lastDigit;

        static void Main()
        {
            Console.WriteLine("Enter an integer :");
            number = int.Parse(Console.ReadLine());

            FindLastDigit();
        }

        private static void FindLastDigit()
        {
            lastDigit = number % 10;

            PrintDigitAsWord();
        }

        private static void PrintDigitAsWord()
        {
            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");break;
                case 1:
                    Console.WriteLine("one"); break;
                case 2:
                    Console.WriteLine("two"); break;
                case 3:
                    Console.WriteLine("three"); break;
                case 4:
                    Console.WriteLine("four"); break;
                case 5:
                    Console.WriteLine("five"); break;
                case 6:
                    Console.WriteLine("six"); break;
                case 7:
                    Console.WriteLine("seven"); break;
                case 8:
                    Console.WriteLine("eight"); break;
                case 9:
                    Console.WriteLine("nine"); break;
                default:
                Console.WriteLine("Not a number!");break;
            }
        }






    }
}
