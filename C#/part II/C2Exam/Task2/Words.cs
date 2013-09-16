using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Words
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 5;
            List<string> words = new List<string>();

            words = new List<string>{ "16","27", "38", "49", "50"};
            //for (int i = 0; i < n; i++)
            //{
            //    words.Add(Console.ReadLine());
            //}


            string movedWord = string.Empty;
            
            //reorder words
            for (int i = 0; i < words.Count; i++)
            {
                //pick current word to relocate it 
                movedWord = words[i];
                //free the array from this word
                words.RemoveAt(i);
                //insert word to the new index
                int index = 0;
                index = movedWord.Length % (n + 1);
                //checks that index is not out of zero range
                if (index - 1 < 0)
                {
                    index = 1;
                }
                words.Insert(index - 1, movedWord);
            }

            //do the print
            StringBuilder final = new StringBuilder();
            string currWord = string.Empty;

            //find longest word
            int longestWordLen = 0;
            string longestWord = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > longestWordLen)
                {
                    longestWord = words[i];
                    longestWordLen = words[i].Length;
                }
            }

            while (longestWordLen > 0)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i] != "")
                    {                     
                        currWord = words[i];                       
                                            
                        final.Append(currWord[0]);
                    }

                    if (longestWord == words[i] && longestWordLen > 0)
                    {
                        longestWord = longestWord.Remove(0, 1);
                        longestWordLen--;
                    }
                    if (words[i] != "")
                    {
                        words[i] = words[i].Remove(0, 1);
                    }
                }
            }
            
            Console.WriteLine(final);
        }
    }
}
