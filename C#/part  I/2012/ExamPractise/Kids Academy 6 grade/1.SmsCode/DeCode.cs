using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SmsCode
{
    class DeCode
    {
        static void Main()
        {
            Console.WriteLine("Enter word to be coded:");
            string word = Console.ReadLine();

            char[] wordArr = word.ToCharArray();
            string code = " ";
            string finalWord = " ";

            for (int index = 0; index < wordArr.Length; index++)
            {
                //Console.WriteLine(wordArr[index]);
                code = wordArr[0].ToString() + wordArr[1].ToString() + wordArr[0].ToString();
                if (index <= 1)
                {
                    finalWord = code;
                }                
                if(index > 1)
	            {
                    finalWord += wordArr[index] + finalWord; 
	            }                
            }            
            Console.WriteLine(finalWord);








        }
    }
}
