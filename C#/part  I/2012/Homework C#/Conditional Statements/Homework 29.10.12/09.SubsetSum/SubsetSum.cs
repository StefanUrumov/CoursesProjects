using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SubsetSum
{
    class SubsetSum
    {
        static void Main()
        {
            Console.WriteLine("Enter a number!");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number!");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number!");
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fourth number!");
            int fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fifth number!");
            int fifthNum = int.Parse(Console.ReadLine());

            if ((firstNum + secondNum + thirdNum + fourthNum + fifthNum == 0) || (firstNum + secondNum == 0 || firstNum + thirdNum == 0 || firstNum + fourthNum == 0 || firstNum + fifthNum == 0) || (firstNum + secondNum + thirdNum == 0 || firstNum + secondNum + fourthNum == 0 || firstNum + secondNum + fifthNum == 0) || (secondNum + thirdNum == 0 || secondNum + fourthNum == 0 || secondNum + fifthNum == 0) || (secondNum + thirdNum + fourthNum == 0 || secondNum + fourthNum + fifthNum == 0) || (thirdNum + fourthNum == 0 || thirdNum + fifthNum == 0) || (fourthNum + fifthNum == 0))
            {
                if (firstNum + secondNum + thirdNum + fourthNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of the numbers is 0 !");
                }
                if (firstNum + secondNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " is zero !");
                }
                if (firstNum + thirdNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + thirdNum + " is zero !");
                }
                if (firstNum + fourthNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + fourthNum + " is zero !");
                }
                if (firstNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + fifthNum + " is zero !");
                }
                if (firstNum + secondNum + thirdNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " and " + thirdNum + " is zero !");
                }
                if (firstNum + secondNum + fourthNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " and " + fourthNum + " is zero !");
                }
                if (firstNum + secondNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " and " + fifthNum + " is zero !");
                }

                if (secondNum + thirdNum == 0)
                {
                    Console.WriteLine("The sum of " + secondNum + " and " + thirdNum + " and " + " is zero !");
                }
                if (secondNum + fourthNum == 0)
                {
                    Console.WriteLine("The sum of " + secondNum + " and " + fourthNum + " is zero !");
                }
                if (secondNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + secondNum + " and " + fifthNum + " is zero !");
                }

                if (secondNum + thirdNum + fourthNum == 0)
                {
                    Console.WriteLine("The sum of " + secondNum + " and " + thirdNum + " and " + fourthNum + " is zero !");
                }
                if (secondNum + fourthNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + secondNum + " and " + fourthNum + " and " + fifthNum + " is zero !");
                }


                if (thirdNum + fourthNum == 0)
                {
                    Console.WriteLine("The sum of " + thirdNum + " and " + fourthNum + " is zero !");
                }
                if (thirdNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + thirdNum + " and " + fifthNum + " is zero !");
                }
                if (fourthNum + fifthNum == 0)
                {
                    Console.WriteLine("The sum of " + fourthNum + " and " + fifthNum + " is zero !");
                }
            }
            else
            {
                Console.WriteLine("No sum of these numbers is 0!");
            }
        }
    }
}
