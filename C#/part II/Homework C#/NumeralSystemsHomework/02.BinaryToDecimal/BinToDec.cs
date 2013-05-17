using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    public class BinToDec
    {
        static string inBinary;
        static string arrayElements;
        static string arrayPow;
        static string final;
        static int element;
        static int pow;
        static int numLength;
        static int binPower;
        static int inDecimal;
                
        public static void Main()
        {
            Console.WriteLine("Enter binary number: ");
            inBinary = Console.ReadLine();
            
            numLength = inBinary.Length;
            binPower = numLength - 1;            
                       
            FindElement();
                        
            FindPow();           
            
            PrintResult();
            
        }

        public static void PrintResult()
        {
            final = "";
            inDecimal = 0;

            for (int i = 0; i < numLength; i++)
            {
                final += int.Parse(arrayElements[i].ToString()) * (int)Math.Pow(2, int.Parse(arrayPow[i].ToString()));
                inDecimal += int.Parse(final[i].ToString());
            }

            Console.WriteLine("In decimal: {0}", inDecimal);
        }

        public static void FindPow()
        {
            arrayPow = "";

            for (pow = binPower; pow >= 0; pow--)
           {
                //Console.WriteLine(pow);
                arrayPow += pow;
           }            
        }

        public static void FindElement()
        {
            arrayElements = "";

            for (element = 0; element < inBinary.Length; element++)
            {
                //Console.WriteLine("e.{0} ", inBinary[element]);
                arrayElements += inBinary[element];
            }    
        }
    }
}
