
namespace Task1
{

    //I know about the loose coupling, but in this case it just not worth the bother
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PositiveIntegersSequence 
    {
        static void Main()
        {
            Console.WriteLine("Please enter only positive integers. To end your sequnce press Enter twice!");

            InputReader();
        }

        private static void InputReader()
        {
            int userInput = 0;
            IList<int> numbers = new List<int>();
            
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
                    FindSumAndAverage(numbers);
                }
                else
                {
                    Console.WriteLine("{0} => You must enter numbers!", fe.Message);
                }
            }            
        }
  
        private static void FindSumAndAverage(IList<int> numbers)
        {
            long numbersSum = 0;
            double numbersAverage = 0;

            numbersSum = numbers.Sum();
            numbersAverage = numbers.Average();
            Console.WriteLine("The sum of your sequence is: {0} and the avgerage is: {1}.", numbersSum, numbersAverage);    
        }
    }
}
