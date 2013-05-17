using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReversesTheDigits
{
    public class ReversedNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number: ");
            decimal userInput = decimal.Parse(Console.ReadLine());

            string reversedNum = userInput.ToString();
            DoReverse(reversedNum);
            
            Console.WriteLine(DoReverse(reversedNum));
        }

        public static string DoReverse(string reversedNum)
        {
            char[] arr = reversedNum.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
