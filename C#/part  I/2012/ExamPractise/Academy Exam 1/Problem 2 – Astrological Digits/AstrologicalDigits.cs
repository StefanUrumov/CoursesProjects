using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Problem_2___Astrological_Digits
{
    class AstrologicalDigits
    {   
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Console.WriteLine("Enter an integer (N), to see it's astrological value");
            string userInput = Console.ReadLine();

            bool stop = false;
            long finalNum = 0L;
            int digit = 0;

            do
            {
                foreach (var number in userInput)
                {                    
                    if (int.TryParse(number.ToString(), out digit))
                    {
                       finalNum = finalNum + digit; 
                    }
                    if (finalNum <= 9)
                    {
                        stop = true;
                    }
                    else
                    {
                        userInput = finalNum.ToString();
                    }
                }
            } while (!stop);
            Console.WriteLine(finalNum);


        }
    }
}
