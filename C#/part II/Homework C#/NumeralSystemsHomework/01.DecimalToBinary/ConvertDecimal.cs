using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    public class ConvertDecimal
    {
        static int decimalNum;
        static int current;
        static string finalNum;
        static string inBinary;


        public static void Main()
        {
            /*
             Write a program to convert decimal numbers to their binary representation.
             */
            
            //read input
            Console.Write("Enter decimal number : ");
            decimalNum = int.Parse(Console.ReadLine());
            
            //store the result
            finalNum = "";

            FindInBinary();
            
        }

        public static void FindInBinary()
        {
            //find binary representation
            while (decimalNum != 0)
            {
                current = decimalNum / 2;
                finalNum += (decimalNum % 2).ToString();
                decimalNum = current;
            }

            PrintResult();
        }

        public static void PrintResult()
        {
            // Reversing to print the result
            inBinary = "";

            for (int i = finalNum.Length - 1; i >= 0; i--)
            {
                inBinary = inBinary + finalNum[i];
            }

            Console.WriteLine("In binary: {0}", inBinary);
        }

    }
}

