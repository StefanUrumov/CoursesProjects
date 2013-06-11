
namespace _03.WordsAppearance
{
    using System;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            //You must create words.txt in D:\\ or set other path
            string path = "D:\\words.txt";

            WordCounter wordCounter = new WordCounter(path);

            wordCounter.PrintWordsFromTextFile();
        }

        
    }
}
