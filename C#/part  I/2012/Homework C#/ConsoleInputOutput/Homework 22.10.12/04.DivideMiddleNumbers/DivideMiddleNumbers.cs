using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DivideMiddleNumbers
{
    class DivideMiddleNumbers
    {
        static int firstNum;
        static int secondNum;

        static void Main()
        {
            Console.WriteLine("Enter two positive integer numbers: ");
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());

            if(firstNum > 0 && secondNum > 0 && firstNum < secondNum)
            {
                CheckMiddleNumbers();
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }


        static void CheckMiddleNumbers()
        {
            int counter = 0;

            for (int index = firstNum; index <= secondNum; index++)
            {
                if (index % 5 == 0)
                {
                    Console.Write(index + " ");
                    counter += 1;
                    Console.WriteLine("There are {0} numbers between {1} and {2} such that the reminder of the division by 5 is 0 (inclusive)", counter, firstNum, secondNum);
                }                
            }
        }

    }
}
