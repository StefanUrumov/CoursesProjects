
namespace Task2
{
    //I know about the loose coupling, but in this case it just not worth the bother
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("How many number you want to enter: ");
            GetUserInput();
        }

        private static void GetUserInput()
        {
            int userNumbersCount = int.MinValue;           

            userNumbersCount = int.Parse(Console.ReadLine());
            if (userNumbersCount <= 0)
            {
                throw new ArgumentOutOfRangeException("Try with positive count.");
            }

            ReverseUserNumbers(userNumbersCount);
        }

        private static void ReverseUserNumbers(int userNumbersCount)
        {
            uint userNumber = uint.MinValue;
            Stack<uint> numbers = new Stack<uint>();

            for (int i = 0; i < userNumbersCount; i++)
            {
                userNumber = uint.Parse(Console.ReadLine());
                numbers.Push(userNumber);
            }

            PrintFinal(numbers);            
        }

        private static void PrintFinal(Stack<uint> numbers)
        {
            Console.WriteLine("Your numbers in reversed order: ");
            numbers.Reverse();

            foreach (var number in numbers)
            {
                Console.Write("{0} - ", number);
            }
            Console.WriteLine();
        }
    }
}
