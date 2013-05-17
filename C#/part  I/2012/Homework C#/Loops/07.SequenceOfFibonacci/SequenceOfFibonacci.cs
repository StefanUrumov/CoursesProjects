using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.SequenceOfFibonacci
{
    class SequenceOfFibonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers of the Sequence Of Fibonacci you want to see:");
            int userInput = int.Parse(Console.ReadLine());

            BigInteger firstMem = 0;
            BigInteger secondMem = 1;
            BigInteger thirdMem = 0;

            for (int index = 1; index <= userInput; index++)
            {
                Console.WriteLine("{0}: {1}", index, thirdMem);
                firstMem = secondMem;
                secondMem = thirdMem;
                thirdMem = firstMem + secondMem;
            }
        }
    }
}
