using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBit
{
    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            string inBinary = Convert.ToString(Convert.ToInt32(userInput, 10), 2);
            
            Console.Write("Enter the bit position that you want to extract: ");
            int bitPos = int.Parse(Console.ReadLine());

            int numLen = inBinary.Length - 1;

            Console.WriteLine("The bit in your position is: {0}!", inBinary[numLen - bitPos]);
        }

    }
}
