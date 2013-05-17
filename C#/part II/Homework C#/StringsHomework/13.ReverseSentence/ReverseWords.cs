using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _13.ReverseSentence
{
    class ReverseWords
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            char[] separators = new char[] { ',', ' ', '!', '?', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            SplitWords(words,text);
            
        }

        private static void SplitWords(string[] words, string text)
        {
            string[] arr = Regex.Split(text, "[A-Za-z0-9#+]");
            List<string> nonLetters = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != String.Empty)
                {
                    nonLetters.Add(arr[i]);
                }
            }

            PrintFinal(words, nonLetters);
        }

        private static void PrintFinal(string[] words ,List<string> nonLetters)
        {

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < nonLetters.Count; i++)
            {
                if (i < words.Length)
                {
                    result.Append(words[i]);
                }

                result.Append(nonLetters[i]);
            }
            Console.WriteLine(result.ToString());
        
        }
    }
}
