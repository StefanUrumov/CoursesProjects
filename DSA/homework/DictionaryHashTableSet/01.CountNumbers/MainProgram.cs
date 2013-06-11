
namespace _01.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            double[] doublesArray = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            CountDoubleNumbersInArray(doublesArray);
                        
        }

        private static void PrintResult(IDictionary<double, int> finalDictionary)
        {
            foreach (var pair in finalDictionary)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
  
        private static void CountDoubleNumbersInArray(double[] inputArray)
        {
            IDictionary<double, int> countNumbers = new Dictionary<double, int>();

            foreach (var num in inputArray)
            {
                double count = 1;
                if (countNumbers.ContainsKey(num))
                {
                    count = countNumbers[num] + 1;
                }

                countNumbers[num] = (int)count;
            }

            PrintResult(countNumbers);
                        
        }


    }
}
