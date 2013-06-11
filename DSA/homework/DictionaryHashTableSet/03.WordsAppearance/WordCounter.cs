
namespace _03.WordsAppearance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    
    public class WordCounter
    {
        public string FilePath { get; set; }

        public WordCounter(string path)
        {
            //in-case we want to check the path via regular expression in the setter
            FilePath = path;
        }

        private string ReadInputFile()
        {   
            IList<string> content = new List<string>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    content.Add(line); 
                    //Console.WriteLine(line); 
                }
            }

            string contentString = string.Empty;

            foreach (var word in content)
            {
                contentString += word.ToLower();
            }

            return contentString;
        }

        private IDictionary<string, int> CountWordsInText()
        {
            IDictionary<string, int> countWords = new Dictionary<string, int>();

            string[] words = ReadInputFile().Split(' ', '.', '!', '?', ',', '�');

            foreach (var word in words)
            {
                
                if (word != "")
                {
                    int count = 1;

                    if (countWords.ContainsKey(word))
                    {
                        count = countWords[word] + 1;
                    }

                    countWords[word] = count;
                }
            }

            return countWords;            
        }

        public void PrintWordsFromTextFile()
        {                         
            IDictionary<string, int> finalCount = CountWordsInText();
            var wordItems = from pair in finalCount
                            orderby pair.Value ascending
                            select pair; 

            foreach (var pair in wordItems)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
