using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimeNumbers
{
    class PrimeNumbers
    {
        // to solve this prime number problem we can use the Sieve of Eratosthenes
        // but since we have numbers up to 100 we can simply use array of prime numbers

        static int[] primeNumbers;
        static byte userInput;
        static byte index;
        
        static void Main()
        {
            Console.WriteLine("Enter a number between 1 nad 100 and see if it is a prime number:");
            userInput = byte.Parse(Console.ReadLine());

            GetNumbers();
        }

        static void GetNumbers()
        {
            primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
                
            if (userInput >= 1 && userInput < 100)
            {
                CheckPrime();                
            }
            else
            {
                Console.WriteLine("Inccorect input!");
            }
            
        }

        static void CheckPrime()
        {
            for (index = 0; index <= primeNumbers.Length - 1; index++ )
            {
                if (primeNumbers[index] == userInput)
                {
                    Console.WriteLine("Your number is prime!"); 
                }
                else if (primeNumbers[index] != userInput)
                {
                    Console.WriteLine("Your number is not prime!");
                }
            }
        }
             


       
    }
}
