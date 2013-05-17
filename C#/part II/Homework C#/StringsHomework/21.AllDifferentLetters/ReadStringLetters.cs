using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _21.AllDifferentLetters
{
    class ReadStringLetters
    {
        static void Main()
        {
            //Console.WriteLine("Enter random string: ");
            //string text = Console.ReadLine();
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

            string textLower = text.ToLower();

            char[] textLetters = textLower.ToCharArray();

            string onlyLetters = string.Empty;

            foreach (var ch in textLetters)
            {
                if (Char.IsLetter(ch))
                {
                    onlyLetters += ch;
                }
            }

            //Console.WriteLine(onlyLetters);
            char[] finalChars = onlyLetters.ToCharArray();

            Array.Sort(finalChars);
            //Console.WriteLine();
            //foreach (var item in finalChars)
            //{
            //    Console.Write(item);
            //}

            int count = 0;
            for (int i = 0; i < finalChars.Length - 1; i++)
            {
                if (finalChars[i] == finalChars[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                Console.Write(finalChars[i] + " ");
                Console.Write(count);
            }

            //var chars = text.ToLower().ToCharArray().GroupBy(c => c);
            //
            //foreach (var ch in chars)
            //{                
            //    Console.WriteLine("{0}: {1}", ch.Key, ch.Count());                            
            //}


        }
    }
}
