using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2___Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter the first member: ");
            int firstMem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first member: ");
            int secondMem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first member: ");
            int thirdMem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter witch member you want to se:");
            short userInput = short.Parse(Console.ReadLine());

            BigInteger final = 0;

            if (userInput == 1)
            {
                final = firstMem;
            }
            else if (userInput == 2)
            {
                final = secondMem;
            }
            else if (userInput == 3)
            {
                final = thirdMem;
            }
            for (BigInteger i = 0; i < userInput - 3; i++)
            {
                final = firstMem + secondMem + thirdMem;
                firstMem = secondMem;
                secondMem = thirdMem;
                thirdMem = (int)final;
            }
            Console.WriteLine(final);

        }
    }
}
