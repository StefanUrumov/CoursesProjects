
namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("Please enter only positive integers. To end your sequnce press Enter twice!");

            InputReader();
        }

        private static void InputReader()
        {
            int userInput = 0;
            List<int> numbers = new List<int>();

            try
            {
                while (userInput >= 0)
                {
                    userInput = int.Parse(Console.ReadLine());
                    numbers.Add(userInput);
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("{0} => Enter only positive numbers!", aore.Message);
            }
            catch (FormatException fe)
            {
                ConsoleKeyInfo enterButton = Console.ReadKey();

                if (enterButton.Key == ConsoleKey.Enter)
                {
                    SortNumbers(numbers);
                }
                else
                {
                    Console.WriteLine("{0} => You must enter numbers!", fe.Message);
                }
            }
        }

        private static void SortNumbers(List<int> numbers)
        {
            numbers.Sort((n1, n2) => n1.CompareTo(n2));

            Console.WriteLine("Sorted: ");
            foreach (var num in numbers)
            {
                Console.Write("{0}- ", num);
            }
            Console.WriteLine();
        }
    }
}
