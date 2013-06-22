using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.RiskWinsRiskLoses
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // TestGenerator.GenerateTests(); return;
            string startCombination = Console.ReadLine();
            string finalCombination = Console.ReadLine();
            int forbiddenCombinationsCount = int.Parse(Console.ReadLine());
            List<string> forbiddenCombinations =
                new List<string>(forbiddenCombinationsCount);
            for (int i = 1; i <= forbiddenCombinationsCount; i++)
            {
                forbiddenCombinations.Add(Console.ReadLine());
            }

            LowestButtonsCountFinder finder = new LowestButtonsCountFinder(
                startCombination, finalCombination, forbiddenCombinations);

            Console.WriteLine(finder.Find());
        }
    }
}

