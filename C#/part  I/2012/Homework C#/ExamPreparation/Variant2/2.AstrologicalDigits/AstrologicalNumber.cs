using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace _2.AstrologicalDigits
{
    class AstrologicalNumber
    {
        static long result;
        static string userInput;

        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                       
            userInput = Console.ReadLine();

            result = 0L;
                        
            ReduceToResult();            
        }

        private static void ReduceToResult()
        {
            string resultStr = userInput.ToString();
            for (int i = 0; i < userInput.Length; i++)
                {
                    if (Char.IsDigit(userInput[i]))
                   {
                       result += long.Parse(userInput[i].ToString());  
                   }
                }
                while (result > 9)
                {
                    long nextSumOfDigits = 0;
                    while (result > 0)
                    {
                        long lastDigit = result % 10;
                        nextSumOfDigits = nextSumOfDigits + lastDigit;
                        result = result / 10;
                    }
                    result = nextSumOfDigits;                      
                }                
                Console.WriteLine(result);
        }
    }
}
