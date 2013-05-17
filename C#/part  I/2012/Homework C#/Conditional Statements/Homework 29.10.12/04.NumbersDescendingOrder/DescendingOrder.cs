using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersDescendingOrder
{
    class DescendingOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter three  numbers and see them in descending order:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The order of your numbers is:");

            if (firstNum > secondNum && firstNum > thirdNum)
            {                
                if (secondNum > thirdNum)
                {                    
                    Console.WriteLine(firstNum);
                    Console.WriteLine(secondNum);
                    Console.WriteLine(thirdNum);
                }
                else
                {
                    Console.WriteLine(firstNum);
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(secondNum);                    
                }
            }
            

            if (secondNum > firstNum && secondNum > thirdNum)
            {                
                if (firstNum > thirdNum)
                {                    
                    Console.WriteLine(secondNum);
                    Console.WriteLine(firstNum);
                    Console.WriteLine(thirdNum);
                }
                else
                {                    
                    Console.WriteLine(secondNum);
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(firstNum);
                }
            }


            if (thirdNum > firstNum && thirdNum > secondNum)
            {

                if (firstNum > secondNum)
                {                    
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(firstNum);
                    Console.WriteLine(secondNum);
                }
                else
                {                    
                    Console.WriteLine(thirdNum);
                    Console.WriteLine(secondNum);
                    Console.WriteLine(firstNum);
                }
            }
        }
    }
}
