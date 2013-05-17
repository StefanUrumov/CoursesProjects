using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.CatalanNumbers
{
    class CatalanN
    {
        static void Main()
        {
            Console.WriteLine("Enter witch Catalan number you want to see: ");
            int userInput = int.Parse(Console.ReadLine());

            while (userInput < 0)
            {
                Console.WriteLine("Please enter a positive number:");
                userInput = int.Parse(Console.ReadLine());
            }

            BigInteger factorialOfN = 1;
            BigInteger factorialOfNextN = 1;
            BigInteger factorialDoubleN = 1;
            for (int index = 1; index <= userInput; index++)
                {
                    factorialOfN *= index;
                                
                }
            for (int inner = 1; inner <= userInput + 1; inner++)
                {
                    factorialOfNextN *= inner;
                }
            for (int index2 = 1; index2 <= userInput*2; index2++)
                {
                    factorialDoubleN *= index2;
                }
            Console.WriteLine("n! = {0}", factorialOfN);
            Console.WriteLine("(n+1)! = {0}", factorialOfNextN);
            Console.WriteLine("(2*n)! = {0}", factorialDoubleN);
            
            Console.WriteLine("The {0} number of Catalan is: {1}", userInput, factorialDoubleN / (factorialOfNextN * factorialOfN));
                
        }
    }
}
