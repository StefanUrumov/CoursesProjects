using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CountEachWord
{
    class FindAllWords
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

            var words = text.Split(' ', '.', ',').GroupBy(s => s).Select(g => new { word = g.Key, count = g.Count() });

            foreach (var word in words)
            {
                Console.WriteLine("{0}: {1}", word.word, word.count);
            }
        
        }
    }
}
