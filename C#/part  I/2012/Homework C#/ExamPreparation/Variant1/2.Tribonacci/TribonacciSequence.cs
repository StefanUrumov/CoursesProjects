using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.Tribonacci
{
    class TribonacciSequence
    {
        static void Main()
        {
            BigInteger firstMem = BigInteger.Parse(Console.ReadLine());
            BigInteger secondMem = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdMem = BigInteger.Parse(Console.ReadLine());           
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
                thirdMem = final;
            }
            Console.WriteLine(final);
        }
    }
}
