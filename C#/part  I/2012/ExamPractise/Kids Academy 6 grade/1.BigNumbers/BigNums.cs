using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.BigNumbers
{
    class BigNums
    {        
        static void Main()
        {
            Console.WriteLine("Enter the number of values you want to put in the array (3..100):");
            byte arrNum = byte.Parse(Console.ReadLine());
            string bigNumber = " ";
            string currentNum = " ";

            for (int index = 0; index < arrNum; index++)
            {
                Console.WriteLine("enter value for {0}: ", index);
                BigInteger number = BigInteger.Parse(Console.ReadLine());

                currentNum = number.ToString();
                bigNumber += currentNum;
            }
            //Console.WriteLine(bigNumber);

            string firstHalf = " ";            
            for (int index = 0; index <= bigNumber.Length / 2; index++)
            {
                firstHalf += bigNumber[index];    
            }
            //Console.Write(firstHalf + ' ');

            Console.WriteLine();

            string secondHalf = " ";
            for (int index = (bigNumber.Length / 2) + 1; index < bigNumber.Length; index++)
            {
                secondHalf += bigNumber[index];
            }
            //Console.Write(secondHalf + ' ');

            //reverse first half of the big string
            Console.WriteLine();
            char[] reverseFirstHalf = firstHalf.ToCharArray();
            Array.Reverse(reverseFirstHalf);
            string newFirstHalf = new string(reverseFirstHalf);
            //Console.Write(newFirstHalf + '*');
            //Console.WriteLine();
                
            string halfPalindrome = " ";

            for (int index = 0, inner = 1; index < newFirstHalf.Length && inner < secondHalf.Length; index++, inner++)
            {
                //Console.WriteLine(newFirstHalf[index] + " " + secondHalf[inner] + "+");
                //Console.WriteLine();

                if (newFirstHalf[index] == secondHalf[inner])
                    {
                        halfPalindrome += newFirstHalf[index]; 
                    }
            }

            Console.WriteLine();
            //Console.WriteLine(halfPalindrome);
            
            
            char[] reverseHalfPalindrome = halfPalindrome.ToCharArray();
            Array.Reverse(reverseHalfPalindrome);
            string newHalfPalindrome = new string(reverseHalfPalindrome);
            string palindrome =  newHalfPalindrome + halfPalindrome;
                       
            Console.WriteLine(palindrome);

        }
    }
}
