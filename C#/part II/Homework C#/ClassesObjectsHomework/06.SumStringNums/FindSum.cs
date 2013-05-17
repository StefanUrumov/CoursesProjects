using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumStringNums
{
    class FindSum
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of positive integer values, separated by spaces: ");
            string userInput = Console.ReadLine();

            string[] numbers = userInput.Split(' ');
            int sum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                sum += int.Parse(numbers[index]);
            }

            Console.WriteLine(sum);
        }
    }
}
