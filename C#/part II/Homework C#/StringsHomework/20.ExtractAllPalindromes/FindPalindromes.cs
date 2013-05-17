using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ExtractAllPalindromes
{
    class FindPalindromes
    {
        static void Main()
        {
            string text = "ABBA exe lamal sunny water 1221 ok";

            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                if (PalindromeCheck(word) == true)
                {
                    Console.WriteLine(word);
                }   
            }
        }

        private static bool PalindromeCheck(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
