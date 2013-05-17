using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is: {0}", Math.Max(firstNum, secondNum));            
        }
    }
}
