using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.First100MembersOfFibonacci
{
    class FibonacciSequence 
    {
        static void Main()
        {
            Console.WriteLine("The first 100 members of the sequence of Fibonacci are:");
            
            BigInteger member1 = 0;
            BigInteger member2 = 1;
            BigInteger member3 = 0;

            for (int index = 1; index < 101; index++)
            {
                Console.WriteLine("{0}: {1}", index, member3);
                member1 = member2;
                member2 = member3;
                member3 = member1 + member2;
            }            
        }
    }
}
