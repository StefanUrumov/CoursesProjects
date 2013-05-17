using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdBit
{
    class ThirdBit
    {
        static string inBinary;

        static void Main()
        {
            Console.WriteLine("Enter a number and see if it's 3-th bit is 0 or 1:");
            string userInput = Console.ReadLine();

            inBinary = Convert.ToString(Convert.ToInt32(userInput, 10), 2);
            Console.WriteLine("Your number in binary is: {0} ", inBinary);

            PrintThirdBit();
            
        }

        static void PrintThirdBit()
        {
            int numberLength = inBinary.Length;

            string finalDigit = inBinary[numberLength - 4].ToString();
            
            try
            {
                if (finalDigit != "1")
                {
                    Console.WriteLine("The third bit in your number is 0!");
                }
                else
                {
                    Console.WriteLine("The third bit in your number is 1!");
                }
            }
            catch (IndexOutOfRangeException range)
            {
                Console.WriteLine("Your number is less than 3 bits! Try with bigger number!");
                Console.WriteLine("Message = {0}", range.Message);
                Console.WriteLine("Stack Trace = {0}", range.StackTrace);
                Console.WriteLine("Source = {0}", range.Source);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Message = {0}", e.Message);
                Console.WriteLine("Stack Trace = {0}", e.StackTrace);
                Console.WriteLine("Source = {0}", e.Source);
            }

        }
        

    }
}
