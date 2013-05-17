using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDigit
{
    class SomeLetter
    {
        static void Main()
        {
            Console.WriteLine("Enter first word: ");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            string secondWord = Console.ReadLine();

            char[] firstWordChar = firstWord.ToCharArray();
            char[] secondWordChar = secondWord.ToCharArray();

            int len = 0;
            int maxLen = 0;
            char bestChar = ' ';

            Array.Sort<char>(firstWordChar);
            Array.Sort<char>(secondWordChar);
            
            foreach (var firstChar in firstWordChar)
            {
                //Console.Write(firstChar + " *");
                //Console.WriteLine();
            
                foreach (var secondChar in secondWordChar)
                {
                    //Console.Write(secondChar + " ");
                    if (firstChar == secondChar)
                    {
                        len++;                        
                        //Console.Write("* ");
                        //Console.WriteLine("len -> {0}", len);
                    }
                    else
                    {
                        len = 0;
                    }
                    if (len > maxLen)
                    {
                        bestChar = firstChar;
                        maxLen = len;
                    }                    
                }
                //Console.WriteLine();                              
            }
            if (maxLen  == 0)
                {
                    Console.WriteLine(maxLen);
                }
                if (bestChar != ' ')
                {
                    Console.WriteLine(bestChar);
                }              
        }
    }
}
