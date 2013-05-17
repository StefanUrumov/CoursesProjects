using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.OperatorsSequence
{
    class OperatorsSequence
    {
        static string userInput;

        static void Main()
        {

            Console.WriteLine("Enter a number:");
            userInput = Console.ReadLine();

            string inBinary = Convert.ToString(Convert.ToInt32(userInput, 10), 2);
            
            int toBinary = Convert.ToInt32(inBinary);
            Console.WriteLine("Your number in binary is: {0} ", toBinary);

            Console.WriteLine("If value of the bit is only 0 or 1, please enter your choise:");
            int bitPos = int.Parse(Console.ReadLine());

            if (bitPos == 1)
            {
                SetBitToOne();
            }
            if (bitPos == 0)
            {
                SetBitToZero();
            }
            else if (bitPos > 1)
            {
                Console.WriteLine("Inccorect input!");
            }

        }

        static void SetBitToOne()
        {
            Console.Write("Enter the position you want to change: ");
            int userPos = int.Parse(Console.ReadLine());

            int userNum = Convert.ToInt32(userInput);

            int mask = 1 << userPos;
            int result = userNum |  mask;
            Console.WriteLine("Your modified  number is: {0}", result);
        }

        static void SetBitToZero()
        {
            Console.Write("Enter the position you want to change: ");
            int userPos = int.Parse(Console.ReadLine());

            int userNum = Convert.ToInt32(userInput);

            int mask = 1 << userPos;
            int numAndMask = userNum & mask;            
            int result = numAndMask >> userPos;
            Console.WriteLine("Your modified  number is: {0}", result);
        }

    }
}
