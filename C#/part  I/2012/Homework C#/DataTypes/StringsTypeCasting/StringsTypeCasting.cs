using System;

    class StringsTypeCasting
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World!";

            object bothWords = firstWord + " " + secondWord;
            
            string finalWords = bothWords.ToString();
            Console.WriteLine(finalWords);
        }
    }

