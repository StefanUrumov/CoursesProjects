using System;
using System.Collections.Generic;

namespace Eratosthenes
{
    class Program
    {
        private static List<long> primeNumbers = new List<long>();

        static void Main()
        {
            primeNumbers.Add(2);
            Console.Write(2);

            for (long checkValue = 3; checkValue <= 10000000; checkValue += 2)
            {
                if (IsPrime(checkValue))
                {
                    primeNumbers.Add(checkValue);
                    Console.Write("\t{0}", checkValue);
                }
            }
        }

        private static bool IsPrime(long checkValue)
        {
            bool isPrime = true;

            foreach (int prime in primeNumbers)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

    }
}
