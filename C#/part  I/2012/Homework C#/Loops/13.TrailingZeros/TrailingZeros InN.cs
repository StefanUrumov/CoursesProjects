using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.TrailingZeros
{
    class TrailingZerosInN
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number: ");
            int userInput = int.Parse(Console.ReadLine());
            int zeroes = 0;
            int divisors = 5;

            while (userInput < 0)
            {
                Console.WriteLine("Incorrect input! Enter new number: ");
                userInput = int.Parse(Console.ReadLine());
            }


            BigInteger factorial = 1;
            for (int index = 1; index <= userInput; index++)
            {
                factorial *= index;
            }
            Console.WriteLine("n! = {0}", factorial);

            while ((userInput / divisors) != 0)
            {
                zeroes += userInput / divisors;
                divisors *= divisors;
            }

            Console.WriteLine("trailng zaroes -> {0}", zeroes);


        }
    }
}
