using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinimalAndMaximalInSequence
{
    class MinAndMax
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers you want to input: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int min = 0;
            int max = 0;
           

            for (int index = 0; index < inputNumber; index++)
            {
                Console.WriteLine("Enter a number: ");
                int currentNum = int.Parse(Console.ReadLine());                                

                if (index == 0)
                {
                    min = currentNum;
                    max = currentNum;
                }
                if (min > currentNum)
                {
                    min = currentNum;
                }
                if(max < currentNum)
                {
                    max = currentNum;
                }
            }

            Console.WriteLine("The minimal number in sequence is {0} and the maximal number is {1}.", min, max);
            
        }
    }
}
