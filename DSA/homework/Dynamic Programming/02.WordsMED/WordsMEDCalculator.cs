using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WordsMED
{
    static public class WordsMEDCalculator
    {
        //replace -> check words length
        //remove -> if first word is longer
        //insert -> find longet  substring match

        public static void GetCost(string firstWord, string secondWord)
        {
            //I know that strings are char arrays
            //but I want to encapsulate the logic
            //and keep the loose coupling
            char[] fiWord = firstWord.ToArray();
            char[] secWord = secondWord.ToArray();

            CalcTotalOperations(fiWord, secWord);
                        
        }
  
        private static double CalcTotalOperations(char[] firstArr, char[] secondArr)
        {
            //if the x word is longer than y word
            if (firstArr.Length > secondArr.Length)
            {
                firstArr.ToList();
                int firstWordLength = firstArr.Count();
                secondArr.ToString();

                IList<char> removed = new List<char>();

                for (int index = 0, index2 = 0; index < firstArr.Length && index2 < secondArr.Length; index++, index2++)
                {
                    while (firstWordLength > secondArr.Length)
                    {
                        if (firstArr[index] != secondArr[index2])
                        {
                            removed.Add(firstArr[index]);
                        }
                        firstWordLength--;
                    }
                }
            } 
            
            double cost = 0;
                     
            //if words are with same length
            string commonChars = string.Empty;

            for (int index = 0, index2 = 0; index < firstArr.Length && index2 < secondArr.Length; index++, index2++)
            {
                if (secondArr.Contains(firstArr[index]))
                {
                    commonChars += firstArr[index];
                }
            }

            Console.WriteLine(commonChars);
             return cost;
        }
    }
}
