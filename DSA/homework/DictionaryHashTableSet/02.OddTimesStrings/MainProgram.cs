
namespace _02.OddTimesStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            string[] wordsSequence = new string [] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
                        
            PrintOddStrings(CountOddTimesStrings(wordsSequence));            
        }

        //I know that is not good to accept array and to return dictionary
        //but else the coupling is bad - see 01. task
        private static IDictionary<string, int> CountOddTimesStrings(string[] wordsSequence)
        {
            IDictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (var word in wordsSequence)
            {
                int count = 1;
                if (countWords.ContainsKey(word))
                {
                    count = countWords[word] + 1;
                }

                countWords[word] = count;
            }

            return countWords;
        }

        public static void PrintOddStrings(IDictionary<string, int> finalCount)
        {
            foreach (var word in finalCount)
            {
                if (word.Value % 2 == 1)
                {
                    Console.WriteLine("{0}", word.Key);
                }
            }
        }
    }
}
