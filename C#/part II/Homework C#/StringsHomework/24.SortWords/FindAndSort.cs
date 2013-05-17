using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SortWords
{
    class FindAndSort
    {
        static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";

            string[] words = text.Split(' ',',','.','!','?');
            Array.Sort(words);

            Console.WriteLine("Words in an alphabetical order: ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
