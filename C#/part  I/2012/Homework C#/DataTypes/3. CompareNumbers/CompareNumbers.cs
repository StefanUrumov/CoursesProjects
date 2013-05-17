using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareNumbers
{
    class CompareNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number with max floating-point precision of 7 digits:");
            float firstNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number with max floating-point precision of 7 digits:");
            float secondNum = float.Parse(Console.ReadLine());

            bool equalNumbers = (firstNum == secondNum);
            Console.WriteLine("The numbers are equal up to the 7th floating point digit: {0}", equalNumbers);
            
        }
    }
}
